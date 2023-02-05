
namespace practico_1
{
    partial class Form1
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
            this.Calcular_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero1_textBox = new System.Windows.Forms.TextBox();
            this.Numero2_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calcular_button
            // 
            this.Calcular_button.Location = new System.Drawing.Point(129, 189);
            this.Calcular_button.Name = "Calcular_button";
            this.Calcular_button.Size = new System.Drawing.Size(75, 71);
            this.Calcular_button.TabIndex = 0;
            this.Calcular_button.Text = "calcular";
            this.Calcular_button.UseVisualStyleBackColor = true;
            this.Calcular_button.Click += new System.EventHandler(this.Calcular_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "numero 1";
            // 
            // Numero1_textBox
            // 
            this.Numero1_textBox.Location = new System.Drawing.Point(161, 86);
            this.Numero1_textBox.Name = "Numero1_textBox";
            this.Numero1_textBox.Size = new System.Drawing.Size(100, 20);
            this.Numero1_textBox.TabIndex = 3;
            // 
            // Numero2_textBox
            // 
            this.Numero2_textBox.Location = new System.Drawing.Point(161, 132);
            this.Numero2_textBox.Name = "Numero2_textBox";
            this.Numero2_textBox.Size = new System.Drawing.Size(100, 20);
            this.Numero2_textBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numero2_textBox);
            this.Controls.Add(this.Numero1_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcular_button);
            this.Name = "Form1";
            this.Text = "Ejercicio1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero1_textBox;
        private System.Windows.Forms.TextBox Numero2_textBox;
    }
}

