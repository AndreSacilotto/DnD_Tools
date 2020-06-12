namespace Atr_Mod_dnd5e
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
            this.nUD = new System.Windows.Forms.NumericUpDown();
            this.lbl = new System.Windows.Forms.Label();
            this.rb_Atr = new System.Windows.Forms.RadioButton();
            this.rb_Mod = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nUD)).BeginInit();
            this.SuspendLayout();
            // 
            // nUD
            // 
            this.nUD.Font = new System.Drawing.Font("Century Schoolbook", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUD.Location = new System.Drawing.Point(118, 20);
            this.nUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUD.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.nUD.Name = "nUD";
            this.nUD.Size = new System.Drawing.Size(77, 33);
            this.nUD.TabIndex = 0;
            this.nUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD.ValueChanged += new System.EventHandler(this.nUD_ValueChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(206, 17);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(84, 40);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "+XX";
            // 
            // rb_Atr
            // 
            this.rb_Atr.AutoSize = true;
            this.rb_Atr.Checked = true;
            this.rb_Atr.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Atr.Location = new System.Drawing.Point(12, 12);
            this.rb_Atr.Name = "rb_Atr";
            this.rb_Atr.Size = new System.Drawing.Size(100, 24);
            this.rb_Atr.TabIndex = 2;
            this.rb_Atr.TabStop = true;
            this.rb_Atr.Text = "Atr→Mod";
            this.rb_Atr.UseVisualStyleBackColor = true;
            // 
            // rb_Mod
            // 
            this.rb_Mod.AutoSize = true;
            this.rb_Mod.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Mod.Location = new System.Drawing.Point(12, 42);
            this.rb_Mod.Name = "rb_Mod";
            this.rb_Mod.Size = new System.Drawing.Size(100, 24);
            this.rb_Mod.TabIndex = 3;
            this.rb_Mod.Text = "Mod→Atr";
            this.rb_Mod.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 84);
            this.Controls.Add(this.rb_Mod);
            this.Controls.Add(this.rb_Atr);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.nUD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificadores";
            ((System.ComponentModel.ISupportInitialize)(this.nUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUD;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.RadioButton rb_Atr;
        private System.Windows.Forms.RadioButton rb_Mod;
    }
}

