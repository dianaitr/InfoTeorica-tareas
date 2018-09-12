namespace Tarea1_DianaTorres_JoseGalvis
{
    partial class InterfazPrincipal
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
            this.btnDefinirAutomata = new System.Windows.Forms.Button();
            this.boxTipo = new System.Windows.Forms.ComboBox();
            this.txtEstados = new System.Windows.Forms.TextBox();
            this.txtEstimulosRespuestas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información General del Autómata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo del Autómata : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estados (poner \",\" entre ellos) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valores estímulos/respuestas (poner\",\" entre ellos) :";
            // 
            // btnDefinirAutomata
            // 
            this.btnDefinirAutomata.Location = new System.Drawing.Point(241, 404);
            this.btnDefinirAutomata.Name = "btnDefinirAutomata";
            this.btnDefinirAutomata.Size = new System.Drawing.Size(169, 58);
            this.btnDefinirAutomata.TabIndex = 4;
            this.btnDefinirAutomata.Text = "Definir Autómata";
            this.btnDefinirAutomata.UseVisualStyleBackColor = true;
            // 
            // boxTipo
            // 
            this.boxTipo.FormattingEnabled = true;
            this.boxTipo.Items.AddRange(new object[] {
            "MEALY",
            "MOORE"});
            this.boxTipo.Location = new System.Drawing.Point(398, 116);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(183, 24);
            this.boxTipo.TabIndex = 5;
            // 
            // txtEstados
            // 
            this.txtEstados.Location = new System.Drawing.Point(398, 204);
            this.txtEstados.Name = "txtEstados";
            this.txtEstados.Size = new System.Drawing.Size(183, 22);
            this.txtEstados.TabIndex = 6;
            // 
            // txtEstimulosRespuestas
            // 
            this.txtEstimulosRespuestas.Location = new System.Drawing.Point(398, 291);
            this.txtEstimulosRespuestas.Name = "txtEstimulosRespuestas";
            this.txtEstimulosRespuestas.Size = new System.Drawing.Size(183, 22);
            this.txtEstimulosRespuestas.TabIndex = 7;
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 493);
            this.Controls.Add(this.txtEstimulosRespuestas);
            this.Controls.Add(this.txtEstados);
            this.Controls.Add(this.boxTipo);
            this.Controls.Add(this.btnDefinirAutomata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InterfazPrincipal";
            this.Text = "InterfazPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDefinirAutomata;
        private System.Windows.Forms.ComboBox boxTipo;
        private System.Windows.Forms.TextBox txtEstados;
        private System.Windows.Forms.TextBox txtEstimulosRespuestas;
    }
}