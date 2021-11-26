
namespace Formulario
{
    partial class form22EjemploMeses
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
            this.lsMeses = new System.Windows.Forms.ListBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinima = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meses";
            // 
            // lsMeses
            // 
            this.lsMeses.FormattingEnabled = true;
            this.lsMeses.ItemHeight = 28;
            this.lsMeses.Location = new System.Drawing.Point(29, 70);
            this.lsMeses.Name = "lsMeses";
            this.lsMeses.Size = new System.Drawing.Size(256, 424);
            this.lsMeses.TabIndex = 1;
            this.lsMeses.SelectedIndexChanged += new System.EventHandler(this.lsMeses_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(406, 70);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(192, 41);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar meses";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mes:";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(464, 165);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(145, 34);
            this.txtMes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Temperatura máxima";
            // 
            // txtMaxima
            // 
            this.txtMaxima.Location = new System.Drawing.Point(606, 247);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.Size = new System.Drawing.Size(100, 34);
            this.txtMaxima.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Temperatura mínima:";
            // 
            // txtMinima
            // 
            this.txtMinima.Location = new System.Drawing.Point(608, 330);
            this.txtMinima.Name = "txtMinima";
            this.txtMinima.Size = new System.Drawing.Size(98, 34);
            this.txtMinima.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Temperatura media:";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(608, 408);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(98, 34);
            this.txtMedia.TabIndex = 10;
            // 
            // form22EjemploMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 521);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMinima);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaxima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lsMeses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "form22EjemploMeses";
            this.Text = "form22EjemploMeses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsMeses;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaxima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinima;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMedia;
    }
}