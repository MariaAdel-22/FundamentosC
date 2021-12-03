
namespace AdoNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lsApellidos = new System.Windows.Forms.ListBox();
            this.Columnas = new System.Windows.Forms.Label();
            this.lstColumnas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTiposDato = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(22, 13);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(133, 47);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(22, 90);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(133, 54);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(22, 182);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(133, 50);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "Leer datos";
            this.btnLeer.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(22, 386);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(106, 28);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "lblMensaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellidos";
            // 
            // lsApellidos
            // 
            this.lsApellidos.FormattingEnabled = true;
            this.lsApellidos.ItemHeight = 28;
            this.lsApellidos.Location = new System.Drawing.Point(199, 67);
            this.lsApellidos.Name = "lsApellidos";
            this.lsApellidos.Size = new System.Drawing.Size(164, 368);
            this.lsApellidos.TabIndex = 5;
            // 
            // Columnas
            // 
            this.Columnas.AutoSize = true;
            this.Columnas.Location = new System.Drawing.Point(411, 13);
            this.Columnas.Name = "Columnas";
            this.Columnas.Size = new System.Drawing.Size(98, 28);
            this.Columnas.TabIndex = 6;
            this.Columnas.Text = "Columnas";
            // 
            // lstColumnas
            // 
            this.lstColumnas.FormattingEnabled = true;
            this.lstColumnas.ItemHeight = 28;
            this.lstColumnas.Location = new System.Drawing.Point(411, 67);
            this.lstColumnas.Name = "lstColumnas";
            this.lstColumnas.Size = new System.Drawing.Size(163, 368);
            this.lstColumnas.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipos Dato";
            // 
            // lstTiposDato
            // 
            this.lstTiposDato.FormattingEnabled = true;
            this.lstTiposDato.ItemHeight = 28;
            this.lstTiposDato.Location = new System.Drawing.Point(609, 67);
            this.lstTiposDato.Name = "lstTiposDato";
            this.lstTiposDato.Size = new System.Drawing.Size(162, 368);
            this.lstTiposDato.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 439);
            this.Controls.Add(this.lstTiposDato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstColumnas);
            this.Controls.Add(this.Columnas);
            this.Controls.Add(this.lsApellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsApellidos;
        private System.Windows.Forms.Label Columnas;
        private System.Windows.Forms.ListBox lstColumnas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTiposDato;
    }
}

