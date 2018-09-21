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
            this.tabla = new System.Windows.Forms.DataGridView();
            this.Salidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTipoAutomata = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarTransicion = new System.Windows.Forms.Button();
            this.comboRespuesta = new System.Windows.Forms.ComboBox();
            this.comboEstimulo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboLlegada = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSalida = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAutomataConexo = new System.Windows.Forms.Button();
            this.btnCompletarAutomata = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabla);
            this.panel1.Controls.Add(this.lblTipoAutomata);
            this.panel1.Location = new System.Drawing.Point(5, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 386);
            this.panel1.TabIndex = 0;
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Salidas});
            this.tabla.Location = new System.Drawing.Point(17, 23);
            this.tabla.Name = "tabla";
            this.tabla.RowTemplate.Height = 24;
            this.tabla.Size = new System.Drawing.Size(539, 335);
            this.tabla.TabIndex = 3;
            // 
            // Salidas
            // 
            this.Salidas.Frozen = true;
            this.Salidas.HeaderText = "Salidas";
            this.Salidas.Name = "Salidas";
            // 
            // lblTipoAutomata
            // 
            this.lblTipoAutomata.AutoSize = true;
            this.lblTipoAutomata.Location = new System.Drawing.Point(2, 0);
            this.lblTipoAutomata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoAutomata.Name = "lblTipoAutomata";
            this.lblTipoAutomata.Size = new System.Drawing.Size(115, 14);
            this.lblTipoAutomata.TabIndex = 2;
            this.lblTipoAutomata.Text = "Autómata de Moore";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregarTransicion);
            this.panel2.Controls.Add(this.comboRespuesta);
            this.panel2.Controls.Add(this.comboEstimulo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboLlegada);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboSalida);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 97);
            this.panel2.TabIndex = 1;
            // 
            // btnAgregarTransicion
            // 
            this.btnAgregarTransicion.Location = new System.Drawing.Point(362, 38);
            this.btnAgregarTransicion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTransicion.Name = "btnAgregarTransicion";
            this.btnAgregarTransicion.Size = new System.Drawing.Size(165, 36);
            this.btnAgregarTransicion.TabIndex = 13;
            this.btnAgregarTransicion.Text = "agregar";
            this.btnAgregarTransicion.UseVisualStyleBackColor = true;
            this.btnAgregarTransicion.Click += new System.EventHandler(this.btnAgregarTransicion_Click);
            // 
            // comboRespuesta
            // 
            this.comboRespuesta.FormattingEnabled = true;
            this.comboRespuesta.Location = new System.Drawing.Point(270, 48);
            this.comboRespuesta.Name = "comboRespuesta";
            this.comboRespuesta.Size = new System.Drawing.Size(72, 22);
            this.comboRespuesta.TabIndex = 12;
            // 
            // comboEstimulo
            // 
            this.comboEstimulo.FormattingEnabled = true;
            this.comboEstimulo.Location = new System.Drawing.Point(192, 48);
            this.comboEstimulo.Name = "comboEstimulo";
            this.comboEstimulo.Size = new System.Drawing.Size(72, 22);
            this.comboEstimulo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Transición :";
            // 
            // comboLlegada
            // 
            this.comboLlegada.FormattingEnabled = true;
            this.comboLlegada.Location = new System.Drawing.Point(111, 48);
            this.comboLlegada.Name = "comboLlegada";
            this.comboLlegada.Size = new System.Drawing.Size(72, 22);
            this.comboLlegada.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estímulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salida";
            // 
            // comboSalida
            // 
            this.comboSalida.FormattingEnabled = true;
            this.comboSalida.Location = new System.Drawing.Point(33, 48);
            this.comboSalida.Name = "comboSalida";
            this.comboSalida.Size = new System.Drawing.Size(72, 22);
            this.comboSalida.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Llegada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Respuesta";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 550);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 26);
            this.button3.TabIndex = 2;
            this.button3.Text = "return";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAutomataConexo
            // 
            this.btnAutomataConexo.Location = new System.Drawing.Point(415, 490);
            this.btnAutomataConexo.Name = "btnAutomataConexo";
            this.btnAutomataConexo.Size = new System.Drawing.Size(171, 54);
            this.btnAutomataConexo.TabIndex = 3;
            this.btnAutomataConexo.Text = "Automata Conexo Equivalente";
            this.btnAutomataConexo.UseVisualStyleBackColor = true;
            this.btnAutomataConexo.Visible = false;
            this.btnAutomataConexo.Click += new System.EventHandler(this.btnAutomataConexo_Click);
            // 
            // btnCompletarAutomata
            // 
            this.btnCompletarAutomata.Location = new System.Drawing.Point(168, 490);
            this.btnCompletarAutomata.Name = "btnCompletarAutomata";
            this.btnCompletarAutomata.Size = new System.Drawing.Size(112, 54);
            this.btnCompletarAutomata.TabIndex = 4;
            this.btnCompletarAutomata.Text = "Completar automata";
            this.btnCompletarAutomata.UseVisualStyleBackColor = true;
            this.btnCompletarAutomata.Click += new System.EventHandler(this.btnCompletarAutomata_Click);
            // 
            // VentanaAutomata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 580);
            this.Controls.Add(this.btnCompletarAutomata);
            this.Controls.Add(this.btnAutomataConexo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaAutomata";
            this.Text = "VentanaAutomata";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTipoAutomata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.ComboBox comboRespuesta;
        private System.Windows.Forms.ComboBox comboEstimulo;
        private System.Windows.Forms.ComboBox comboLlegada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSalida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarTransicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salidas;
        private System.Windows.Forms.Button btnAutomataConexo;
        private System.Windows.Forms.Button btnCompletarAutomata;
    }
}