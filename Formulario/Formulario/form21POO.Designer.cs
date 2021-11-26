
namespace Formulario
{
    partial class form21POO
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
            this.btnPersona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPropiedades = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(60, 63);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(123, 75);
            this.btnPersona.TabIndex = 0;
            this.btnPersona.Text = "Instanciar Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Propiedades";
            // 
            // lstPropiedades
            // 
            this.lstPropiedades.FormattingEnabled = true;
            this.lstPropiedades.ItemHeight = 28;
            this.lstPropiedades.Location = new System.Drawing.Point(259, 103);
            this.lstPropiedades.Name = "lstPropiedades";
            this.lstPropiedades.Size = new System.Drawing.Size(483, 284);
            this.lstPropiedades.TabIndex = 2;
            // 
            // form21POO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 487);
            this.Controls.Add(this.lstPropiedades);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPersona);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "form21POO";
            this.Text = "form21POO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPropiedades;
    }
}