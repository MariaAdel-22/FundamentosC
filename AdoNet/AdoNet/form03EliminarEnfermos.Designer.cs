
namespace AdoNet
{
    partial class form03EliminarEnfermos
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
            this.txtInscripcion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstEnfermos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscripción";
            // 
            // txtInscripcion
            // 
            this.txtInscripcion.Location = new System.Drawing.Point(35, 74);
            this.txtInscripcion.Name = "txtInscripcion";
            this.txtInscripcion.Size = new System.Drawing.Size(212, 34);
            this.txtInscripcion.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(35, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(212, 46);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enfermos";
            // 
            // lstEnfermos
            // 
            this.lstEnfermos.FormattingEnabled = true;
            this.lstEnfermos.ItemHeight = 28;
            this.lstEnfermos.Location = new System.Drawing.Point(293, 51);
            this.lstEnfermos.Name = "lstEnfermos";
            this.lstEnfermos.Size = new System.Drawing.Size(327, 396);
            this.lstEnfermos.TabIndex = 4;
            // 
            // form03EliminarEnfermos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 456);
            this.Controls.Add(this.lstEnfermos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtInscripcion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "form03EliminarEnfermos";
            this.Text = "form03EliminarEnfermos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInscripcion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstEnfermos;
    }
}