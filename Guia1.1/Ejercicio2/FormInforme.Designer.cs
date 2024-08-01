
namespace Ejercicio2
{
    partial class FormInforme
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
            this.gbFinalizar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ltbResultados = new System.Windows.Forms.ListBox();
            this.gbFinalizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFinalizar
            // 
            this.gbFinalizar.Controls.Add(this.button1);
            this.gbFinalizar.Controls.Add(this.ltbResultados);
            this.gbFinalizar.Location = new System.Drawing.Point(18, 18);
            this.gbFinalizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFinalizar.Name = "gbFinalizar";
            this.gbFinalizar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFinalizar.Size = new System.Drawing.Size(417, 368);
            this.gbFinalizar.TabIndex = 2;
            this.gbFinalizar.TabStop = false;
            this.gbFinalizar.Text = "Informe del viaje";
            this.gbFinalizar.UseCompatibleTextRendering = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(147, 320);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ltbResultados
            // 
            this.ltbResultados.FormattingEnabled = true;
            this.ltbResultados.ItemHeight = 20;
            this.ltbResultados.Location = new System.Drawing.Point(9, 25);
            this.ltbResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltbResultados.Name = "ltbResultados";
            this.ltbResultados.Size = new System.Drawing.Size(397, 284);
            this.ltbResultados.TabIndex = 7;
            // 
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 394);
            this.Controls.Add(this.gbFinalizar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormInforme";
            this.Text = "Informe";
            this.gbFinalizar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFinalizar;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox ltbResultados;
    }
}