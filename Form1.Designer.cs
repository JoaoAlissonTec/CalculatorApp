namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_calculo = new System.Windows.Forms.TextBox();
            this.ponto = new System.Windows.Forms.Button();
            this.apaga = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.soma = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_calculo
            // 
            this.txt_calculo.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txt_calculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_calculo.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_calculo.ForeColor = System.Drawing.Color.Snow;
            this.txt_calculo.Location = new System.Drawing.Point(23, 35);
            this.txt_calculo.Name = "txt_calculo";
            this.txt_calculo.Size = new System.Drawing.Size(318, 38);
            this.txt_calculo.TabIndex = 1;
            this.txt_calculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ponto
            // 
            this.ponto.BackColor = System.Drawing.Color.Aquamarine;
            this.ponto.FlatAppearance.BorderSize = 0;
            this.ponto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ponto.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ponto.Location = new System.Drawing.Point(185, 344);
            this.ponto.Name = "ponto";
            this.ponto.Size = new System.Drawing.Size(75, 57);
            this.ponto.TabIndex = 35;
            this.ponto.Text = ".";
            this.ponto.UseVisualStyleBackColor = false;
            this.ponto.Click += new System.EventHandler(this.ponto_Click);
            // 
            // apaga
            // 
            this.apaga.BackColor = System.Drawing.Color.Teal;
            this.apaga.FlatAppearance.BorderSize = 0;
            this.apaga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apaga.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apaga.ForeColor = System.Drawing.Color.Black;
            this.apaga.Image = global::Calculadora.Properties.Resources.excluir__1_;
            this.apaga.Location = new System.Drawing.Point(266, 218);
            this.apaga.Name = "apaga";
            this.apaga.Size = new System.Drawing.Size(75, 57);
            this.apaga.TabIndex = 34;
            this.apaga.UseVisualStyleBackColor = false;
            this.apaga.Click += new System.EventHandler(this.apaga_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.Aquamarine;
            this.num0.FlatAppearance.BorderSize = 0;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num0.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num0.Location = new System.Drawing.Point(23, 344);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(156, 57);
            this.num0.TabIndex = 32;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Teal;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(266, 155);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 57);
            this.cancel.TabIndex = 33;
            this.cancel.Text = "CE";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.Teal;
            this.div.FlatAppearance.BorderSize = 0;
            this.div.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.div.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.div.ForeColor = System.Drawing.Color.Black;
            this.div.Location = new System.Drawing.Point(266, 92);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 57);
            this.div.TabIndex = 31;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.Color.Teal;
            this.mult.FlatAppearance.BorderSize = 0;
            this.mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mult.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mult.ForeColor = System.Drawing.Color.Black;
            this.mult.Location = new System.Drawing.Point(185, 92);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 57);
            this.mult.TabIndex = 30;
            this.mult.Text = "x";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.Color.Teal;
            this.sub.FlatAppearance.BorderSize = 0;
            this.sub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sub.ForeColor = System.Drawing.Color.Black;
            this.sub.Location = new System.Drawing.Point(104, 92);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 57);
            this.sub.TabIndex = 29;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // soma
            // 
            this.soma.BackColor = System.Drawing.Color.Teal;
            this.soma.FlatAppearance.BorderSize = 0;
            this.soma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soma.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soma.ForeColor = System.Drawing.Color.Black;
            this.soma.Location = new System.Drawing.Point(23, 92);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(75, 57);
            this.soma.TabIndex = 28;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = false;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.LightSeaGreen;
            this.igual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.igual.FlatAppearance.BorderSize = 0;
            this.igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.igual.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.igual.ForeColor = System.Drawing.Color.Black;
            this.igual.Location = new System.Drawing.Point(266, 281);
            this.igual.Margin = new System.Windows.Forms.Padding(0);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(75, 120);
            this.igual.TabIndex = 27;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.Aquamarine;
            this.num9.FlatAppearance.BorderSize = 0;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num9.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num9.Location = new System.Drawing.Point(185, 281);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 57);
            this.num9.TabIndex = 26;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.Aquamarine;
            this.num8.FlatAppearance.BorderSize = 0;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num8.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num8.Location = new System.Drawing.Point(104, 281);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(75, 57);
            this.num8.TabIndex = 25;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.Aquamarine;
            this.num7.FlatAppearance.BorderSize = 0;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num7.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num7.Location = new System.Drawing.Point(23, 281);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(75, 57);
            this.num7.TabIndex = 24;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.Aquamarine;
            this.num6.FlatAppearance.BorderSize = 0;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num6.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num6.Location = new System.Drawing.Point(185, 218);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 57);
            this.num6.TabIndex = 23;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.Aquamarine;
            this.num5.FlatAppearance.BorderSize = 0;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num5.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num5.Location = new System.Drawing.Point(104, 218);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(75, 57);
            this.num5.TabIndex = 22;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.Aquamarine;
            this.num4.FlatAppearance.BorderSize = 0;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num4.Location = new System.Drawing.Point(23, 218);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(75, 57);
            this.num4.TabIndex = 21;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.Aquamarine;
            this.num3.FlatAppearance.BorderSize = 0;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num3.Location = new System.Drawing.Point(185, 155);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 57);
            this.num3.TabIndex = 20;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.Aquamarine;
            this.num2.FlatAppearance.BorderSize = 0;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num2.Location = new System.Drawing.Point(104, 155);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 57);
            this.num2.TabIndex = 19;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.Aquamarine;
            this.num1.FlatAppearance.BorderSize = 0;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num1.Location = new System.Drawing.Point(23, 155);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 57);
            this.num1.TabIndex = 18;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(366, 427);
            this.Controls.Add(this.ponto);
            this.Controls.Add(this.apaga);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.txt_calculo);
            this.MaximumSize = new System.Drawing.Size(384, 474);
            this.MinimumSize = new System.Drawing.Size(384, 474);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txt_calculo;
        private Button ponto;
        private Button apaga;
        private Button num0;
        private Button cancel;
        private Button div;
        private Button mult;
        private Button sub;
        private Button soma;
        private Button igual;
        private Button num9;
        private Button num8;
        private Button num7;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button num3;
        private Button num2;
        private Button num1;
    }
}