namespace Banco_de_sangre
{
    partial class NuevaDonacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaDonacion));
            this.btnaAgregar = new System.Windows.Forms.Button();
            this.txtbTipodeSangre = new System.Windows.Forms.TextBox();
            this.txtbMililitros = new System.Windows.Forms.TextBox();
            this.txtbEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirNuDonacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaAgregar
            // 
            this.btnaAgregar.Location = new System.Drawing.Point(107, 251);
            this.btnaAgregar.Name = "btnaAgregar";
            this.btnaAgregar.Size = new System.Drawing.Size(146, 41);
            this.btnaAgregar.TabIndex = 11;
            this.btnaAgregar.Text = "Agregar";
            this.btnaAgregar.UseVisualStyleBackColor = true;
            this.btnaAgregar.Click += new System.EventHandler(this.btnaAgregar_Click);
            // 
            // txtbTipodeSangre
            // 
            this.txtbTipodeSangre.Location = new System.Drawing.Point(213, 134);
            this.txtbTipodeSangre.Name = "txtbTipodeSangre";
            this.txtbTipodeSangre.Size = new System.Drawing.Size(191, 20);
            this.txtbTipodeSangre.TabIndex = 7;
            // 
            // txtbMililitros
            // 
            this.txtbMililitros.Location = new System.Drawing.Point(213, 189);
            this.txtbMililitros.Name = "txtbMililitros";
            this.txtbMililitros.Size = new System.Drawing.Size(191, 20);
            this.txtbMililitros.TabIndex = 8;
            // 
            // txtbEdad
            // 
            this.txtbEdad.Location = new System.Drawing.Point(213, 86);
            this.txtbEdad.Name = "txtbEdad";
            this.txtbEdad.Size = new System.Drawing.Size(191, 20);
            this.txtbEdad.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de sangre RH: ";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(213, 35);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(191, 20);
            this.txtbNombre.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Litros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // btnSalirNuDonacion
            // 
            this.btnSalirNuDonacion.Location = new System.Drawing.Point(337, 251);
            this.btnSalirNuDonacion.Name = "btnSalirNuDonacion";
            this.btnSalirNuDonacion.Size = new System.Drawing.Size(113, 39);
            this.btnSalirNuDonacion.TabIndex = 12;
            this.btnSalirNuDonacion.Text = "Salir";
            this.btnSalirNuDonacion.UseVisualStyleBackColor = true;
            this.btnSalirNuDonacion.Click += new System.EventHandler(this.btnSalirNuDonacion_Click);
            // 
            // NuevaDonacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 336);
            this.Controls.Add(this.btnSalirNuDonacion);
            this.Controls.Add(this.btnaAgregar);
            this.Controls.Add(this.txtbTipodeSangre);
            this.Controls.Add(this.txtbMililitros);
            this.Controls.Add(this.txtbEdad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevaDonacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaDonacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaAgregar;
        private System.Windows.Forms.TextBox txtbTipodeSangre;
        private System.Windows.Forms.TextBox txtbMililitros;
        private System.Windows.Forms.TextBox txtbEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirNuDonacion;
    }
}