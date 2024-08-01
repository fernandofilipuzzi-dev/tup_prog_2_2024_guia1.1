
namespace Ejercicio2
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnIngresadaParada = new System.Windows.Forms.Button();
            this.gbFinalizar = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMLLegada = new System.Windows.Forms.TextBox();
            this.tbHLLegada = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.gbFinalizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(18, 18);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(417, 35);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar Viaje";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnIngresadaParada
            // 
            this.btnIngresadaParada.Location = new System.Drawing.Point(18, 66);
            this.btnIngresadaParada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresadaParada.Name = "btnIngresadaParada";
            this.btnIngresadaParada.Size = new System.Drawing.Size(417, 35);
            this.btnIngresadaParada.TabIndex = 5;
            this.btnIngresadaParada.Text = "Ingresada Parada";
            this.btnIngresadaParada.UseVisualStyleBackColor = true;
            this.btnIngresadaParada.Click += new System.EventHandler(this.btnIngresadaParada_Click);
            // 
            // gbFinalizar
            // 
            this.gbFinalizar.Controls.Add(this.label11);
            this.gbFinalizar.Controls.Add(this.tbMLLegada);
            this.gbFinalizar.Controls.Add(this.tbHLLegada);
            this.gbFinalizar.Controls.Add(this.btnFinalizar);
            this.gbFinalizar.Controls.Add(this.label8);
            this.gbFinalizar.Enabled = false;
            this.gbFinalizar.Location = new System.Drawing.Point(18, 111);
            this.gbFinalizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFinalizar.Name = "gbFinalizar";
            this.gbFinalizar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFinalizar.Size = new System.Drawing.Size(417, 117);
            this.gbFinalizar.TabIndex = 1;
            this.gbFinalizar.TabStop = false;
            this.gbFinalizar.Text = "Finalizar Parada";
            this.gbFinalizar.UseCompatibleTextRendering = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = ":";
            // 
            // tbMLLegada
            // 
            this.tbMLLegada.Location = new System.Drawing.Point(330, 29);
            this.tbMLLegada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMLLegada.Name = "tbMLLegada";
            this.tbMLLegada.Size = new System.Drawing.Size(54, 26);
            this.tbMLLegada.TabIndex = 11;
            this.tbMLLegada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // tbHLLegada
            // 
            this.tbHLLegada.Location = new System.Drawing.Point(242, 29);
            this.tbHLLegada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHLLegada.Name = "tbHLLegada";
            this.tbHLLegada.Size = new System.Drawing.Size(54, 26);
            this.tbHLLegada.TabIndex = 12;
            this.tbHLLegada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPositivo_KeyPress);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(198, 69);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(210, 35);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Finalizar Viaje";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Hora de Finalización (HH:MM)";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 242);
            this.Controls.Add(this.gbFinalizar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnIngresadaParada);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Empresa de viajes";
            this.gbFinalizar.ResumeLayout(false);
            this.gbFinalizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnIngresadaParada;
        private System.Windows.Forms.GroupBox gbFinalizar;
        private System.Windows.Forms.TextBox tbMLLegada;
        private System.Windows.Forms.TextBox tbHLLegada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label11;
    }
}

