namespace InitiativeTracker
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
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.nud_ini = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.txt_rodadaAtual = new System.Windows.Forms.TextBox();
            this.btn_newCombat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_turnoAtual = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ini)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.ListBox1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Items.AddRange(new object[] {
            "Dragao\t1\t18",
            "Lich\t2\t14"});
            this.ListBox1.Location = new System.Drawing.Point(118, 44);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(312, 180);
            this.ListBox1.TabIndex = 2;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(12, 44);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Deletar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(12, 168);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(87, 25);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "Proximo Turno";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_nextTurno_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(446, 79);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(12, 102);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 23);
            this.btn_down.TabIndex = 6;
            this.btn_down.Text = "Descer";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(12, 73);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 7;
            this.btn_up.Text = "Subir";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(436, 121);
            this.txt_nome.MaxLength = 12;
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 8;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(436, 165);
            this.txt_time.MaxLength = 6;
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(100, 20);
            this.txt_time.TabIndex = 9;
            this.txt_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // nud_ini
            // 
            this.nud_ini.Location = new System.Drawing.Point(436, 204);
            this.nud_ini.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nud_ini.Name = "nud_ini";
            this.nud_ini.Size = new System.Drawing.Size(100, 20);
            this.nud_ini.TabIndex = 10;
            this.nud_ini.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_ini.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Iniciativa";
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(446, 50);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 23);
            this.btn_alterar.TabIndex = 14;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // txt_rodadaAtual
            // 
            this.txt_rodadaAtual.Location = new System.Drawing.Point(384, 18);
            this.txt_rodadaAtual.MaxLength = 100;
            this.txt_rodadaAtual.Name = "txt_rodadaAtual";
            this.txt_rodadaAtual.ReadOnly = true;
            this.txt_rodadaAtual.Size = new System.Drawing.Size(46, 20);
            this.txt_rodadaAtual.TabIndex = 15;
            this.txt_rodadaAtual.Text = "1";
            this.txt_rodadaAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_newCombat
            // 
            this.btn_newCombat.Location = new System.Drawing.Point(12, 199);
            this.btn_newCombat.Name = "btn_newCombat";
            this.btn_newCombat.Size = new System.Drawing.Size(87, 25);
            this.btn_newCombat.TabIndex = 16;
            this.btn_newCombat.Text = "Novo Combate";
            this.btn_newCombat.UseVisualStyleBackColor = true;
            this.btn_newCombat.Click += new System.EventHandler(this.btn_newCombat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Rodada Atual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Turno Atual";
            // 
            // txt_turnoAtual
            // 
            this.txt_turnoAtual.Location = new System.Drawing.Point(183, 18);
            this.txt_turnoAtual.MaxLength = 100;
            this.txt_turnoAtual.Name = "txt_turnoAtual";
            this.txt_turnoAtual.ReadOnly = true;
            this.txt_turnoAtual.Size = new System.Drawing.Size(46, 20);
            this.txt_turnoAtual.TabIndex = 18;
            this.txt_turnoAtual.Text = "1";
            this.txt_turnoAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(461, 24);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(49, 20);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "Apagar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(555, 245);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_turnoAtual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_newCombat);
            this.Controls.Add(this.txt_rodadaAtual);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_ini);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.ListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciative Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_ini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.NumericUpDown nud_ini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.TextBox txt_rodadaAtual;
        private System.Windows.Forms.Button btn_newCombat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_turnoAtual;
        private System.Windows.Forms.Button btn_clear;
    }
}

