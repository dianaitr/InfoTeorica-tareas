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
            this.btn_automataMinimo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tablaParticionamiento = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.particionamientoFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaParticionamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabla);
            this.panel1.Controls.Add(this.lblTipoAutomata);
            this.panel1.Location = new System.Drawing.Point(5, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 335);
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
            this.tabla.Size = new System.Drawing.Size(467, 282);
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
            this.lblTipoAutomata.Size = new System.Drawing.Size(132, 18);
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
            this.panel2.Size = new System.Drawing.Size(527, 97);
            this.panel2.TabIndex = 1;
            // 
            // btnAgregarTransicion
            // 
            this.btnAgregarTransicion.Location = new System.Drawing.Point(362, 38);
            this.btnAgregarTransicion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTransicion.Name = "btnAgregarTransicion";
            this.btnAgregarTransicion.Size = new System.Drawing.Size(149, 36);
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
            this.comboRespuesta.Size = new System.Drawing.Size(72, 26);
            this.comboRespuesta.TabIndex = 12;
            // 
            // comboEstimulo
            // 
            this.comboEstimulo.FormattingEnabled = true;
            this.comboEstimulo.Location = new System.Drawing.Point(192, 48);
            this.comboEstimulo.Name = "comboEstimulo";
            this.comboEstimulo.Size = new System.Drawing.Size(72, 26);
            this.comboEstimulo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Transición :";
            // 
            // comboLlegada
            // 
            this.comboLlegada.FormattingEnabled = true;
            this.comboLlegada.Location = new System.Drawing.Point(111, 48);
            this.comboLlegada.Name = "comboLlegada";
            this.comboLlegada.Size = new System.Drawing.Size(72, 26);
            this.comboLlegada.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estímulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Salida";
            // 
            // comboSalida
            // 
            this.comboSalida.FormattingEnabled = true;
            this.comboSalida.Location = new System.Drawing.Point(33, 48);
            this.comboSalida.Name = "comboSalida";
            this.comboSalida.Size = new System.Drawing.Size(72, 26);
            this.comboSalida.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Llegada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Respuesta";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-4, 521);
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
            this.btnAutomataConexo.Location = new System.Drawing.Point(140, 449);
            this.btnAutomataConexo.Name = "btnAutomataConexo";
            this.btnAutomataConexo.Size = new System.Drawing.Size(125, 54);
            this.btnAutomataConexo.TabIndex = 3;
            this.btnAutomataConexo.Text = "Automata Conexo Equivalente";
            this.btnAutomataConexo.UseVisualStyleBackColor = true;
            this.btnAutomataConexo.Visible = false;
            this.btnAutomataConexo.Click += new System.EventHandler(this.btnAutomataConexo_Click);
            // 
            // btnCompletarAutomata
            // 
            this.btnCompletarAutomata.Location = new System.Drawing.Point(22, 449);
            this.btnCompletarAutomata.Name = "btnCompletarAutomata";
            this.btnCompletarAutomata.Size = new System.Drawing.Size(112, 54);
            this.btnCompletarAutomata.TabIndex = 4;
            this.btnCompletarAutomata.Text = "Completar automata";
            this.btnCompletarAutomata.UseVisualStyleBackColor = true;
            this.btnCompletarAutomata.Click += new System.EventHandler(this.btnCompletarAutomata_Click);
            // 
            // btn_automataMinimo
            // 
            this.btn_automataMinimo.Location = new System.Drawing.Point(540, 449);
            this.btn_automataMinimo.Name = "btn_automataMinimo";
            this.btn_automataMinimo.Size = new System.Drawing.Size(123, 54);
            this.btn_automataMinimo.TabIndex = 5;
            this.btn_automataMinimo.Text = "Automata minimo equivalente";
            this.btn_automataMinimo.UseVisualStyleBackColor = true;
            this.btn_automataMinimo.Click += new System.EventHandler(this.btn_automataMinimo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tablaParticionamiento);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(535, 107);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 335);
            this.panel3.TabIndex = 6;
            // 
            // tablaParticionamiento
            // 
            this.tablaParticionamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaParticionamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.tablaParticionamiento.Location = new System.Drawing.Point(17, 23);
            this.tablaParticionamiento.Name = "tablaParticionamiento";
            this.tablaParticionamiento.RowTemplate.Height = 24;
            this.tablaParticionamiento.Size = new System.Drawing.Size(467, 282);
            this.tablaParticionamiento.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Salidas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autómata de Moore";
            // 
            // particionamientoFinal
            // 
            this.particionamientoFinal.Location = new System.Drawing.Point(612, 12);
            this.particionamientoFinal.Multiline = true;
            this.particionamientoFinal.Name = "particionamientoFinal";
            this.particionamientoFinal.Size = new System.Drawing.Size(426, 58);
            this.particionamientoFinal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "PFinal : ";
            // 
            // VentanaAutomata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.particionamientoFinal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_automataMinimo);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaParticionamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btn_automataMinimo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tablaParticionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox particionamientoFinal;
        private System.Windows.Forms.Label label4;
    }
}