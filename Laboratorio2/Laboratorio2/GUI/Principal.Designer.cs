namespace Laboratorio2
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDeSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDePersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDeSistemaToolStripMenuItem
            // 
            this.menuDeSistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDePersonaToolStripMenuItem});
            this.menuDeSistemaToolStripMenuItem.Name = "menuDeSistemaToolStripMenuItem";
            this.menuDeSistemaToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.menuDeSistemaToolStripMenuItem.Text = "Menu de sistema";
            // 
            // mantenimientoDePersonaToolStripMenuItem
            // 
            this.mantenimientoDePersonaToolStripMenuItem.Name = "mantenimientoDePersonaToolStripMenuItem";
            this.mantenimientoDePersonaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.mantenimientoDePersonaToolStripMenuItem.Text = "Mantenimiento de persona";
            this.mantenimientoDePersonaToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDePersonaToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 546);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDeSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDePersonaToolStripMenuItem;
    }
}

