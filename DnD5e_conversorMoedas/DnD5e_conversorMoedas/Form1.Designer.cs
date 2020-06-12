namespace DnD5e_conversorMoedas
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
            this.lbl_Dinheiro = new System.Windows.Forms.Label();
            this.txt_PX = new System.Windows.Forms.TextBox();
            this.lbl_PX = new System.Windows.Forms.Label();
            this.btn_PC = new System.Windows.Forms.Button();
            this.btn_PP = new System.Windows.Forms.Button();
            this.btn_PE = new System.Windows.Forms.Button();
            this.btn_PO = new System.Windows.Forms.Button();
            this.PL = new System.Windows.Forms.Button();
            this.rdoPC = new System.Windows.Forms.RadioButton();
            this.rdoPP = new System.Windows.Forms.RadioButton();
            this.rdoPE = new System.Windows.Forms.RadioButton();
            this.rdoPO = new System.Windows.Forms.RadioButton();
            this.rdoPL = new System.Windows.Forms.RadioButton();
            this.lbl_conversor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Dinheiro
            // 
            this.lbl_Dinheiro.AutoSize = true;
            this.lbl_Dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dinheiro.Location = new System.Drawing.Point(67, 13);
            this.lbl_Dinheiro.Name = "lbl_Dinheiro";
            this.lbl_Dinheiro.Size = new System.Drawing.Size(87, 17);
            this.lbl_Dinheiro.TabIndex = 2;
            this.lbl_Dinheiro.Text = "Dinheiro: PC";
            // 
            // txt_PX
            // 
            this.txt_PX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PX.Location = new System.Drawing.Point(70, 32);
            this.txt_PX.MaxLength = 9;
            this.txt_PX.Name = "txt_PX";
            this.txt_PX.Size = new System.Drawing.Size(85, 23);
            this.txt_PX.TabIndex = 4;
            this.txt_PX.Text = "0";
            this.txt_PX.TextChanged += new System.EventHandler(this.txt_Changed);
            this.txt_PX.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lbl_PX
            // 
            this.lbl_PX.AutoSize = true;
            this.lbl_PX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_PX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PX.Location = new System.Drawing.Point(70, 80);
            this.lbl_PX.Name = "lbl_PX";
            this.lbl_PX.Size = new System.Drawing.Size(63, 28);
            this.lbl_PX.TabIndex = 8;
            this.lbl_PX.Text = "0 PC";
            this.lbl_PX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_PC
            // 
            this.btn_PC.Location = new System.Drawing.Point(163, 32);
            this.btn_PC.Name = "btn_PC";
            this.btn_PC.Size = new System.Drawing.Size(37, 24);
            this.btn_PC.TabIndex = 19;
            this.btn_PC.Text = "PC";
            this.btn_PC.UseVisualStyleBackColor = true;
            this.btn_PC.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_PP
            // 
            this.btn_PP.Location = new System.Drawing.Point(206, 32);
            this.btn_PP.Name = "btn_PP";
            this.btn_PP.Size = new System.Drawing.Size(37, 24);
            this.btn_PP.TabIndex = 20;
            this.btn_PP.Text = "PP";
            this.btn_PP.UseVisualStyleBackColor = true;
            this.btn_PP.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_PE
            // 
            this.btn_PE.Location = new System.Drawing.Point(249, 32);
            this.btn_PE.Name = "btn_PE";
            this.btn_PE.Size = new System.Drawing.Size(37, 24);
            this.btn_PE.TabIndex = 21;
            this.btn_PE.Text = "PE";
            this.btn_PE.UseVisualStyleBackColor = true;
            this.btn_PE.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_PO
            // 
            this.btn_PO.Location = new System.Drawing.Point(292, 32);
            this.btn_PO.Name = "btn_PO";
            this.btn_PO.Size = new System.Drawing.Size(37, 24);
            this.btn_PO.TabIndex = 22;
            this.btn_PO.Text = "PO";
            this.btn_PO.UseVisualStyleBackColor = true;
            this.btn_PO.Click += new System.EventHandler(this.btn_Click);
            // 
            // PL
            // 
            this.PL.Location = new System.Drawing.Point(335, 32);
            this.PL.Name = "PL";
            this.PL.Size = new System.Drawing.Size(37, 24);
            this.PL.TabIndex = 23;
            this.PL.Text = "PL";
            this.PL.UseVisualStyleBackColor = true;
            this.PL.Click += new System.EventHandler(this.btn_Click);
            // 
            // rdoPC
            // 
            this.rdoPC.AutoSize = true;
            this.rdoPC.Location = new System.Drawing.Point(12, 11);
            this.rdoPC.Name = "rdoPC";
            this.rdoPC.Size = new System.Drawing.Size(39, 17);
            this.rdoPC.TabIndex = 24;
            this.rdoPC.TabStop = true;
            this.rdoPC.Text = "PC";
            this.rdoPC.UseVisualStyleBackColor = true;
            this.rdoPC.Click += new System.EventHandler(this.radio_click);
            // 
            // rdoPP
            // 
            this.rdoPP.AutoSize = true;
            this.rdoPP.Location = new System.Drawing.Point(12, 34);
            this.rdoPP.Name = "rdoPP";
            this.rdoPP.Size = new System.Drawing.Size(39, 17);
            this.rdoPP.TabIndex = 25;
            this.rdoPP.TabStop = true;
            this.rdoPP.Text = "PP";
            this.rdoPP.UseVisualStyleBackColor = true;
            this.rdoPP.Click += new System.EventHandler(this.radio_click);
            // 
            // rdoPE
            // 
            this.rdoPE.AutoSize = true;
            this.rdoPE.Location = new System.Drawing.Point(12, 57);
            this.rdoPE.Name = "rdoPE";
            this.rdoPE.Size = new System.Drawing.Size(39, 17);
            this.rdoPE.TabIndex = 26;
            this.rdoPE.TabStop = true;
            this.rdoPE.Text = "PE";
            this.rdoPE.UseVisualStyleBackColor = true;
            this.rdoPE.Click += new System.EventHandler(this.radio_click);
            // 
            // rdoPO
            // 
            this.rdoPO.AutoSize = true;
            this.rdoPO.Location = new System.Drawing.Point(12, 80);
            this.rdoPO.Name = "rdoPO";
            this.rdoPO.Size = new System.Drawing.Size(40, 17);
            this.rdoPO.TabIndex = 27;
            this.rdoPO.TabStop = true;
            this.rdoPO.Text = "PO";
            this.rdoPO.UseVisualStyleBackColor = true;
            this.rdoPO.Click += new System.EventHandler(this.radio_click);
            // 
            // rdoPL
            // 
            this.rdoPL.AutoSize = true;
            this.rdoPL.Location = new System.Drawing.Point(12, 103);
            this.rdoPL.Name = "rdoPL";
            this.rdoPL.Size = new System.Drawing.Size(38, 17);
            this.rdoPL.TabIndex = 28;
            this.rdoPL.TabStop = true;
            this.rdoPL.Text = "PL";
            this.rdoPL.UseVisualStyleBackColor = true;
            this.rdoPL.Click += new System.EventHandler(this.radio_click);
            // 
            // lbl_conversor
            // 
            this.lbl_conversor.AutoSize = true;
            this.lbl_conversor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conversor.Location = new System.Drawing.Point(217, 13);
            this.lbl_conversor.Name = "lbl_conversor";
            this.lbl_conversor.Size = new System.Drawing.Size(99, 17);
            this.lbl_conversor.TabIndex = 29;
            this.lbl_conversor.Text = "Conversor: PC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 133);
            this.Controls.Add(this.lbl_conversor);
            this.Controls.Add(this.rdoPL);
            this.Controls.Add(this.rdoPO);
            this.Controls.Add(this.rdoPE);
            this.Controls.Add(this.rdoPP);
            this.Controls.Add(this.rdoPC);
            this.Controls.Add(this.PL);
            this.Controls.Add(this.btn_PO);
            this.Controls.Add(this.btn_PE);
            this.Controls.Add(this.btn_PP);
            this.Controls.Add(this.btn_PC);
            this.Controls.Add(this.lbl_PX);
            this.Controls.Add(this.txt_PX);
            this.Controls.Add(this.lbl_Dinheiro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DnD5e Coversor de Moedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Dinheiro;
        private System.Windows.Forms.TextBox txt_PX;
        private System.Windows.Forms.Label lbl_PX;
        private System.Windows.Forms.Button btn_PC;
        private System.Windows.Forms.Button btn_PP;
        private System.Windows.Forms.Button btn_PE;
        private System.Windows.Forms.Button btn_PO;
        private System.Windows.Forms.Button PL;
        private System.Windows.Forms.RadioButton rdoPC;
        private System.Windows.Forms.RadioButton rdoPP;
        private System.Windows.Forms.RadioButton rdoPE;
        private System.Windows.Forms.RadioButton rdoPO;
        private System.Windows.Forms.RadioButton rdoPL;
        private System.Windows.Forms.Label lbl_conversor;
    }
}

