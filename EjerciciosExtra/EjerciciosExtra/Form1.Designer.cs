
namespace EjerciciosExtra
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
            this.panelCoche = new System.Windows.Forms.GroupBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.pctImagen = new System.Windows.Forms.PictureBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCoches = new System.Windows.Forms.ListBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gpOpciones = new System.Windows.Forms.GroupBox();
            this.rdFecha = new System.Windows.Forms.RadioButton();
            this.rdColor = new System.Windows.Forms.RadioButton();
            this.rdModelo = new System.Windows.Forms.RadioButton();
            this.rdMarca = new System.Windows.Forms.RadioButton();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panelCoche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).BeginInit();
            this.gpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCoche
            // 
            this.panelCoche.Controls.Add(this.btnImagen);
            this.panelCoche.Controls.Add(this.pctImagen);
            this.panelCoche.Controls.Add(this.txtFecha);
            this.panelCoche.Controls.Add(this.label4);
            this.panelCoche.Controls.Add(this.txtColor);
            this.panelCoche.Controls.Add(this.label3);
            this.panelCoche.Controls.Add(this.txtModelo);
            this.panelCoche.Controls.Add(this.label2);
            this.panelCoche.Controls.Add(this.txtMarca);
            this.panelCoche.Controls.Add(this.label1);
            this.panelCoche.Location = new System.Drawing.Point(13, 13);
            this.panelCoche.Name = "panelCoche";
            this.panelCoche.Size = new System.Drawing.Size(219, 484);
            this.panelCoche.TabIndex = 0;
            this.panelCoche.TabStop = false;
            this.panelCoche.Text = "Coche";
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(28, 452);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(174, 32);
            this.btnImagen.TabIndex = 9;
            this.btnImagen.Text = "Examinar..";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // pctImagen
            // 
            this.pctImagen.Location = new System.Drawing.Point(28, 363);
            this.pctImagen.Name = "pctImagen";
            this.pctImagen.Size = new System.Drawing.Size(174, 73);
            this.pctImagen.TabIndex = 8;
            this.pctImagen.TabStop = false;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(28, 310);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(174, 34);
            this.txtFecha.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de inscripción:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(28, 231);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(174, 34);
            this.txtColor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Color:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(28, 150);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(174, 34);
            this.txtModelo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(28, 71);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(174, 34);
            this.txtMarca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // lstCoches
            // 
            this.lstCoches.FormattingEnabled = true;
            this.lstCoches.ItemHeight = 28;
            this.lstCoches.Location = new System.Drawing.Point(264, 25);
            this.lstCoches.Name = "lstCoches";
            this.lstCoches.Size = new System.Drawing.Size(245, 452);
            this.lstCoches.TabIndex = 1;
            this.lstCoches.SelectedIndexChanged += new System.EventHandler(this.lstCoches_SelectedIndexChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(541, 84);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(143, 57);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear coche";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(541, 163);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(143, 78);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar Coches";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gpOpciones
            // 
            this.gpOpciones.Controls.Add(this.rdFecha);
            this.gpOpciones.Controls.Add(this.rdColor);
            this.gpOpciones.Controls.Add(this.rdModelo);
            this.gpOpciones.Controls.Add(this.rdMarca);
            this.gpOpciones.Enabled = false;
            this.gpOpciones.Location = new System.Drawing.Point(528, 261);
            this.gpOpciones.Name = "gpOpciones";
            this.gpOpciones.Size = new System.Drawing.Size(183, 199);
            this.gpOpciones.TabIndex = 4;
            this.gpOpciones.TabStop = false;
            this.gpOpciones.Text = "Opciones";
            // 
            // rdFecha
            // 
            this.rdFecha.AutoSize = true;
            this.rdFecha.Location = new System.Drawing.Point(6, 156);
            this.rdFecha.Name = "rdFecha";
            this.rdFecha.Size = new System.Drawing.Size(179, 32);
            this.rdFecha.TabIndex = 3;
            this.rdFecha.TabStop = true;
            this.rdFecha.Text = "Fecha inscripcion";
            this.rdFecha.UseVisualStyleBackColor = true;
            // 
            // rdColor
            // 
            this.rdColor.AutoSize = true;
            this.rdColor.Location = new System.Drawing.Point(6, 121);
            this.rdColor.Name = "rdColor";
            this.rdColor.Size = new System.Drawing.Size(78, 32);
            this.rdColor.TabIndex = 2;
            this.rdColor.TabStop = true;
            this.rdColor.Text = "Color";
            this.rdColor.UseVisualStyleBackColor = true;
            // 
            // rdModelo
            // 
            this.rdModelo.AutoSize = true;
            this.rdModelo.Location = new System.Drawing.Point(6, 82);
            this.rdModelo.Name = "rdModelo";
            this.rdModelo.Size = new System.Drawing.Size(99, 32);
            this.rdModelo.TabIndex = 1;
            this.rdModelo.TabStop = true;
            this.rdModelo.Text = "Modelo";
            this.rdModelo.UseVisualStyleBackColor = true;
            // 
            // rdMarca
            // 
            this.rdMarca.AutoSize = true;
            this.rdMarca.Location = new System.Drawing.Point(6, 43);
            this.rdMarca.Name = "rdMarca";
            this.rdMarca.Size = new System.Drawing.Size(84, 32);
            this.rdMarca.TabIndex = 0;
            this.rdMarca.TabStop = true;
            this.rdMarca.Text = "Marca";
            this.rdMarca.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(528, 466);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(179, 36);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar Coche";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(541, 25);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(143, 41);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar coche";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 509);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gpOpciones);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lstCoches);
            this.Controls.Add(this.panelCoche);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelCoche.ResumeLayout(false);
            this.panelCoche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagen)).EndInit();
            this.gpOpciones.ResumeLayout(false);
            this.gpOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panelCoche;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.PictureBox pctImagen;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCoches;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox gpOpciones;
        private System.Windows.Forms.RadioButton rdFecha;
        private System.Windows.Forms.RadioButton rdColor;
        private System.Windows.Forms.RadioButton rdModelo;
        private System.Windows.Forms.RadioButton rdMarca;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
    }
}

