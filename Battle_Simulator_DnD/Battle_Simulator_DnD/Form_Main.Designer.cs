namespace Battle_Simulator_DnD
{
    partial class Form_Main
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "SD",
            "38",
            "6",
            "6",
            "6",
            "6",
            "6"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "uuuuhhhhhh",
            "32",
            "9",
            "8",
            "5",
            "3",
            "6"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "gggggg",
            "9",
            "7",
            "4",
            "5",
            "3",
            "2"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.chkBox_grp = new System.Windows.Forms.CheckBox();
            this.custom = new Battle_Simulator_DnD.criaturaControl();
            this.LV_Inimigo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_start = new System.Windows.Forms.Button();
            this.LV_Aliado = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nUD_delay = new System.Windows.Forms.NumericUpDown();
            this.btn_help = new System.Windows.Forms.Button();
            this.chkBox_auto = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_delay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.chkBox_grp);
            this.groupBox1.Controls.Add(this.custom);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 289);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(131, 250);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(87, 27);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(6, 252);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(26, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "R1";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // chkBox_grp
            // 
            this.chkBox_grp.AutoSize = true;
            this.chkBox_grp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkBox_grp.FlatAppearance.BorderSize = 8;
            this.chkBox_grp.Location = new System.Drawing.Point(52, 256);
            this.chkBox_grp.Name = "chkBox_grp";
            this.chkBox_grp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBox_grp.Size = new System.Drawing.Size(73, 17);
            this.chkBox_grp.TabIndex = 5;
            this.chkBox_grp.Text = "= Grupo 1";
            this.chkBox_grp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBox_grp.UseVisualStyleBackColor = true;
            this.chkBox_grp.CheckedChanged += new System.EventHandler(this.chkBox_grp_CheckedChanged);
            this.chkBox_grp.Paint += new System.Windows.Forms.PaintEventHandler(this.chkBox_grp_Paint);
            // 
            // custom
            // 
            this.custom.BA = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.custom.CA = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.custom.DMAX = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.custom.DMIN = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.custom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom.INI = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.custom.Location = new System.Drawing.Point(6, 21);
            this.custom.Name = "custom";
            this.custom.Nome = "";
            this.custom.PV = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.custom.Size = new System.Drawing.Size(212, 208);
            this.custom.TabIndex = 2;
            // 
            // LV_Inimigo
            // 
            this.LV_Inimigo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.LV_Inimigo.FullRowSelect = true;
            this.LV_Inimigo.GridLines = true;
            this.LV_Inimigo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem1.UseItemStyleForSubItems = false;
            this.LV_Inimigo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.LV_Inimigo.Location = new System.Drawing.Point(247, 148);
            this.LV_Inimigo.MultiSelect = false;
            this.LV_Inimigo.Name = "LV_Inimigo";
            this.LV_Inimigo.Size = new System.Drawing.Size(359, 119);
            this.LV_Inimigo.TabIndex = 13;
            this.LV_Inimigo.UseCompatibleStateImageBehavior = false;
            this.LV_Inimigo.View = System.Windows.Forms.View.Details;
            this.LV_Inimigo.SelectedIndexChanged += new System.EventHandler(this.LV_SelectedIndexChanged);
            this.LV_Inimigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LV_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PV";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 43;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CA";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 43;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "INI";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 43;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "BA";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 43;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "D.Min";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 42;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "D.Max";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 43;
            // 
            // btn_start
            // 
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(519, 276);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(87, 27);
            this.btn_start.TabIndex = 14;
            this.btn_start.Text = "Iniciar";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // LV_Aliado
            // 
            this.LV_Aliado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.LV_Aliado.FullRowSelect = true;
            this.LV_Aliado.GridLines = true;
            this.LV_Aliado.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            this.LV_Aliado.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2,
            listViewItem3});
            this.LV_Aliado.Location = new System.Drawing.Point(247, 23);
            this.LV_Aliado.MultiSelect = false;
            this.LV_Aliado.Name = "LV_Aliado";
            this.LV_Aliado.Size = new System.Drawing.Size(359, 119);
            this.LV_Aliado.TabIndex = 15;
            this.LV_Aliado.UseCompatibleStateImageBehavior = false;
            this.LV_Aliado.View = System.Windows.Forms.View.Details;
            this.LV_Aliado.SelectedIndexChanged += new System.EventHandler(this.LV_SelectedIndexChanged);
            this.LV_Aliado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LV_KeyDown);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nome";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "PV";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 43;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "CA";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 43;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "INI";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 43;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "BA";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 43;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "D.Min";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 43;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "D.Max";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 43;
            // 
            // nUD_delay
            // 
            this.nUD_delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUD_delay.Location = new System.Drawing.Point(433, 279);
            this.nUD_delay.Maximum = new decimal(new int[] {
            216000,
            0,
            0,
            0});
            this.nUD_delay.Name = "nUD_delay";
            this.nUD_delay.Size = new System.Drawing.Size(80, 21);
            this.nUD_delay.TabIndex = 16;
            this.nUD_delay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.Location = new System.Drawing.Point(248, 274);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(37, 32);
            this.btn_help.TabIndex = 17;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // chkBox_auto
            // 
            this.chkBox_auto.AutoSize = true;
            this.chkBox_auto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.chkBox_auto.FlatAppearance.BorderSize = 8;
            this.chkBox_auto.Location = new System.Drawing.Point(348, 282);
            this.chkBox_auto.Name = "chkBox_auto";
            this.chkBox_auto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBox_auto.Size = new System.Drawing.Size(79, 17);
            this.chkBox_auto.TabIndex = 18;
            this.chkBox_auto.Text = "Automatico";
            this.chkBox_auto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBox_auto.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 314);
            this.Controls.Add(this.chkBox_auto);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.nUD_delay);
            this.Controls.Add(this.LV_Aliado);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.LV_Inimigo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private criaturaControl custom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListView LV_Inimigo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.CheckBox chkBox_grp;
        private System.Windows.Forms.ListView LV_Aliado;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.NumericUpDown nUD_delay;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.CheckBox chkBox_auto;
    }
}

