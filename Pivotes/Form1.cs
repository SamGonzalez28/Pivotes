using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pivotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Double[] func;
        Double[] func2;
        Double[,] rest/* = new double[5, 5]*/;
        Double[,] rest2;

        private void btnleer_Click(object sender, EventArgs e)
        {
            dgResult.Columns.Clear();
            String dato = "0";
            for (int i = 0; i < dgFuncion.Rows[0].Cells.Count; i++)
            {
                dato = dgFuncion.Rows[0].Cells[i].Value.ToString();
                func[i] = Convert.ToDouble(dato);
            }

            for (int fila = 0; fila < dgRestriccion.Rows.Count; fila++)
            {
                for (int colum = 0; colum < dgRestriccion.Rows[fila].Cells.Count; colum++)
                {
                    dato = dgRestriccion.Rows[fila].Cells[colum].Value.ToString();
                    rest[fila, colum] = Convert.ToDouble(dato);

                    String aux = Convert.ToString(rest[fila, colum]);

                }
            }
            estandarizacion();

        }

        private void estandarizacion()
        {
            if (cbopcion.SelectedItem.ToString() == "MAXIMIZAR")
            {
                for (int i = 0; i < func.Length; i++)
                {
                    func[i] *= -1;
                }
            }
            int[] arraySignos = new int[dgRestriccion.Rows.Count];
            int c = 0;
            for (int i = 0; i < dgRestriccion.Rows.Count; i++)
            {
                int signo = Convert.ToInt32(dgRestriccion.Rows[i].Cells[dgRestriccion.Columns.Count - 2].Value.ToString());
                if (signo == 2)
                {
                    arraySignos[i] = 1;
                    c++;
                }
                else if (signo == 1)
                {
                    arraySignos[i] = -1;
                    c++;
                }
                else
                {
                    arraySignos[i] = 0;
                }

            }

            int newColum = dgRestriccion.Columns.Count - 2 + c;

            //dgResult.Columns.Add("Pivote", "Pivote");
            for (int i = 0; i < newColum; i++)
            {
                dgResult.Columns.Add("x" + (i + 1), "x" + (i + 1));
            }
            dgResult.Columns.Add("Igualdad", "Igualdad");

            rest2 = new Double[Convert.ToInt32(nUDres.Value), newColum + 1];
            func2 = new Double[newColum + 2];

            int varia = Convert.ToInt32(nUDvar.Value);
            int contV = Convert.ToInt32(nUDvar.Value);
            for (int i = 0; i < dgRestriccion.Rows.Count; i++)
            {
                for (int j = 0; j < newColum + 1; j++)
                {
                    if (j < varia)
                    {
                        rest2[i, j] = rest[i, j];
                    }
                    else
                    {
                        if (j == contV && arraySignos[i] == 1)
                        {
                            rest2[i, j] = 1;
                            arraySignos[i] = 0;
                            contV++;
                        }
                        else if (j == contV && arraySignos[i] == -1)
                        {
                            rest2[i, j] = -1;
                            arraySignos[i] = 0;
                            contV++;
                        }

                        if (j == varia + c)
                        {
                            rest2[i, j] = rest[i, dgRestriccion.Columns.Count - 1];
                        }
                    }
                }
            }


            for (int i = 0; i < dgRestriccion.Rows.Count; i++)
            {
                int signo = Convert.ToInt32(dgRestriccion.Rows[i].Cells[dgRestriccion.Columns.Count - 2].Value.ToString());
                if (signo == 1)
                {
                    for (int j = 0; j < newColum + 1; j++)
                    {
                        rest2[i, j] = rest2[i, j] * -1;
                    }
                }
            }

            for (int i = 0; i < func2.Length; i++)
            {
                if (i < func.Length)
                {
                    func2[i] = func[i];
                }
                else
                {
                    func2[i] = 0;
                }
            }
            PresentarIteracion(rest2, func2);
        }

        private void PresentarIteracion(Double[,] res, Double[] fun)
        {
            for (int i = 0; i < rest2.GetLength(0); i++)
            {
                dgResult.Rows.Add();
                for (int j = 0; j < rest2.GetLength(1); j++)
                {
                    dgResult.Rows[i].Cells[j].Value = res[i, j];
                }
            }
            dgResult.Rows.Add();
            //MessageBox.Show(fun.Length + " - " + funcion.Length);
            for (int i = 0; i < fun.Length - 1; i++)
            {
                dgResult.Rows[dgRestriccion.Rows.Count].Cells[i].Value = fun[i];
            }
            btnNuevo.Visible = true;
        }
        private void SelectPivote(Double[] arrayfun, Double[,] arrayres)
        {
            //int numVar = arrayres.Length - arrayfun.Length;

            int posicion = pivoteFun(arrayfun);
            int fila = 0;

            Double razon = 0.0;
            Double comp = 2000;
            for (int i = 0; i < dgRestriccion.Rows.Count; i++)
            {
                if (arrayres[i, posicion] > 0)
                {
                    razon = arrayres[i, dgResult.Columns.Count - 1] / arrayres[i, posicion];
                    //MessageBox.Show(arrayres[i, dgResult.Columns.Count - 1]+" / "+arrayres[i, posicion]);
                    if (razon < comp)
                    {
                        comp = razon;
                        fila = i;
                    }
                }
            }
            Double pivote = rest2[fila, posicion];// Convert.ToInt32(dgResult.Rows[fila].Cells[posicion].Value);
            //MessageBox.Show("piv: " + pivote);
            if (pivote != 1)
            {
                for (int i = 0; i < dgResult.Columns.Count; i++)
                {
                    rest2[fila, i] /= pivote;
                }
            }
            Double coef = 0;
            for (int i = 0; i < rest2.GetLength(0); i++)
            {
                coef = rest2[i, posicion];

                if (i != fila)
                {
                    for (int j = 0; j < rest2.GetLength(1); j++)
                    {
                        //MessageBox.Show("coef:" + coef);
                        rest2[i, j] = ((coef * rest2[fila, j]) + (rest2[i, j] * -1)) * -1;

                    }
                }
            }
            coef = func2[posicion];
            for (int i = 0; i < func2.Length-1; i++)
            {
                func2[i] = ( rest2[fila,i] *coef *-1) + func2[i];
            }
        }
        private int pivoteFun(Double[] arrayFun)
        {
            Double comp = 2000;//para comparar si el valor menor
            int posicion = 0;
            for (int i = 0; i < arrayFun.Length; i++)
            {
                if (arrayFun[i] < comp)
                {
                    comp = arrayFun[i];
                    posicion = i;
                }
            }
            return posicion;
        }


        private void nUDvar_ValueChanged(object sender, EventArgs e)
        {
            dgFuncion.Columns.Clear();
            dgRestriccion.Columns.Clear();

            int variable = Convert.ToInt32(nUDvar.Value);

            func = new Double[variable];

            for (int i = 0; i < variable; i++)
            {
                dgFuncion.Columns.Add("x" + (i + 1), "x" + (i + 1));
                dgRestriccion.Columns.Add("x" + (i + 1), "x" + (i + 1));
            }
            dgRestriccion.Columns.Add("Signo", "Signo");
            dgRestriccion.Columns.Add("Solucion", "Solucion");
            dgFuncion.Rows.Add();

        }

        private void nUDres_ValueChanged(object sender, EventArgs e)
        {
            dgRestriccion.Rows.Clear();
            int restricciones = Convert.ToInt32(nUDres.Value);

            rest = new Double[restricciones, Convert.ToInt32(nUDvar.Value) + 2];

            for (int i = 0; i < restricciones; i++)
            {
                dgRestriccion.Rows.Add();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //dgResult.Rows.Clear();
            SelectPivote(func2, rest2);
            PresentarIteracion(rest2, func2);
        }
    }
}
