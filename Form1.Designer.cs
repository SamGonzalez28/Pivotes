namespace Pivotes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnleer = new System.Windows.Forms.Button();
            this.dgRestriccion = new System.Windows.Forms.DataGridView();
            this.x1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFuncion = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbopcion = new System.Windows.Forms.ComboBox();
            this.dgResult = new System.Windows.Forms.DataGridView();
            this.lbRes = new System.Windows.Forms.Label();
            this.nUDres = new System.Windows.Forms.NumericUpDown();
            this.nUDvar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRestriccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDvar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnleer
            // 
            this.btnleer.Location = new System.Drawing.Point(886, 217);
            this.btnleer.Name = "btnleer";
            this.btnleer.Size = new System.Drawing.Size(75, 23);
            this.btnleer.TabIndex = 105;
            this.btnleer.Text = "Leer";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // dgRestriccion
            // 
            this.dgRestriccion.AllowUserToAddRows = false;
            this.dgRestriccion.AllowUserToDeleteRows = false;
            this.dgRestriccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRestriccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x1,
            this.x2,
            this.x3,
            this.Signo,
            this.solucion});
            this.dgRestriccion.Location = new System.Drawing.Point(160, 107);
            this.dgRestriccion.Name = "dgRestriccion";
            this.dgRestriccion.Size = new System.Drawing.Size(701, 103);
            this.dgRestriccion.TabIndex = 106;
            // 
            // x1
            // 
            this.x1.HeaderText = "x1";
            this.x1.Name = "x1";
            this.x1.Width = 50;
            // 
            // x2
            // 
            this.x2.HeaderText = "x2";
            this.x2.Name = "x2";
            this.x2.Width = 50;
            // 
            // x3
            // 
            this.x3.HeaderText = "x3";
            this.x3.Name = "x3";
            this.x3.Width = 50;
            // 
            // Signo
            // 
            this.Signo.HeaderText = "Signo";
            this.Signo.Name = "Signo";
            // 
            // solucion
            // 
            this.solucion.HeaderText = "Solución";
            this.solucion.Name = "solucion";
            // 
            // dgFuncion
            // 
            this.dgFuncion.AllowUserToAddRows = false;
            this.dgFuncion.AllowUserToDeleteRows = false;
            this.dgFuncion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFuncion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgFuncion.Location = new System.Drawing.Point(160, 24);
            this.dgFuncion.Name = "dgFuncion";
            this.dgFuncion.Size = new System.Drawing.Size(701, 67);
            this.dgFuncion.TabIndex = 107;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "x1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "x2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "x3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // cbopcion
            // 
            this.cbopcion.FormattingEnabled = true;
            this.cbopcion.Items.AddRange(new object[] {
            "MAXIMIZAR",
            "MINIMIZAR"});
            this.cbopcion.Location = new System.Drawing.Point(867, 24);
            this.cbopcion.Name = "cbopcion";
            this.cbopcion.Size = new System.Drawing.Size(91, 21);
            this.cbopcion.TabIndex = 108;
            this.cbopcion.Text = "MAXIMIZAR";
            // 
            // dgResult
            // 
            this.dgResult.AllowUserToAddRows = false;
            this.dgResult.AllowUserToDeleteRows = false;
            this.dgResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResult.Location = new System.Drawing.Point(16, 246);
            this.dgResult.Name = "dgResult";
            this.dgResult.ReadOnly = true;
            this.dgResult.Size = new System.Drawing.Size(845, 150);
            this.dgResult.TabIndex = 109;
            // 
            // lbRes
            // 
            this.lbRes.AutoSize = true;
            this.lbRes.Location = new System.Drawing.Point(13, 129);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(86, 13);
            this.lbRes.TabIndex = 113;
            this.lbRes.Text = "N° Restricciones";
            // 
            // nUDres
            // 
            this.nUDres.Location = new System.Drawing.Point(105, 127);
            this.nUDres.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDres.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDres.Name = "nUDres";
            this.nUDres.Size = new System.Drawing.Size(35, 20);
            this.nUDres.TabIndex = 114;
            this.nUDres.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDres.ValueChanged += new System.EventHandler(this.nUDres_ValueChanged);
            // 
            // nUDvar
            // 
            this.nUDvar.Location = new System.Drawing.Point(105, 43);
            this.nUDvar.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDvar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDvar.Name = "nUDvar";
            this.nUDvar.Size = new System.Drawing.Size(35, 20);
            this.nUDvar.TabIndex = 116;
            this.nUDvar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDvar.ValueChanged += new System.EventHandler(this.nUDvar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 115;
            this.label1.Text = "N° Variable";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(883, 271);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 34);
            this.btnNuevo.TabIndex = 117;
            this.btnNuevo.Text = "Nuevo Pivote";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Visible = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 434);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.nUDvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUDres);
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.dgResult);
            this.Controls.Add(this.cbopcion);
            this.Controls.Add(this.dgFuncion);
            this.Controls.Add(this.dgRestriccion);
            this.Controls.Add(this.btnleer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgRestriccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFuncion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnleer;
        private System.Windows.Forms.DataGridView dgRestriccion;
        private System.Windows.Forms.DataGridView dgFuncion;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2;
        private System.Windows.Forms.DataGridViewTextBoxColumn x3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Signo;
        private System.Windows.Forms.DataGridViewTextBoxColumn solucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox cbopcion;
        private System.Windows.Forms.DataGridView dgResult;
        private System.Windows.Forms.Label lbRes;
        private System.Windows.Forms.NumericUpDown nUDres;
        private System.Windows.Forms.NumericUpDown nUDvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
    }
}

