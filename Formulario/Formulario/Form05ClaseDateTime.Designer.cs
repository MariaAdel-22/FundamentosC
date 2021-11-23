
namespace Formulario
{
    partial class Form05ClaseDateTime
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
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.chkFormato = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbdDia = new System.Windows.Forms.RadioButton();
            this.rbdMes = new System.Windows.Forms.RadioButton();
            this.rbdAnyo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncremento = new System.Windows.Forms.TextBox();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Actual";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(90, 93);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(244, 23);
            this.txtFecha.TabIndex = 1;
            // 
            // chkFormato
            // 
            this.chkFormato.AutoSize = true;
            this.chkFormato.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkFormato.Location = new System.Drawing.Point(90, 145);
            this.chkFormato.Name = "chkFormato";
            this.chkFormato.Size = new System.Drawing.Size(228, 29);
            this.chkFormato.TabIndex = 2;
            this.chkFormato.Text = "Cambiar Formato fecha";
            this.chkFormato.UseVisualStyleBackColor = true;
            this.chkFormato.CheckedChanged += new System.EventHandler(this.chkFormato_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncrementar);
            this.groupBox1.Controls.Add(this.txtIncremento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbdAnyo);
            this.groupBox1.Controls.Add(this.rbdMes);
            this.groupBox1.Controls.Add(this.rbdDia);
            this.groupBox1.Location = new System.Drawing.Point(90, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Incrementar Fecha";
            // 
            // rbdDia
            // 
            this.rbdDia.AutoSize = true;
            this.rbdDia.Location = new System.Drawing.Point(7, 23);
            this.rbdDia.Name = "rbdDia";
            this.rbdDia.Size = new System.Drawing.Size(60, 19);
            this.rbdDia.TabIndex = 0;
            this.rbdDia.TabStop = true;
            this.rbdDia.Text = "rbdDia";
            this.rbdDia.UseVisualStyleBackColor = true;
            // 
            // rbdMes
            // 
            this.rbdMes.AutoSize = true;
            this.rbdMes.Location = new System.Drawing.Point(7, 48);
            this.rbdMes.Name = "rbdMes";
            this.rbdMes.Size = new System.Drawing.Size(65, 19);
            this.rbdMes.TabIndex = 1;
            this.rbdMes.TabStop = true;
            this.rbdMes.Text = "rbdMes";
            this.rbdMes.UseVisualStyleBackColor = true;
            // 
            // rbdAnyo
            // 
            this.rbdAnyo.AutoSize = true;
            this.rbdAnyo.Location = new System.Drawing.Point(7, 73);
            this.rbdAnyo.Name = "rbdAnyo";
            this.rbdAnyo.Size = new System.Drawing.Size(71, 19);
            this.rbdAnyo.TabIndex = 2;
            this.rbdAnyo.TabStop = true;
            this.rbdAnyo.Text = "rbdAnyo";
            this.rbdAnyo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento:";
            // 
            // txtIncremento
            // 
            this.txtIncremento.Location = new System.Drawing.Point(184, 43);
            this.txtIncremento.Name = "txtIncremento";
            this.txtIncremento.Size = new System.Drawing.Size(82, 23);
            this.txtIncremento.TabIndex = 4;
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Location = new System.Drawing.Point(176, 84);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(99, 23);
            this.btnIncrementar.TabIndex = 5;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(90, 368);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(244, 23);
            this.txtNuevaFecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(90, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nueva Fecha";
            // 
            // Form05ClaseDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 403);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkFormato);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label1);
            this.Name = "Form05ClaseDateTime";
            this.Text = "Form05ClaseDateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.CheckBox chkFormato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.TextBox txtIncremento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbdAnyo;
        private System.Windows.Forms.RadioButton rbdMes;
        private System.Windows.Forms.RadioButton rbdDia;
        private System.Windows.Forms.TextBox txtNuevaFecha;
        private System.Windows.Forms.Label label3;
    }
}