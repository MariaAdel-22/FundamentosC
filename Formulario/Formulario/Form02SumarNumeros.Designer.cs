
namespace Formulario
{
    partial class Form02SumarNumeros
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(48, 60);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(116, 15);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Introducir numero 1:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(183, 60);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(126, 23);
            this.txt1.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(48, 104);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(116, 15);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Introducir numero 2:";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(183, 104);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(126, 23);
            this.txt2.TabIndex = 3;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(48, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 15);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "lblResultado";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(199, 181);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(130, 31);
            this.btnSumar.TabIndex = 5;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // Form02SumarNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 342);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form02SumarNumeros";
            this.Text = "Form02SumarNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSumar;
    }
}