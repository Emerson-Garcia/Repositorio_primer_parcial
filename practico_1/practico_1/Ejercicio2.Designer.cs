
namespace practico_1
{
    partial class Ejercicio2
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
            this.components = new System.ComponentModel.Container();
            this.Numero2_textBox = new System.Windows.Forms.TextBox();
            this.Numero1_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Calcular_button = new System.Windows.Forms.Button();
            this.Operaciones_comboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Resultado_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Numero2_textBox
            // 
            this.Numero2_textBox.Location = new System.Drawing.Point(136, 125);
            this.Numero2_textBox.Name = "Numero2_textBox";
            this.Numero2_textBox.Size = new System.Drawing.Size(100, 20);
            this.Numero2_textBox.TabIndex = 9;
            // 
            // Numero1_textBox
            // 
            this.Numero1_textBox.Location = new System.Drawing.Point(136, 79);
            this.Numero1_textBox.Name = "Numero1_textBox";
            this.Numero1_textBox.Size = new System.Drawing.Size(100, 20);
            this.Numero1_textBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "numero 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "numero 1";
            // 
            // Calcular_button
            // 
            this.Calcular_button.Location = new System.Drawing.Point(125, 202);
            this.Calcular_button.Name = "Calcular_button";
            this.Calcular_button.Size = new System.Drawing.Size(75, 71);
            this.Calcular_button.TabIndex = 5;
            this.Calcular_button.Text = "calcular";
            this.Calcular_button.UseVisualStyleBackColor = true;
            this.Calcular_button.Click += new System.EventHandler(this.Calcular_button_Click);
            // 
            // Operaciones_comboBox
            // 
            this.Operaciones_comboBox.FormattingEnabled = true;
            this.Operaciones_comboBox.Items.AddRange(new object[] {
            "Suma",
            "Resta ",
            "Multiplicacion",
            "Division"});
            this.Operaciones_comboBox.Location = new System.Drawing.Point(136, 164);
            this.Operaciones_comboBox.Name = "Operaciones_comboBox";
            this.Operaciones_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Operaciones_comboBox.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 11;
            // 
            // Resultado_label
            // 
            this.Resultado_label.AutoSize = true;
            this.Resultado_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado_label.ForeColor = System.Drawing.Color.Lime;
            this.Resultado_label.Location = new System.Drawing.Point(305, 167);
            this.Resultado_label.Name = "Resultado_label";
            this.Resultado_label.Size = new System.Drawing.Size(75, 19);
            this.Resultado_label.TabIndex = 12;
            this.Resultado_label.Text = "Resultado";
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultado_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Operaciones_comboBox);
            this.Controls.Add(this.Numero2_textBox);
            this.Controls.Add(this.Numero1_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcular_button);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Numero2_textBox;
        private System.Windows.Forms.TextBox Numero1_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calcular_button;
        private System.Windows.Forms.ComboBox Operaciones_comboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Resultado_label;
        private System.Windows.Forms.Label label3;
    }
}