namespace Battle_Simulator_DnD
{
    partial class criaturaControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.nUD_Dmin = new System.Windows.Forms.NumericUpDown();
            this.nUD_PV = new System.Windows.Forms.NumericUpDown();
            this.nUD_CA = new System.Windows.Forms.NumericUpDown();
            this.nUD_Ini = new System.Windows.Forms.NumericUpDown();
            this.nUD_BA = new System.Windows.Forms.NumericUpDown();
            this.nUD_Dmax = new System.Windows.Forms.NumericUpDown();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Dmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_PV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Ini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_BA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Dmax)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(11, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(21, 66);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 15);
            label2.TabIndex = 2;
            label2.Text = "CA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(21, 36);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(25, 15);
            label3.TabIndex = 3;
            label3.Text = "PV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(21, 126);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(25, 15);
            label4.TabIndex = 4;
            label4.Text = "BA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(4, 186);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 15);
            label5.TabIndex = 5;
            label5.Text = "Dano Max";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(4, 156);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(66, 15);
            label6.TabIndex = 6;
            label6.Text = "Dano Min";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(4, 96);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(65, 15);
            label7.TabIndex = 7;
            label7.Text = "Iniciativa";
            // 
            // nUD_Dmin
            // 
            this.nUD_Dmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUD_Dmin.Location = new System.Drawing.Point(82, 154);
            this.nUD_Dmin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_Dmin.Name = "nUD_Dmin";
            this.nUD_Dmin.Size = new System.Drawing.Size(118, 21);
            this.nUD_Dmin.TabIndex = 0;
            this.nUD_Dmin.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_Dmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // nUD_PV
            // 
            this.nUD_PV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUD_PV.Location = new System.Drawing.Point(82, 34);
            this.nUD_PV.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nUD_PV.Name = "nUD_PV";
            this.nUD_PV.Size = new System.Drawing.Size(118, 21);
            this.nUD_PV.TabIndex = 8;
            this.nUD_PV.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nUD_PV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // nUD_CA
            // 
            this.nUD_CA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUD_CA.Location = new System.Drawing.Point(82, 64);
            this.nUD_CA.Name = "nUD_CA";
            this.nUD_CA.Size = new System.Drawing.Size(118, 21);
            this.nUD_CA.TabIndex = 9;
            this.nUD_CA.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD_CA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // nUD_Ini
            // 
            this.nUD_Ini.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUD_Ini.Location = new System.Drawing.Point(82, 94);
            this.nUD_Ini.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nUD_Ini.Name = "nUD_Ini";
            this.nUD_Ini.Size = new System.Drawing.Size(118, 21);
            this.nUD_Ini.TabIndex = 10;
            this.nUD_Ini.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_Ini.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // nUD_BA
            // 
            this.nUD_BA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUD_BA.Location = new System.Drawing.Point(82, 124);
            this.nUD_BA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nUD_BA.Name = "nUD_BA";
            this.nUD_BA.Size = new System.Drawing.Size(118, 21);
            this.nUD_BA.TabIndex = 11;
            this.nUD_BA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_BA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // nUD_Dmax
            // 
            this.nUD_Dmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUD_Dmax.Location = new System.Drawing.Point(82, 184);
            this.nUD_Dmax.Name = "nUD_Dmax";
            this.nUD_Dmax.Size = new System.Drawing.Size(118, 21);
            this.nUD_Dmax.TabIndex = 13;
            this.nUD_Dmax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD_Dmax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(82, 6);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(116, 21);
            this.txt_Nome.TabIndex = 14;
            this.txt_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
            // 
            // criaturaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.nUD_Dmax);
            this.Controls.Add(this.nUD_BA);
            this.Controls.Add(this.nUD_Ini);
            this.Controls.Add(this.nUD_CA);
            this.Controls.Add(this.nUD_PV);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.nUD_Dmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "criaturaControl";
            this.Size = new System.Drawing.Size(204, 211);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Dmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_PV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Ini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_BA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Dmax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUD_Dmin;
        private System.Windows.Forms.NumericUpDown nUD_PV;
        private System.Windows.Forms.NumericUpDown nUD_CA;
        private System.Windows.Forms.NumericUpDown nUD_Ini;
        private System.Windows.Forms.NumericUpDown nUD_BA;
        private System.Windows.Forms.NumericUpDown nUD_Dmax;
        private System.Windows.Forms.TextBox txt_Nome;
    }
}
