namespace Battle_Simulator_DnD
{
    partial class Form_Battle_Random
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Battle_Random));
            this.rtxt_Log = new System.Windows.Forms.RichTextBox();
            this.lbl_Turno = new System.Windows.Forms.Label();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.LV_Aliado = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LV_Inimigos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_winner = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(236, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 23);
            label1.TabIndex = 3;
            label1.Text = "Turno:";
            // 
            // rtxt_Log
            // 
            this.rtxt_Log.BackColor = System.Drawing.SystemColors.Window;
            this.rtxt_Log.DetectUrls = false;
            this.rtxt_Log.Location = new System.Drawing.Point(162, 202);
            this.rtxt_Log.Name = "rtxt_Log";
            this.rtxt_Log.ReadOnly = true;
            this.rtxt_Log.ShortcutsEnabled = false;
            this.rtxt_Log.Size = new System.Drawing.Size(288, 138);
            this.rtxt_Log.TabIndex = 0;
            this.rtxt_Log.Text = "";
            // 
            // lbl_Turno
            // 
            this.lbl_Turno.AutoSize = true;
            this.lbl_Turno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Turno.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Turno.Location = new System.Drawing.Point(312, 32);
            this.lbl_Turno.Name = "lbl_Turno";
            this.lbl_Turno.Size = new System.Drawing.Size(27, 30);
            this.lbl_Turno.TabIndex = 7;
            this.lbl_Turno.Text = "0";
            this.lbl_Turno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(269, 86);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 0;
            this.btn_iniciar.Text = "Começar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // LV_Aliado
            // 
            this.LV_Aliado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.LV_Aliado.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LV_Aliado.FullRowSelect = true;
            this.LV_Aliado.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_Aliado.Location = new System.Drawing.Point(12, 12);
            this.LV_Aliado.MultiSelect = false;
            this.LV_Aliado.Name = "LV_Aliado";
            this.LV_Aliado.Size = new System.Drawing.Size(144, 328);
            this.LV_Aliado.TabIndex = 16;
            this.LV_Aliado.UseCompatibleStateImageBehavior = false;
            this.LV_Aliado.View = System.Windows.Forms.View.Details;
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
            // LV_Inimigos
            // 
            this.LV_Inimigos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LV_Inimigos.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LV_Inimigos.FullRowSelect = true;
            this.LV_Inimigos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_Inimigos.Location = new System.Drawing.Point(456, 12);
            this.LV_Inimigos.MultiSelect = false;
            this.LV_Inimigos.Name = "LV_Inimigos";
            this.LV_Inimigos.Size = new System.Drawing.Size(144, 328);
            this.LV_Inimigos.TabIndex = 17;
            this.LV_Inimigos.UseCompatibleStateImageBehavior = false;
            this.LV_Inimigos.View = System.Windows.Forms.View.Details;
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
            // lbl_winner
            // 
            this.lbl_winner.AutoSize = true;
            this.lbl_winner.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_winner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_winner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_winner.Font = new System.Drawing.Font("Century Schoolbook", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winner.Location = new System.Drawing.Point(189, 133);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(241, 34);
            this.lbl_winner.TabIndex = 18;
            this.lbl_winner.Text = "Grupo 1 venceu";
            this.lbl_winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_winner.Visible = false;
            this.lbl_winner.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_winner_Paint);
            // 
            // Form_Battle_Random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 349);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.lbl_winner);
            this.Controls.Add(this.LV_Inimigos);
            this.Controls.Add(this.LV_Aliado);
            this.Controls.Add(this.lbl_Turno);
            this.Controls.Add(label1);
            this.Controls.Add(this.rtxt_Log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Battle_Random";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battle Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_Log;
        private System.Windows.Forms.Label lbl_Turno;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.ListView LV_Aliado;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView LV_Inimigos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbl_winner;
    }
}

