﻿namespace MiPrimerForm
{
    partial class Form1
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transparenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu100 = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu95 = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu90 = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu85 = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu80 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRojo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuVerde = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.originalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.formulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transparenciaToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.formulariosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // transparenciaToolStripMenuItem
            // 
            this.transparenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu100,
            this.Mnu95,
            this.Mnu90,
            this.Mnu85,
            this.Mnu80});
            this.transparenciaToolStripMenuItem.Name = "transparenciaToolStripMenuItem";
            this.transparenciaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.transparenciaToolStripMenuItem.Text = "Transparencia";
            // 
            // Mnu100
            // 
            this.Mnu100.Name = "Mnu100";
            this.Mnu100.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.Mnu100.Size = new System.Drawing.Size(270, 34);
            this.Mnu100.Text = "100%";
            this.Mnu100.Click += new System.EventHandler(this.Mnu100_Click);
            // 
            // Mnu95
            // 
            this.Mnu95.Name = "Mnu95";
            this.Mnu95.Size = new System.Drawing.Size(270, 34);
            this.Mnu95.Text = "95%";
            this.Mnu95.Click += new System.EventHandler(this.Mnu95_Click);
            // 
            // Mnu90
            // 
            this.Mnu90.Name = "Mnu90";
            this.Mnu90.Size = new System.Drawing.Size(270, 34);
            this.Mnu90.Text = "90%";
            this.Mnu90.Click += new System.EventHandler(this.Mnu90_Click);
            // 
            // Mnu85
            // 
            this.Mnu85.Name = "Mnu85";
            this.Mnu85.Size = new System.Drawing.Size(270, 34);
            this.Mnu85.Text = "85%";
            this.Mnu85.Click += new System.EventHandler(this.Mnu85_Click);
            // 
            // Mnu80
            // 
            this.Mnu80.Name = "Mnu80";
            this.Mnu80.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F8)));
            this.Mnu80.Size = new System.Drawing.Size(270, 34);
            this.Mnu80.Text = "80%";
            this.Mnu80.Click += new System.EventHandler(this.Mnu80_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuRojo,
            this.MnuVerde,
            this.MnuAzul,
            this.toolStripSeparator1,
            this.originalToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.colorToolStripMenuItem.Text = "Fondo";
            // 
            // MnuRojo
            // 
            this.MnuRojo.Name = "MnuRojo";
            this.MnuRojo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.MnuRojo.Size = new System.Drawing.Size(270, 34);
            this.MnuRojo.Text = "Rojo";
            this.MnuRojo.Click += new System.EventHandler(this.MnuRojo_Click);
            // 
            // MnuVerde
            // 
            this.MnuVerde.Name = "MnuVerde";
            this.MnuVerde.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MnuVerde.Size = new System.Drawing.Size(270, 34);
            this.MnuVerde.Text = "Verde";
            this.MnuVerde.Click += new System.EventHandler(this.MnuVerde_Click);
            // 
            // MnuAzul
            // 
            this.MnuAzul.Name = "MnuAzul";
            this.MnuAzul.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MnuAzul.Size = new System.Drawing.Size(270, 34);
            this.MnuAzul.Text = "Azul";
            this.MnuAzul.Click += new System.EventHandler(this.MnuAzul_Click);
            // 
            // originalToolStripMenuItem
            // 
            this.originalToolStripMenuItem.Name = "originalToolStripMenuItem";
            this.originalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.originalToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.originalToolStripMenuItem.Text = "Original";
            this.originalToolStripMenuItem.Click += new System.EventHandler(this.originalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAbout});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(336, 34);
            this.MnuAbout.Text = "Sobre Mi Primera GUI en C#";
            this.MnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
            // 
            // formulariosToolStripMenuItem
            // 
            this.formulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.formulariosToolStripMenuItem.Text = "Formularios";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Mi primera GUI en C#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transparenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mnu100;
        private System.Windows.Forms.ToolStripMenuItem Mnu95;
        private System.Windows.Forms.ToolStripMenuItem Mnu90;
        private System.Windows.Forms.ToolStripMenuItem Mnu85;
        private System.Windows.Forms.ToolStripMenuItem Mnu80;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuRojo;
        private System.Windows.Forms.ToolStripMenuItem MnuVerde;
        private System.Windows.Forms.ToolStripMenuItem MnuAzul;
        private System.Windows.Forms.ToolStripMenuItem originalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
    }
}
