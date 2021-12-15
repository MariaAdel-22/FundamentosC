
namespace EjerciciosExtra
{
    partial class Hospital
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
            this.panelHospital = new System.Windows.Forms.Panel();
            this.chkHospital = new System.Windows.Forms.CheckBox();
            this.chkSalas = new System.Windows.Forms.CheckBox();
            this.chkEnfermos = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListView();
            this.panelCRUD = new System.Windows.Forms.Panel();
            this.panelHospital.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHospital
            // 
            this.panelHospital.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHospital.Controls.Add(this.chkEnfermos);
            this.panelHospital.Controls.Add(this.chkSalas);
            this.panelHospital.Controls.Add(this.chkHospital);
            this.panelHospital.Location = new System.Drawing.Point(17, 20);
            this.panelHospital.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHospital.Name = "panelHospital";
            this.panelHospital.Size = new System.Drawing.Size(249, 510);
            this.panelHospital.TabIndex = 0;
            // 
            // chkHospital
            // 
            this.chkHospital.AutoSize = true;
            this.chkHospital.Location = new System.Drawing.Point(31, 35);
            this.chkHospital.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkHospital.Name = "chkHospital";
            this.chkHospital.Size = new System.Drawing.Size(171, 29);
            this.chkHospital.TabIndex = 0;
            this.chkHospital.Text = "Cargar Hospitales";
            this.chkHospital.UseVisualStyleBackColor = true;
            // 
            // chkSalas
            // 
            this.chkSalas.AutoSize = true;
            this.chkSalas.Location = new System.Drawing.Point(31, 73);
            this.chkSalas.Name = "chkSalas";
            this.chkSalas.Size = new System.Drawing.Size(128, 29);
            this.chkSalas.TabIndex = 1;
            this.chkSalas.Text = "Cargar Salas";
            this.chkSalas.UseVisualStyleBackColor = true;
            // 
            // chkEnfermos
            // 
            this.chkEnfermos.AutoSize = true;
            this.chkEnfermos.Location = new System.Drawing.Point(31, 119);
            this.chkEnfermos.Name = "chkEnfermos";
            this.chkEnfermos.Size = new System.Drawing.Size(163, 29);
            this.chkEnfermos.TabIndex = 2;
            this.chkEnfermos.Text = "Cargar Enfermos";
            this.chkEnfermos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.panelCRUD);
            this.panel1.Controls.Add(this.lstDatos);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnInsertar);
            this.panel1.Location = new System.Drawing.Point(273, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 510);
            this.panel1.TabIndex = 1;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(39, 25);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(128, 46);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(39, 78);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(128, 48);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(39, 133);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(128, 48);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(39, 187);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 45);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lstDatos
            // 
            this.lstDatos.HideSelection = false;
            this.lstDatos.Location = new System.Drawing.Point(3, 274);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(570, 219);
            this.lstDatos.TabIndex = 4;
            this.lstDatos.UseCompatibleStateImageBehavior = false;
            this.lstDatos.View = System.Windows.Forms.View.Details;
            // 
            // panelCRUD
            // 
            this.panelCRUD.BackColor = System.Drawing.Color.PowderBlue;
            this.panelCRUD.Location = new System.Drawing.Point(173, 13);
            this.panelCRUD.Name = "panelCRUD";
            this.panelCRUD.Size = new System.Drawing.Size(387, 245);
            this.panelCRUD.TabIndex = 5;
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHospital);
            this.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Hospital";
            this.Text = "Hospital";
            this.panelHospital.ResumeLayout(false);
            this.panelHospital.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHospital;
        private System.Windows.Forms.CheckBox chkEnfermos;
        private System.Windows.Forms.CheckBox chkSalas;
        private System.Windows.Forms.CheckBox chkHospital;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCRUD;
        private System.Windows.Forms.ListView lstDatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
    }
}