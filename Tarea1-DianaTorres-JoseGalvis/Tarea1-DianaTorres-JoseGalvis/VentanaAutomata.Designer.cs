namespace Tarea1_DianaTorres_JoseGalvis
{
    partial class VentanaAutomata
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listaMoore = new System.Windows.Forms.ListView();
            this.columnaSalidasMoore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaEstimulosMoore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaRespuestaMoore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listaMealy = new System.Windows.Forms.ListView();
            this.columnaSalidaMealy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaEstimulosMealy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listaMealy);
            this.panel1.Controls.Add(this.listaMoore);
            this.panel1.Location = new System.Drawing.Point(51, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 454);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(562, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 454);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Autómata de Moore";
            // 
            // listaMoore
            // 
            this.listaMoore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaSalidasMoore,
            this.columnaEstimulosMoore,
            this.columnaRespuestaMoore});
            this.listaMoore.Location = new System.Drawing.Point(16, 13);
            this.listaMoore.Name = "listaMoore";
            this.listaMoore.Size = new System.Drawing.Size(399, 260);
            this.listaMoore.TabIndex = 0;
            this.listaMoore.UseCompatibleStateImageBehavior = false;
            this.listaMoore.View = System.Windows.Forms.View.Details;
            // 
            // columnaSalidasMoore
            // 
            this.columnaSalidasMoore.Text = "Salidas";
            this.columnaSalidasMoore.Width = 100;
            // 
            // columnaEstimulosMoore
            // 
            this.columnaEstimulosMoore.Text = "Estimulos";
            this.columnaEstimulosMoore.Width = 200;
            // 
            // columnaRespuestaMoore
            // 
            this.columnaRespuestaMoore.Text = "Respuesta";
            this.columnaRespuestaMoore.Width = 100;
            // 
            // listaMealy
            // 
            this.listaMealy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaSalidaMealy,
            this.columnaEstimulosMealy});
            this.listaMealy.Location = new System.Drawing.Point(16, 55);
            this.listaMealy.Name = "listaMealy";
            this.listaMealy.Size = new System.Drawing.Size(399, 260);
            this.listaMealy.TabIndex = 2;
            this.listaMealy.UseCompatibleStateImageBehavior = false;
            this.listaMealy.View = System.Windows.Forms.View.Details;
            // 
            // columnaSalidaMealy
            // 
            this.columnaSalidaMealy.Text = "Salidas";
            this.columnaSalidaMealy.Width = 100;
            // 
            // columnaEstimulosMealy
            // 
            this.columnaEstimulosMealy.Text = "Estimulos";
            this.columnaEstimulosMealy.Width = 200;
            // 
            // VentanaAutomata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VentanaAutomata";
            this.Text = "VentanaAutomata";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listaMealy;
        private System.Windows.Forms.ColumnHeader columnaSalidaMealy;
        private System.Windows.Forms.ColumnHeader columnaEstimulosMealy;
        private System.Windows.Forms.ListView listaMoore;
        private System.Windows.Forms.ColumnHeader columnaSalidasMoore;
        private System.Windows.Forms.ColumnHeader columnaEstimulosMoore;
        private System.Windows.Forms.ColumnHeader columnaRespuestaMoore;
        private System.Windows.Forms.Label label1;
    }
}