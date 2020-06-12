namespace Rpg_Tester
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Gastar = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.input_num1 = new System.Windows.Forms.TextBox();
            this.btn_plus1 = new System.Windows.Forms.Button();
            this.btn_minus1 = new System.Windows.Forms.Button();
            this.input_Trans = new System.Windows.Forms.TextBox();
            this.btn_minus2 = new System.Windows.Forms.Button();
            this.btn_plus2 = new System.Windows.Forms.Button();
            this.input_num2 = new System.Windows.Forms.TextBox();
            this.btn_minus3 = new System.Windows.Forms.Button();
            this.btn_plus3 = new System.Windows.Forms.Button();
            this.input_num3 = new System.Windows.Forms.TextBox();
            this.btn_minus4 = new System.Windows.Forms.Button();
            this.btn_plus4 = new System.Windows.Forms.Button();
            this.input_num4 = new System.Windows.Forms.TextBox();
            this.btn_minus5 = new System.Windows.Forms.Button();
            this.btn_plus5 = new System.Windows.Forms.Button();
            this.input_num5 = new System.Windows.Forms.TextBox();
            this.btn_minus6 = new System.Windows.Forms.Button();
            this.btn_plus6 = new System.Windows.Forms.Button();
            this.input_num6 = new System.Windows.Forms.TextBox();
            this.mod1 = new System.Windows.Forms.TextBox();
            this.mod2 = new System.Windows.Forms.TextBox();
            this.mod3 = new System.Windows.Forms.TextBox();
            this.mod4 = new System.Windows.Forms.TextBox();
            this.mod5 = new System.Windows.Forms.TextBox();
            this.mod6 = new System.Windows.Forms.TextBox();
            this.Valor_ini = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Gastar
            // 
            this.lbl_Gastar.AutoSize = true;
            this.lbl_Gastar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Gastar.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gastar.Location = new System.Drawing.Point(212, 28);
            this.lbl_Gastar.Name = "lbl_Gastar";
            this.lbl_Gastar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Gastar.Size = new System.Drawing.Size(45, 37);
            this.lbl_Gastar.TabIndex = 0;
            this.lbl_Gastar.Text = "00";
            this.lbl_Gastar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(12, 43);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 25);
            this.btn_convert.TabIndex = 1;
            this.btn_convert.Text = "Coverter";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // input_num1
            // 
            this.input_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_num1.Location = new System.Drawing.Point(33, 131);
            this.input_num1.MaxLength = 10;
            this.input_num1.Name = "input_num1";
            this.input_num1.ReadOnly = true;
            this.input_num1.Size = new System.Drawing.Size(63, 26);
            this.input_num1.TabIndex = 2;
            this.input_num1.Text = "0";
            this.input_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_num1.TextChanged += new System.EventHandler(this.mod_change1);
            // 
            // btn_plus1
            // 
            this.btn_plus1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_plus1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus1.Location = new System.Drawing.Point(33, 167);
            this.btn_plus1.Name = "btn_plus1";
            this.btn_plus1.Size = new System.Drawing.Size(63, 23);
            this.btn_plus1.TabIndex = 3;
            this.btn_plus1.Text = "+";
            this.btn_plus1.UseVisualStyleBackColor = true;
            this.btn_plus1.Click += new System.EventHandler(this.btn_plus1_Click);
            // 
            // btn_minus1
            // 
            this.btn_minus1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_minus1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus1.Location = new System.Drawing.Point(33, 196);
            this.btn_minus1.Name = "btn_minus1";
            this.btn_minus1.Size = new System.Drawing.Size(63, 23);
            this.btn_minus1.TabIndex = 4;
            this.btn_minus1.Text = "-";
            this.btn_minus1.UseVisualStyleBackColor = true;
            this.btn_minus1.Click += new System.EventHandler(this.btn_minus1_Click);
            // 
            // input_Trans
            // 
            this.input_Trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Trans.Location = new System.Drawing.Point(12, 12);
            this.input_Trans.MaxLength = 3;
            this.input_Trans.Multiline = true;
            this.input_Trans.Name = "input_Trans";
            this.input_Trans.Size = new System.Drawing.Size(82, 25);
            this.input_Trans.TabIndex = 5;
            this.input_Trans.Text = "0";
            this.input_Trans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_minus2
            // 
            this.btn_minus2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_minus2.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus2.Location = new System.Drawing.Point(102, 196);
            this.btn_minus2.Name = "btn_minus2";
            this.btn_minus2.Size = new System.Drawing.Size(63, 23);
            this.btn_minus2.TabIndex = 8;
            this.btn_minus2.Text = "-";
            this.btn_minus2.UseVisualStyleBackColor = true;
            this.btn_minus2.Click += new System.EventHandler(this.btn_minus2_Click);
            // 
            // btn_plus2
            // 
            this.btn_plus2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_plus2.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus2.Location = new System.Drawing.Point(102, 167);
            this.btn_plus2.Name = "btn_plus2";
            this.btn_plus2.Size = new System.Drawing.Size(63, 23);
            this.btn_plus2.TabIndex = 7;
            this.btn_plus2.Text = "+";
            this.btn_plus2.UseVisualStyleBackColor = true;
            this.btn_plus2.Click += new System.EventHandler(this.btn_plus2_Click);
            // 
            // input_num2
            // 
            this.input_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_num2.Location = new System.Drawing.Point(102, 131);
            this.input_num2.MaxLength = 10;
            this.input_num2.Name = "input_num2";
            this.input_num2.ReadOnly = true;
            this.input_num2.Size = new System.Drawing.Size(63, 26);
            this.input_num2.TabIndex = 6;
            this.input_num2.Text = "0";
            this.input_num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_num2.TextChanged += new System.EventHandler(this.mod_change2);
            // 
            // btn_minus3
            // 
            this.btn_minus3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_minus3.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus3.Location = new System.Drawing.Point(171, 196);
            this.btn_minus3.Name = "btn_minus3";
            this.btn_minus3.Size = new System.Drawing.Size(63, 23);
            this.btn_minus3.TabIndex = 11;
            this.btn_minus3.Text = "-";
            this.btn_minus3.UseVisualStyleBackColor = true;
            this.btn_minus3.Click += new System.EventHandler(this.btn_minus3_Click);
            // 
            // btn_plus3
            // 
            this.btn_plus3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_plus3.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus3.Location = new System.Drawing.Point(171, 167);
            this.btn_plus3.Name = "btn_plus3";
            this.btn_plus3.Size = new System.Drawing.Size(63, 23);
            this.btn_plus3.TabIndex = 10;
            this.btn_plus3.Text = "+";
            this.btn_plus3.UseVisualStyleBackColor = true;
            this.btn_plus3.Click += new System.EventHandler(this.btn_plus3_Click);
            // 
            // input_num3
            // 
            this.input_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_num3.Location = new System.Drawing.Point(171, 131);
            this.input_num3.MaxLength = 10;
            this.input_num3.Name = "input_num3";
            this.input_num3.ReadOnly = true;
            this.input_num3.Size = new System.Drawing.Size(63, 26);
            this.input_num3.TabIndex = 9;
            this.input_num3.Text = "0";
            this.input_num3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_num3.TextChanged += new System.EventHandler(this.mod_change3);
            // 
            // btn_minus4
            // 
            this.btn_minus4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_minus4.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus4.Location = new System.Drawing.Point(240, 196);
            this.btn_minus4.Name = "btn_minus4";
            this.btn_minus4.Size = new System.Drawing.Size(63, 23);
            this.btn_minus4.TabIndex = 14;
            this.btn_minus4.Text = "-";
            this.btn_minus4.UseVisualStyleBackColor = true;
            this.btn_minus4.Click += new System.EventHandler(this.btn_minus4_Click);
            // 
            // btn_plus4
            // 
            this.btn_plus4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_plus4.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus4.Location = new System.Drawing.Point(240, 167);
            this.btn_plus4.Name = "btn_plus4";
            this.btn_plus4.Size = new System.Drawing.Size(63, 23);
            this.btn_plus4.TabIndex = 13;
            this.btn_plus4.Text = "+";
            this.btn_plus4.UseVisualStyleBackColor = true;
            this.btn_plus4.Click += new System.EventHandler(this.btn_plus4_Click);
            // 
            // input_num4
            // 
            this.input_num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_num4.Location = new System.Drawing.Point(240, 131);
            this.input_num4.MaxLength = 10;
            this.input_num4.Name = "input_num4";
            this.input_num4.ReadOnly = true;
            this.input_num4.Size = new System.Drawing.Size(63, 26);
            this.input_num4.TabIndex = 12;
            this.input_num4.Text = "0";
            this.input_num4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_num4.TextChanged += new System.EventHandler(this.mod_change4);
            // 
            // btn_minus5
            // 
            this.btn_minus5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_minus5.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus5.Location = new System.Drawing.Point(309, 196);
            this.btn_minus5.Name = "btn_minus5";
            this.btn_minus5.Size = new System.Drawing.Size(63, 23);
            this.btn_minus5.TabIndex = 17;
            this.btn_minus5.Text = "-";
            this.btn_minus5.UseVisualStyleBackColor = true;
            this.btn_minus5.Click += new System.EventHandler(this.btn_minus5_Click);
            // 
            // btn_plus5
            // 
            this.btn_plus5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_plus5.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus5.Location = new System.Drawing.Point(309, 167);
            this.btn_plus5.Name = "btn_plus5";
            this.btn_plus5.Size = new System.Drawing.Size(63, 23);
            this.btn_plus5.TabIndex = 16;
            this.btn_plus5.Text = "+";
            this.btn_plus5.UseVisualStyleBackColor = true;
            this.btn_plus5.Click += new System.EventHandler(this.btn_plus5_Click);
            // 
            // input_num5
            // 
            this.input_num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_num5.Location = new System.Drawing.Point(309, 131);
            this.input_num5.MaxLength = 10;
            this.input_num5.Name = "input_num5";
            this.input_num5.ReadOnly = true;
            this.input_num5.Size = new System.Drawing.Size(63, 26);
            this.input_num5.TabIndex = 15;
            this.input_num5.Text = "0";
            this.input_num5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_num5.TextChanged += new System.EventHandler(this.mod_change5);
            // 
            // btn_minus6
            // 
            this.btn_minus6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_minus6.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus6.Location = new System.Drawing.Point(378, 196);
            this.btn_minus6.Name = "btn_minus6";
            this.btn_minus6.Size = new System.Drawing.Size(63, 23);
            this.btn_minus6.TabIndex = 20;
            this.btn_minus6.Text = "-";
            this.btn_minus6.UseVisualStyleBackColor = true;
            this.btn_minus6.Click += new System.EventHandler(this.btn_minus6_Click);
            // 
            // btn_plus6
            // 
            this.btn_plus6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_plus6.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus6.Location = new System.Drawing.Point(378, 167);
            this.btn_plus6.Name = "btn_plus6";
            this.btn_plus6.Size = new System.Drawing.Size(63, 23);
            this.btn_plus6.TabIndex = 19;
            this.btn_plus6.Text = "+";
            this.btn_plus6.UseVisualStyleBackColor = true;
            this.btn_plus6.Click += new System.EventHandler(this.btn_plus6_Click);
            // 
            // input_num6
            // 
            this.input_num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_num6.Location = new System.Drawing.Point(378, 131);
            this.input_num6.MaxLength = 10;
            this.input_num6.Name = "input_num6";
            this.input_num6.ReadOnly = true;
            this.input_num6.Size = new System.Drawing.Size(63, 26);
            this.input_num6.TabIndex = 18;
            this.input_num6.Text = "0";
            this.input_num6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.input_num6.TextChanged += new System.EventHandler(this.mod_change6);
            // 
            // mod1
            // 
            this.mod1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod1.Location = new System.Drawing.Point(45, 105);
            this.mod1.MaxLength = 10;
            this.mod1.Name = "mod1";
            this.mod1.ReadOnly = true;
            this.mod1.Size = new System.Drawing.Size(33, 20);
            this.mod1.TabIndex = 21;
            this.mod1.Text = "0";
            this.mod1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mod2
            // 
            this.mod2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod2.Location = new System.Drawing.Point(116, 105);
            this.mod2.MaxLength = 10;
            this.mod2.Name = "mod2";
            this.mod2.ReadOnly = true;
            this.mod2.Size = new System.Drawing.Size(33, 20);
            this.mod2.TabIndex = 22;
            this.mod2.Text = "0";
            this.mod2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mod3
            // 
            this.mod3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod3.Location = new System.Drawing.Point(185, 105);
            this.mod3.MaxLength = 10;
            this.mod3.Name = "mod3";
            this.mod3.ReadOnly = true;
            this.mod3.Size = new System.Drawing.Size(33, 20);
            this.mod3.TabIndex = 23;
            this.mod3.Text = "0";
            this.mod3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mod4
            // 
            this.mod4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod4.Location = new System.Drawing.Point(252, 105);
            this.mod4.MaxLength = 10;
            this.mod4.Name = "mod4";
            this.mod4.ReadOnly = true;
            this.mod4.Size = new System.Drawing.Size(33, 20);
            this.mod4.TabIndex = 24;
            this.mod4.Text = "0";
            this.mod4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mod5
            // 
            this.mod5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod5.Location = new System.Drawing.Point(320, 105);
            this.mod5.MaxLength = 10;
            this.mod5.Name = "mod5";
            this.mod5.ReadOnly = true;
            this.mod5.Size = new System.Drawing.Size(33, 20);
            this.mod5.TabIndex = 25;
            this.mod5.Text = "0";
            this.mod5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mod6
            // 
            this.mod6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod6.Location = new System.Drawing.Point(392, 105);
            this.mod6.MaxLength = 10;
            this.mod6.Name = "mod6";
            this.mod6.ReadOnly = true;
            this.mod6.Size = new System.Drawing.Size(33, 20);
            this.mod6.TabIndex = 26;
            this.mod6.Text = "0";
            this.mod6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Valor_ini
            // 
            this.Valor_ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor_ini.Location = new System.Drawing.Point(385, 28);
            this.Valor_ini.MaxLength = 3;
            this.Valor_ini.Multiline = true;
            this.Valor_ini.Name = "Valor_ini";
            this.Valor_ini.Size = new System.Drawing.Size(67, 20);
            this.Valor_ini.TabIndex = 5;
            this.Valor_ini.Text = "0";
            this.Valor_ini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Atributo Base";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mod6);
            this.Controls.Add(this.mod5);
            this.Controls.Add(this.mod4);
            this.Controls.Add(this.mod3);
            this.Controls.Add(this.mod2);
            this.Controls.Add(this.mod1);
            this.Controls.Add(this.btn_minus6);
            this.Controls.Add(this.btn_plus6);
            this.Controls.Add(this.input_num6);
            this.Controls.Add(this.btn_minus5);
            this.Controls.Add(this.btn_plus5);
            this.Controls.Add(this.input_num5);
            this.Controls.Add(this.btn_minus4);
            this.Controls.Add(this.btn_plus4);
            this.Controls.Add(this.input_num4);
            this.Controls.Add(this.btn_minus3);
            this.Controls.Add(this.btn_plus3);
            this.Controls.Add(this.input_num3);
            this.Controls.Add(this.btn_minus2);
            this.Controls.Add(this.btn_plus2);
            this.Controls.Add(this.input_num2);
            this.Controls.Add(this.Valor_ini);
            this.Controls.Add(this.input_Trans);
            this.Controls.Add(this.btn_minus1);
            this.Controls.Add(this.btn_plus1);
            this.Controls.Add(this.input_num1);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.lbl_Gastar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rolagem de Atributos Check";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Gastar;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.TextBox input_num1;
        private System.Windows.Forms.Button btn_plus1;
        private System.Windows.Forms.Button btn_minus1;
        private System.Windows.Forms.TextBox input_Trans;
        private System.Windows.Forms.Button btn_minus2;
        private System.Windows.Forms.Button btn_plus2;
        private System.Windows.Forms.TextBox input_num2;
        private System.Windows.Forms.Button btn_minus3;
        private System.Windows.Forms.Button btn_plus3;
        private System.Windows.Forms.TextBox input_num3;
        private System.Windows.Forms.Button btn_minus4;
        private System.Windows.Forms.Button btn_plus4;
        private System.Windows.Forms.TextBox input_num4;
        private System.Windows.Forms.Button btn_minus5;
        private System.Windows.Forms.Button btn_plus5;
        private System.Windows.Forms.TextBox input_num5;
        private System.Windows.Forms.Button btn_minus6;
        private System.Windows.Forms.Button btn_plus6;
        private System.Windows.Forms.TextBox input_num6;
        private System.Windows.Forms.TextBox mod1;
        private System.Windows.Forms.TextBox mod2;
        private System.Windows.Forms.TextBox mod3;
        private System.Windows.Forms.TextBox mod4;
        private System.Windows.Forms.TextBox mod5;
        private System.Windows.Forms.TextBox mod6;
        private System.Windows.Forms.TextBox Valor_ini;
        private System.Windows.Forms.Label label1;
    }
}

