
namespace AdoNet
{
    partial class form12EmpleadosOficios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOficios = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvEmpleados = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIncrementar = new System.Windows.Forms.TextBox();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oficios";
            // 
            // cmbOficios
            // 
            this.cmbOficios.FormattingEnabled = true;
            this.cmbOficios.Location = new System.Drawing.Point(13, 57);
            this.cmbOficios.Name = "cmbOficios";
            this.cmbOficios.Size = new System.Drawing.Size(214, 36);
            this.cmbOficios.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(253, 37);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(159, 75);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Empleados";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleados";
            // 
            // lsvEmpleados
            // 
            this.lsvEmpleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvEmpleados.HideSelection = false;
            this.lsvEmpleados.Location = new System.Drawing.Point(12, 176);
            this.lsvEmpleados.Name = "lsvEmpleados";
            this.lsvEmpleados.Size = new System.Drawing.Size(541, 244);
            this.lsvEmpleados.TabIndex = 4;
            this.lsvEmpleados.UseCompatibleStateImageBehavior = false;
            this.lsvEmpleados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Apellido";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oficio";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salario";
            this.columnHeader3.Width = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Incremento:";
            // 
            // txtIncrementar
            // 
            this.txtIncrementar.Location = new System.Drawing.Point(452, 69);
            this.txtIncrementar.Name = "txtIncrementar";
            this.txtIncrementar.Size = new System.Drawing.Size(132, 34);
            this.txtIncrementar.TabIndex = 6;
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(452, 110);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(132, 35);
            this.btnIncrementar.TabIndex = 7;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // form12EmpleadosOficios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 432);
            this.Controls.Add(this.btnIncrementar);
            this.Controls.Add(this.txtIncrementar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsvEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cmbOficios);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "form12EmpleadosOficios";
            this.Text = "form12EmpleadosOficios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOficios;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvEmpleados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIncrementar;
        private System.Windows.Forms.Button btnIncrementar;
    }
}