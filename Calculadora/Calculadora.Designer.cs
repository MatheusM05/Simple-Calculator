namespace Calculadora
{
    partial class frm_calculadora
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
            this.display = new System.Windows.Forms.Label();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_subt = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.display_sec = new System.Windows.Forms.Label();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_ponto = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_porc = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.btn_men = new System.Windows.Forms.Button();
            this.btn_menR = new System.Windows.Forms.Button();
            this.btn_menU = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_mem = new System.Windows.Forms.Label();
            this.display_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.display.Location = new System.Drawing.Point(12, 48);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(0, 24);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_soma
            // 
            this.btn_soma.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_soma.FlatAppearance.BorderSize = 2;
            this.btn_soma.Location = new System.Drawing.Point(120, 189);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(30, 30);
            this.btn_soma.TabIndex = 4;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_subt
            // 
            this.btn_subt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_subt.FlatAppearance.BorderSize = 2;
            this.btn_subt.Location = new System.Drawing.Point(156, 189);
            this.btn_subt.Name = "btn_subt";
            this.btn_subt.Size = new System.Drawing.Size(30, 30);
            this.btn_subt.TabIndex = 5;
            this.btn_subt.Text = "-";
            this.btn_subt.UseVisualStyleBackColor = true;
            this.btn_subt.Click += new System.EventHandler(this.btn_subt_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_mult.FlatAppearance.BorderSize = 2;
            this.btn_mult.Location = new System.Drawing.Point(120, 153);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(30, 30);
            this.btn_mult.TabIndex = 6;
            this.btn_mult.Text = "*";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_div
            // 
            this.btn_div.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_div.FlatAppearance.BorderSize = 2;
            this.btn_div.Location = new System.Drawing.Point(156, 153);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(30, 30);
            this.btn_div.TabIndex = 7;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // display_sec
            // 
            this.display_sec.AutoSize = true;
            this.display_sec.BackColor = System.Drawing.SystemColors.Control;
            this.display_sec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.display_sec.Location = new System.Drawing.Point(13, 28);
            this.display_sec.Name = "display_sec";
            this.display_sec.Size = new System.Drawing.Size(0, 13);
            this.display_sec.TabIndex = 8;
            this.display_sec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_6
            // 
            this.btn_6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_6.FlatAppearance.BorderSize = 2;
            this.btn_6.Location = new System.Drawing.Point(84, 153);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(30, 30);
            this.btn_6.TabIndex = 9;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_5.FlatAppearance.BorderSize = 2;
            this.btn_5.Location = new System.Drawing.Point(48, 153);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(30, 30);
            this.btn_5.TabIndex = 10;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_4.FlatAppearance.BorderSize = 2;
            this.btn_4.Location = new System.Drawing.Point(12, 153);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(30, 30);
            this.btn_4.TabIndex = 11;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_ponto
            // 
            this.btn_ponto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ponto.FlatAppearance.BorderSize = 2;
            this.btn_ponto.Location = new System.Drawing.Point(48, 225);
            this.btn_ponto.Name = "btn_ponto";
            this.btn_ponto.Size = new System.Drawing.Size(30, 30);
            this.btn_ponto.TabIndex = 12;
            this.btn_ponto.Text = ".";
            this.btn_ponto.UseVisualStyleBackColor = true;
            this.btn_ponto.Click += new System.EventHandler(this.btn_ponto_Click);
            // 
            // btn_0
            // 
            this.btn_0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_0.FlatAppearance.BorderSize = 2;
            this.btn_0.Location = new System.Drawing.Point(12, 225);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(30, 30);
            this.btn_0.TabIndex = 13;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_3
            // 
            this.btn_3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_3.FlatAppearance.BorderSize = 2;
            this.btn_3.Location = new System.Drawing.Point(84, 189);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(30, 30);
            this.btn_3.TabIndex = 14;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_2.FlatAppearance.BorderSize = 2;
            this.btn_2.Location = new System.Drawing.Point(48, 189);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(30, 30);
            this.btn_2.TabIndex = 15;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_1.FlatAppearance.BorderSize = 2;
            this.btn_1.Location = new System.Drawing.Point(12, 189);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(30, 30);
            this.btn_1.TabIndex = 16;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_7
            // 
            this.btn_7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_7.FlatAppearance.BorderSize = 2;
            this.btn_7.Location = new System.Drawing.Point(12, 117);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(30, 30);
            this.btn_7.TabIndex = 19;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_8.FlatAppearance.BorderSize = 2;
            this.btn_8.Location = new System.Drawing.Point(48, 117);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(30, 30);
            this.btn_8.TabIndex = 18;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_9.FlatAppearance.BorderSize = 2;
            this.btn_9.Location = new System.Drawing.Point(84, 117);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(30, 30);
            this.btn_9.TabIndex = 17;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_limpar.FlatAppearance.BorderSize = 2;
            this.btn_limpar.Location = new System.Drawing.Point(83, 225);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(30, 30);
            this.btn_limpar.TabIndex = 20;
            this.btn_limpar.Text = "C";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_porc
            // 
            this.btn_porc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_porc.FlatAppearance.BorderSize = 2;
            this.btn_porc.Location = new System.Drawing.Point(120, 117);
            this.btn_porc.Name = "btn_porc";
            this.btn_porc.Size = new System.Drawing.Size(30, 30);
            this.btn_porc.TabIndex = 22;
            this.btn_porc.Text = "%";
            this.btn_porc.UseVisualStyleBackColor = true;
            this.btn_porc.Click += new System.EventHandler(this.btn_porc_Click);
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sqrt.FlatAppearance.BorderSize = 2;
            this.btn_sqrt.Location = new System.Drawing.Point(156, 117);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(30, 30);
            this.btn_sqrt.TabIndex = 25;
            this.btn_sqrt.Text = "√";
            this.btn_sqrt.UseVisualStyleBackColor = true;
            this.btn_sqrt.Click += new System.EventHandler(this.btn_sqrt_Click);
            // 
            // btn_men
            // 
            this.btn_men.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_men.FlatAppearance.BorderSize = 2;
            this.btn_men.Location = new System.Drawing.Point(12, 81);
            this.btn_men.Name = "btn_men";
            this.btn_men.Size = new System.Drawing.Size(30, 30);
            this.btn_men.TabIndex = 24;
            this.btn_men.Text = "M";
            this.btn_men.UseVisualStyleBackColor = true;
            this.btn_men.Click += new System.EventHandler(this.btn_men_Click);
            // 
            // btn_menR
            // 
            this.btn_menR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_menR.FlatAppearance.BorderSize = 2;
            this.btn_menR.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menR.Location = new System.Drawing.Point(84, 81);
            this.btn_menR.Name = "btn_menR";
            this.btn_menR.Size = new System.Drawing.Size(30, 30);
            this.btn_menR.TabIndex = 26;
            this.btn_menR.Text = "MR";
            this.btn_menR.UseVisualStyleBackColor = true;
            this.btn_menR.Click += new System.EventHandler(this.btn_menR_Click);
            // 
            // btn_menU
            // 
            this.btn_menU.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_menU.FlatAppearance.BorderSize = 2;
            this.btn_menU.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menU.Location = new System.Drawing.Point(48, 81);
            this.btn_menU.Name = "btn_menU";
            this.btn_menU.Size = new System.Drawing.Size(30, 30);
            this.btn_menU.TabIndex = 27;
            this.btn_menU.Text = "MU";
            this.btn_menU.UseVisualStyleBackColor = true;
            this.btn_menU.Click += new System.EventHandler(this.btn_menU_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_calcular.Location = new System.Drawing.Point(119, 225);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(66, 30);
            this.btn_calcular.TabIndex = 2;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_mem
            // 
            this.lbl_mem.AutoSize = true;
            this.lbl_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mem.Location = new System.Drawing.Point(180, 9);
            this.lbl_mem.Name = "lbl_mem";
            this.lbl_mem.Size = new System.Drawing.Size(0, 13);
            this.lbl_mem.TabIndex = 28;
            // 
            // display_error
            // 
            this.display_error.AutoSize = true;
            this.display_error.Location = new System.Drawing.Point(12, 8);
            this.display_error.Name = "display_error";
            this.display_error.Size = new System.Drawing.Size(87, 13);
            this.display_error.TabIndex = 29;
            this.display_error.Text = "Calculadora v3.0";
            // 
            // frm_calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(196, 266);
            this.Controls.Add(this.display_error);
            this.Controls.Add(this.lbl_mem);
            this.Controls.Add(this.btn_menU);
            this.Controls.Add(this.btn_menR);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.btn_men);
            this.Controls.Add(this.btn_porc);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_ponto);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.display_sec);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_subt);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.display);
            this.KeyPreview = true;
            this.Name = "frm_calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculadora_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_subt;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Label display_sec;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_ponto;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_porc;
        private System.Windows.Forms.Button btn_sqrt;
        private System.Windows.Forms.Button btn_men;
        private System.Windows.Forms.Button btn_menR;
        private System.Windows.Forms.Button btn_menU;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_mem;
        private System.Windows.Forms.Label display_error;
    }
}

