namespace MiPrimerForm.Formularios
{
    partial class FrmProducto
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
            this.tabGenrl = new System.Windows.Forms.TabControl();
            this.tabGrid = new System.Windows.Forms.TabPage();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIva = new System.Windows.Forms.CheckBox();
            this.tabGenrl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGenrl
            // 
            this.tabGenrl.Controls.Add(this.tabGeneral);
            this.tabGenrl.Controls.Add(this.tabGrid);
            this.tabGenrl.Controls.Add(this.tabPage3);
            this.tabGenrl.Location = new System.Drawing.Point(24, 34);
            this.tabGenrl.Name = "tabGenrl";
            this.tabGenrl.SelectedIndex = 0;
            this.tabGenrl.Size = new System.Drawing.Size(736, 379);
            this.tabGenrl.TabIndex = 0;
            this.tabGenrl.SelectedIndexChanged += new System.EventHandler(this.tabGrid_SelectedIndexChanged);
            // 
            // tabGrid
            // 
            this.tabGrid.Location = new System.Drawing.Point(4, 29);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrid.Size = new System.Drawing.Size(728, 346);
            this.tabGrid.TabIndex = 1;
            this.tabGrid.Text = "Registros Guardados";
            this.tabGrid.UseVisualStyleBackColor = true;
            this.tabGrid.Click += new System.EventHandler(this.tabGeneral_Click);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.cbIva);
            this.tabGeneral.Controls.Add(this.label3);
            this.tabGeneral.Controls.Add(this.tbPrice);
            this.tabGeneral.Controls.Add(this.tbName);
            this.tabGeneral.Controls.Add(this.tbCod);
            this.tabGeneral.Controls.Add(this.label2);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Location = new System.Drawing.Point(4, 29);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(728, 346);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Datos del producto";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(728, 346);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(120, 17);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(168, 26);
            this.tbCod.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(120, 62);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(168, 26);
            this.tbName.TabIndex = 3;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(120, 128);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(168, 26);
            this.tbPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio:";
            // 
            // cbIva
            // 
            this.cbIva.AutoSize = true;
            this.cbIva.Location = new System.Drawing.Point(109, 201);
            this.cbIva.Name = "cbIva";
            this.cbIva.Size = new System.Drawing.Size(109, 24);
            this.cbIva.TabIndex = 6;
            this.cbIva.Text = "Aplica IVA";
            this.cbIva.UseVisualStyleBackColor = true;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabGenrl);
            this.Name = "FrmProducto";
            this.Text = "Producto";
            this.tabGenrl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGenrl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabGrid;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox cbIva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}