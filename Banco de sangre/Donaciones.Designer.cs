namespace Banco_de_sangre
{
    partial class Donaciones
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbTipoDeSangre = new System.Windows.Forms.Label();
            this.lbMililitros = new System.Windows.Forms.Label();
            this.lstbListaDonantes = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaDonaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalirDonaciones = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo de sangre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mililitros:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(516, 66);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(37, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "_____";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(516, 116);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(37, 13);
            this.lbEdad.TabIndex = 1;
            this.lbEdad.Text = "_____";
            // 
            // lbTipoDeSangre
            // 
            this.lbTipoDeSangre.AutoSize = true;
            this.lbTipoDeSangre.Location = new System.Drawing.Point(516, 166);
            this.lbTipoDeSangre.Name = "lbTipoDeSangre";
            this.lbTipoDeSangre.Size = new System.Drawing.Size(37, 13);
            this.lbTipoDeSangre.TabIndex = 1;
            this.lbTipoDeSangre.Text = "_____";
            // 
            // lbMililitros
            // 
            this.lbMililitros.AutoSize = true;
            this.lbMililitros.Location = new System.Drawing.Point(516, 223);
            this.lbMililitros.Name = "lbMililitros";
            this.lbMililitros.Size = new System.Drawing.Size(37, 13);
            this.lbMililitros.TabIndex = 1;
            this.lbMililitros.Text = "_____";
            // 
            // lstbListaDonantes
            // 
            this.lstbListaDonantes.FormattingEnabled = true;
            this.lstbListaDonantes.Location = new System.Drawing.Point(53, 48);
            this.lstbListaDonantes.Name = "lstbListaDonantes";
            this.lstbListaDonantes.Size = new System.Drawing.Size(250, 251);
            this.lstbListaDonantes.TabIndex = 2;
            this.lstbListaDonantes.SelectedIndexChanged += new System.EventHandler(this.lstbListaDonantes_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargToolStripMenuItem,
            this.nuevaDonaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargToolStripMenuItem
            // 
            this.cargToolStripMenuItem.Name = "cargToolStripMenuItem";
            this.cargToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.cargToolStripMenuItem.Text = "Cargar Lista";
            this.cargToolStripMenuItem.Click += new System.EventHandler(this.cargToolStripMenuItem_Click);
            // 
            // nuevaDonaciónToolStripMenuItem
            // 
            this.nuevaDonaciónToolStripMenuItem.Name = "nuevaDonaciónToolStripMenuItem";
            this.nuevaDonaciónToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.nuevaDonaciónToolStripMenuItem.Text = "Nueva Donación";
            this.nuevaDonaciónToolStripMenuItem.Click += new System.EventHandler(this.nuevaDonaciónToolStripMenuItem_Click);
            // 
            // btnSalirDonaciones
            // 
            this.btnSalirDonaciones.Location = new System.Drawing.Point(552, 270);
            this.btnSalirDonaciones.Name = "btnSalirDonaciones";
            this.btnSalirDonaciones.Size = new System.Drawing.Size(92, 29);
            this.btnSalirDonaciones.TabIndex = 4;
            this.btnSalirDonaciones.Text = "Salir";
            this.btnSalirDonaciones.UseVisualStyleBackColor = true;
            this.btnSalirDonaciones.Click += new System.EventHandler(this.btnSalirDonaciones_Click);
            // 
            // Donaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 367);
            this.Controls.Add(this.btnSalirDonaciones);
            this.Controls.Add(this.lstbListaDonantes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMililitros);
            this.Controls.Add(this.lbTipoDeSangre);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Donaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donaciones";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbTipoDeSangre;
        private System.Windows.Forms.Label lbMililitros;
        private System.Windows.Forms.ListBox lstbListaDonantes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaDonaciónToolStripMenuItem;
        private System.Windows.Forms.Button btnSalirDonaciones;
    }
}