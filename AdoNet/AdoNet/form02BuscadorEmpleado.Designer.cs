
namespace AdoNet
{
    partial class form02BuscadorEmpleado
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnSalario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.btnOficio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(95, 28);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(236, 34);
            this.txtSalario.TabIndex = 1;
            // 
            // btnSalario
            // 
            this.btnSalario.Location = new System.Drawing.Point(347, 22);
            this.btnSalario.Name = "btnSalario";
            this.btnSalario.Size = new System.Drawing.Size(233, 47);
            this.btnSalario.TabIndex = 2;
            this.btnSalario.Text = "Buscar salario";
            this.btnSalario.UseVisualStyleBackColor = true;
            this.btnSalario.Click += new System.EventHandler(this.btnSalario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.ItemHeight = 28;
            this.lstEmpleados.Location = new System.Drawing.Point(12, 219);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(640, 228);
            this.lstEmpleados.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oficio:";
            // 
            // txtOficio
            // 
            this.txtOficio.Location = new System.Drawing.Point(95, 95);
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(236, 34);
            this.txtOficio.TabIndex = 6;
            // 
            // btnOficio
            // 
            this.btnOficio.Location = new System.Drawing.Point(347, 89);
            this.btnOficio.Name = "btnOficio";
            this.btnOficio.Size = new System.Drawing.Size(233, 47);
            this.btnOficio.TabIndex = 7;
            this.btnOficio.Text = "Buscar oficio";
            this.btnOficio.UseVisualStyleBackColor = true;
            this.btnOficio.Click += new System.EventHandler(this.btnOficio_Click);
            // 
            // form02BuscadorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 468);
            this.Controls.Add(this.btnOficio);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "form02BuscadorEmpleado";
            this.Text = "form02BuscadorEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOficio;
        private System.Windows.Forms.Button btnOficio;
    }
}