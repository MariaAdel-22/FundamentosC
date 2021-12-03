
namespace AdoNet
{
    partial class form04EnfermosParameter
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
            this.lstEnfermos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtInscripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEnfermos
            // 
            this.lstEnfermos.FormattingEnabled = true;
            this.lstEnfermos.ItemHeight = 28;
            this.lstEnfermos.Location = new System.Drawing.Point(265, 50);
            this.lstEnfermos.Name = "lstEnfermos";
            this.lstEnfermos.Size = new System.Drawing.Size(327, 396);
            this.lstEnfermos.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enfermos";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(7, 128);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(212, 46);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtInscripcion
            // 
            this.txtInscripcion.Location = new System.Drawing.Point(7, 73);
            this.txtInscripcion.Name = "txtInscripcion";
            this.txtInscripcion.Size = new System.Drawing.Size(212, 34);
            this.txtInscripcion.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inscripción";
            // 
            // form04EnfermosParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 482);
            this.Controls.Add(this.lstEnfermos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtInscripcion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "form04EnfermosParameter";
            this.Text = "form04EnfermosParameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEnfermos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtInscripcion;
        private System.Windows.Forms.Label label1;
    }
}