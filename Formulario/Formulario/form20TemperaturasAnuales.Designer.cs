
namespace Formulario
{
    partial class form20TemperaturasAnuales
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
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.btnMeses = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meses";
            // 
            // lstMeses
            // 
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.ItemHeight = 28;
            this.lstMeses.Location = new System.Drawing.Point(12, 61);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(186, 368);
            this.lstMeses.TabIndex = 1;
            // 
            // btnMeses
            // 
            this.btnMeses.Location = new System.Drawing.Point(277, 61);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(207, 40);
            this.btnMeses.TabIndex = 2;
            this.btnMeses.Text = "Generar meses";
            this.btnMeses.UseVisualStyleBackColor = true;
            this.btnMeses.Click += new System.EventHandler(this.btnMeses_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(277, 128);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(207, 38);
            this.btnDatos.TabIndex = 3;
            this.btnDatos.Text = "Mostrar datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperatura máxima";
            // 
            // txtMaxima
            // 
            this.txtMaxima.Location = new System.Drawing.Point(277, 244);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.Size = new System.Drawing.Size(194, 34);
            this.txtMaxima.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Temperatura mínima";
            // 
            // txtMinima
            // 
            this.txtMinima.Location = new System.Drawing.Point(277, 360);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.Size = new System.Drawing.Size(194, 34);
            this.txtMinima.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temperatura media";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(277, 457);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(180, 34);
            this.txtMedia.TabIndex = 9;
            // 
            // form20TemperaturasAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 503);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMinima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaxima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.btnMeses);
            this.Controls.Add(this.lstMeses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "form20TemperaturasAnuales";
            this.Text = "form20TemperaturasAnuales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.Button btnMeses;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMinima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedia;
    }
}