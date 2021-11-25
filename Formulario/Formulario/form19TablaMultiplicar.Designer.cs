
namespace Formulario
{
    partial class form19TablaMultiplicar
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.panelTabla = new System.Windows.Forms.GroupBox();
            this.txtMul2 = new System.Windows.Forms.TextBox();
            this.txtMul3 = new System.Windows.Forms.TextBox();
            this.txtMul4 = new System.Windows.Forms.TextBox();
            this.txtMul5 = new System.Windows.Forms.TextBox();
            this.txtMul1 = new System.Windows.Forms.TextBox();
            this.txtMul6 = new System.Windows.Forms.TextBox();
            this.panelTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(33, 71);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(159, 34);
            this.txtNumero.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(33, 138);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(150, 37);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar tabla";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.txtMul2);
            this.panelTabla.Controls.Add(this.txtMul3);
            this.panelTabla.Controls.Add(this.txtMul4);
            this.panelTabla.Controls.Add(this.txtMul5);
            this.panelTabla.Controls.Add(this.txtMul1);
            this.panelTabla.Controls.Add(this.txtMul6);
            this.panelTabla.Location = new System.Drawing.Point(386, 29);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(231, 405);
            this.panelTabla.TabIndex = 3;
            this.panelTabla.TabStop = false;
            this.panelTabla.Text = "Tabla multiplicar";
            // 
            // txtMul2
            // 
            this.txtMul2.Location = new System.Drawing.Point(45, 117);
            this.txtMul2.Name = "txtMul2";
            this.txtMul2.Size = new System.Drawing.Size(121, 34);
            this.txtMul2.TabIndex = 5;
            // 
            // txtMul3
            // 
            this.txtMul3.Location = new System.Drawing.Point(45, 170);
            this.txtMul3.Name = "txtMul3";
            this.txtMul3.Size = new System.Drawing.Size(121, 34);
            this.txtMul3.TabIndex = 4;
            // 
            // txtMul4
            // 
            this.txtMul4.Location = new System.Drawing.Point(45, 222);
            this.txtMul4.Name = "txtMul4";
            this.txtMul4.Size = new System.Drawing.Size(121, 34);
            this.txtMul4.TabIndex = 3;
            // 
            // txtMul5
            // 
            this.txtMul5.Location = new System.Drawing.Point(45, 272);
            this.txtMul5.Name = "txtMul5";
            this.txtMul5.Size = new System.Drawing.Size(121, 34);
            this.txtMul5.TabIndex = 2;
            // 
            // txtMul1
            // 
            this.txtMul1.Location = new System.Drawing.Point(45, 69);
            this.txtMul1.Name = "txtMul1";
            this.txtMul1.Size = new System.Drawing.Size(121, 34);
            this.txtMul1.TabIndex = 0;
            // 
            // txtMul6
            // 
            this.txtMul6.Location = new System.Drawing.Point(45, 324);
            this.txtMul6.Name = "txtMul6";
            this.txtMul6.Size = new System.Drawing.Size(121, 34);
            this.txtMul6.TabIndex = 1;
            // 
            // form19TablaMultiplicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 469);
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "form19TablaMultiplicar";
            this.Text = "form19TablaMultiplicar";
            this.panelTabla.ResumeLayout(false);
            this.panelTabla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox panelTabla;
        private System.Windows.Forms.TextBox txtMul2;
        private System.Windows.Forms.TextBox txtMul3;
        private System.Windows.Forms.TextBox txtMul4;
        private System.Windows.Forms.TextBox txtMul5;
        private System.Windows.Forms.TextBox txtMul6;
        private System.Windows.Forms.TextBox txtMul1;
    }
}