namespace Ejercicio1
{
    partial class FormPrincipal
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
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.nupModelo = new System.Windows.Forms.NumericUpDown();
            this.tbValorFabrica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nupAñoCalcular = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAñoCalcular)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.Location = new System.Drawing.Point(30, 181);
            this.btnCalcularCosto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(132, 52);
            this.btnCalcularCosto.TabIndex = 0;
            this.btnCalcularCosto.Text = "Calcular Costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = true;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(182, 181);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(133, 52);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // nupModelo
            // 
            this.nupModelo.Location = new System.Drawing.Point(182, 58);
            this.nupModelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupModelo.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nupModelo.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nupModelo.Name = "nupModelo";
            this.nupModelo.Size = new System.Drawing.Size(80, 26);
            this.nupModelo.TabIndex = 2;
            this.nupModelo.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // tbValorFabrica
            // 
            this.tbValorFabrica.Location = new System.Drawing.Point(182, 130);
            this.tbValorFabrica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbValorFabrica.Name = "tbValorFabrica";
            this.tbValorFabrica.Size = new System.Drawing.Size(146, 26);
            this.tbValorFabrica.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modelo (Año)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor de fabricación $";
            // 
            // nupAñoCalcular
            // 
            this.nupAñoCalcular.Location = new System.Drawing.Point(182, 94);
            this.nupAñoCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupAñoCalcular.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nupAñoCalcular.Minimum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.nupAñoCalcular.Name = "nupAñoCalcular";
            this.nupAñoCalcular.Size = new System.Drawing.Size(80, 26);
            this.nupAñoCalcular.TabIndex = 6;
            this.nupAñoCalcular.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Año a calcular";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(182, 22);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(146, 26);
            this.tbMarca.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Marca";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 26);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tasa de depreciación:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(572, 58);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 26);
            this.textBox2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vida Útil(años):";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 237);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nupAñoCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValorFabrica);
            this.Controls.Add(this.nupModelo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcularCosto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Tasación de motos";
            ((System.ComponentModel.ISupportInitialize)(this.nupModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAñoCalcular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularCosto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.NumericUpDown nupModelo;
        private System.Windows.Forms.TextBox tbValorFabrica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupAñoCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}

