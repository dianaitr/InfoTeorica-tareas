﻿namespace Tarea1_DianaTorres_JoseGalvis
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
            this.txtEstimulos = new System.Windows.Forms.TextBox();
            this.txtRpta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información General del Autómata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo del Autómata : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estados (poner \",\" entre ellos) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valores estímulos (poner\",\" entre ellos) :";
            // 
            // btnDefinirAutomata
            // 
            this.btnDefinirAutomata.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefinirAutomata.Location = new System.Drawing.Point(240, 405);
            this.btnDefinirAutomata.Name = "btnDefinirAutomata";
            this.btnDefinirAutomata.Size = new System.Drawing.Size(169, 58);
            this.btnDefinirAutomata.TabIndex = 4;
            this.btnDefinirAutomata.Text = "Definir Autómata";
            this.btnDefinirAutomata.UseVisualStyleBackColor = true;
            this.btnDefinirAutomata.Click += new System.EventHandler(this.btnDefinirAutomata_Click);
            // 
            // boxTipo
            // 
            this.boxTipo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTipo.FormattingEnabled = true;
            this.boxTipo.Items.AddRange(new object[] {
            "MEALY",
            "MOORE"});
            this.boxTipo.Location = new System.Drawing.Point(398, 116);
            this.boxTipo.Name = "boxTipo";
            this.boxTipo.Size = new System.Drawing.Size(216, 29);
            this.boxTipo.TabIndex = 5;
            // 
            // txtEstados
            // 
            this.txtEstados.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstados.Location = new System.Drawing.Point(398, 180);
            this.txtEstados.Multiline = true;
            this.txtEstados.Name = "txtEstados";
            this.txtEstados.Size = new System.Drawing.Size(216, 51);
            this.txtEstados.TabIndex = 6;
            // 
            // txtEstimulos
            // 
            this.txtEstimulos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstimulos.Location = new System.Drawing.Point(398, 261);
            this.txtEstimulos.Multiline = true;
            this.txtEstimulos.Name = "txtEstimulos";
            this.txtEstimulos.Size = new System.Drawing.Size(216, 51);
            this.txtEstimulos.TabIndex = 7;
            // 
            // txtRpta
            // 
            this.txtRpta.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRpta.Location = new System.Drawing.Point(398, 339);
            this.txtRpta.Multiline = true;
            this.txtRpta.Name = "txtRpta";
            this.txtRpta.Size = new System.Drawing.Size(216, 51);
            this.txtRpta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valores respuestas (poner\",\" entre ellos) :";
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 493);
            this.Controls.Add(this.txtRpta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstimulos);
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
        private System.Windows.Forms.TextBox txtEstimulos;
        private System.Windows.Forms.TextBox txtRpta;
        private System.Windows.Forms.Label label5;
    }
}