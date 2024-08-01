
namespace Ejercicio2
{
    partial class FormInicio
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
            this.gbInicio = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tbAsientos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMInicio = new System.Windows.Forms.TextBox();
            this.tbHInicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInicio
            // 
            this.gbInicio.Controls.Add(this.btnCancelar);
            this.gbInicio.Controls.Add(this.label5);
            this.gbInicio.Controls.Add(this.btnAceptar);
            this.gbInicio.Controls.Add(this.tbAsientos);
            this.gbInicio.Controls.Add(this.label2);
            this.gbInicio.Controls.Add(this.tbMInicio);
            this.gbInicio.Controls.Add(this.tbHInicio);
            this.gbInicio.Controls.Add(this.label1);
            this.gbInicio.Location = new System.Drawing.Point(18, 18);
            this.gbInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInicio.Size = new System.Drawing.Size(368, 169);
            this.gbInicio.TabIndex = 1;
            this.gbInicio.TabStop = false;
            this.gbInicio.Text = "Inicio Recorrido";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(214, 121);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Iniciar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = ":";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(37, 121);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 35);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Iniciar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // tbAsientos
            // 
            this.tbAsientos.Location = new System.Drawing.Point(214, 69);
            this.tbAsientos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAsientos.Name = "tbAsientos";
            this.tbAsientos.Size = new System.Drawing.Size(54, 26);
            this.tbAsientos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Asientos";
            // 
            // tbMInicio
            // 
            this.tbMInicio.Location = new System.Drawing.Point(303, 29);
            this.tbMInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMInicio.Name = "tbMInicio";
            this.tbMInicio.Size = new System.Drawing.Size(54, 26);
            this.tbMInicio.TabIndex = 1;
            // 
            // tbHInicio
            // 
            this.tbHInicio.Location = new System.Drawing.Point(214, 29);
            this.tbHInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHInicio.Name = "tbHInicio";
            this.tbHInicio.Size = new System.Drawing.Size(54, 26);
            this.tbHInicio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora de Partida (HH:MM)";
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 192);
            this.Controls.Add(this.gbInicio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormInicio";
            this.Text = "Inicio del viaje";
            this.gbInicio.ResumeLayout(false);
            this.gbInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbAsientos;
        public System.Windows.Forms.TextBox tbMInicio;
        public System.Windows.Forms.TextBox tbHInicio;
        private System.Windows.Forms.Button btnCancelar;
    }
}