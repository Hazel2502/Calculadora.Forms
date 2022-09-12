
namespace Calculadora.Forms
{
    partial class Calculadora
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
            this.lbl = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.comboOperaciones = new System.Windows.Forms.ComboBox();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(141, 40);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(70, 17);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Numero 1";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(602, 40);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(70, 17);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero 2";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(105, 77);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(127, 22);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(571, 77);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(127, 22);
            this.txtNum2.TabIndex = 3;
            // 
            // comboOperaciones
            // 
            this.comboOperaciones.FormattingEnabled = true;
            this.comboOperaciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "División"});
            this.comboOperaciones.Location = new System.Drawing.Point(93, 240);
            this.comboOperaciones.Name = "comboOperaciones";
            this.comboOperaciones.Size = new System.Drawing.Size(163, 24);
            this.comboOperaciones.TabIndex = 4;
            this.comboOperaciones.SelectedIndexChanged += new System.EventHandler(this.comboOperaciones_SelectedIndexChanged);
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Location = new System.Drawing.Point(122, 203);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(89, 17);
            this.lblOperaciones.TabIndex = 5;
            this.lblOperaciones.Text = "Operaciones";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(597, 240);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.comboOperaciones);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lbl);
            this.Name = "Calculadora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ComboBox comboOperaciones;
        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.Button btnCalcular;
    }
}

