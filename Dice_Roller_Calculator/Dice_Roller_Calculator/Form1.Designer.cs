namespace Dice_Roller_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_vezes = new System.Windows.Forms.NumericUpDown();
            this.nud_lados = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.nud_bonus = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vezes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_lados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bonus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 100;
            this.label1.Text = "Lados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 100;
            this.label3.Text = "Vezes";
            // 
            // nud_vezes
            // 
            this.nud_vezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_vezes.Location = new System.Drawing.Point(13, 36);
            this.nud_vezes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_vezes.Name = "nud_vezes";
            this.nud_vezes.Size = new System.Drawing.Size(50, 23);
            this.nud_vezes.TabIndex = 1;
            this.nud_vezes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_vezes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Press);
            // 
            // nud_lados
            // 
            this.nud_lados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_lados.Location = new System.Drawing.Point(97, 36);
            this.nud_lados.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_lados.Name = "nud_lados";
            this.nud_lados.Size = new System.Drawing.Size(49, 23);
            this.nud_lados.TabIndex = 2;
            this.nud_lados.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_lados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Press);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 18);
            this.label2.TabIndex = 101;
            this.label2.Text = "D";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(156, 74);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // nud_bonus
            // 
            this.nud_bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_bonus.Location = new System.Drawing.Point(178, 36);
            this.nud_bonus.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_bonus.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nud_bonus.Name = "nud_bonus";
            this.nud_bonus.Size = new System.Drawing.Size(50, 23);
            this.nud_bonus.TabIndex = 3;
            this.nud_bonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Press);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 102;
            this.label4.Text = "Bônus";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(134, 116);
            this.listBox1.TabIndex = 103;
            this.listBox1.TabStop = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(156, 103);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 21);
            this.label5.TabIndex = 106;
            this.label5.Text = "+";
            // 
            // txt_result
            // 
            this.txt_result.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_result.Location = new System.Drawing.Point(156, 170);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(75, 20);
            this.txt_result.TabIndex = 107;
            this.txt_result.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 108;
            this.label6.Text = "Dados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 202);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nud_bonus);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_lados);
            this.Controls.Add(this.nud_vezes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Dados";
            ((System.ComponentModel.ISupportInitialize)(this.nud_vezes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_lados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_vezes;
        private System.Windows.Forms.NumericUpDown nud_lados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.NumericUpDown nud_bonus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label6;
    }
}

