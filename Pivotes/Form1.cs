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
        Double[] func = new double[4];
        Double[,] rest = new double[3, 5];
        
        private void btnleer_Click(object sender, EventArgs e)
        {
            dgResult.Columns.Clear();
            String dato = "0";
            for (int i = 0; i < dgFuncion.Rows[0].Cells.Count; i++)
            {
                dato = dgFuncion.Rows[0].Cells[i].Value.ToString();
                func[i] = Convert.ToDouble(dato);
                String aux = Convert.ToString(func[i]);
                //MessageBox.Show(aux);
            }

            for (int fila = 0; fila < dgRestriccion.Rows.Count ; fila++)
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
                else if(signo == 1){
                    arraySignos[i] = -1;
                    c++;
                }
                else
                {
                    arraySignos[i] = 0;
                }
                
            }

            int newColum = dgRestriccion.Columns.Count  -2 + c;
            Double[,] rest2 = new Double[dgRestriccion.Rows.Count, (newColum + 2)];

            dgResult.Columns.Add("Pivote", "Pivote");
            for (int i = 0; i < newColum; i++)
            {
                dgResult.Columns.Add("x" + (i + 1), "x" + (i + 1));
            }
            dgResult.Columns.Add("Igualdad", "Igualdad");

            int varia = Convert.ToInt32(nUDvar.Value);
            int contV = Convert.ToInt32(nUDvar.Value);
            for (int i = 0; i < dgRestriccion.Rows.Count; i++)
            {
                for (int j = 0; j < newColum+1; j++) 
                {
                    if (j == 0)
                    {
                        rest2[i, j] = rest[i, j];
                    }
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
                        else if (j ==contV  && arraySignos[i] == -1)
                        {
                            rest2[i, j] = -1;
                            arraySignos[i] = 0;
                            contV++;
                        }

                        if (j == varia+c )
                        {
                            rest2[i, j] = rest[i, dgRestriccion.Columns.Count-1];
                        }
                    }
                    String das = Convert.ToString(rest2[i, j]);
                    MessageBox.Show(das);
                }
            }
        }

        private void nUDvar_ValueChanged(object sender, EventArgs e)
        {
            dgFuncion.Columns.Clear();
            dgRestriccion.Columns.Clear();
            
            int variable= Convert.ToInt32(nUDvar.Value);
            for (int i = 0; i < variable; i++)
            {
                dgFuncion.Columns.Add("x"+(i+1), "x" + (i+1));
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
            
            for (int i = 0; i < restricciones; i++)
            {
                dgRestriccion.Rows.Add();
            }
        }
    }
}
