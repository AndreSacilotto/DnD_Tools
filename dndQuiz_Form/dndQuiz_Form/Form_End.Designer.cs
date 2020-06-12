namespace dndQuiz_Form
{
    partial class Form_End
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_End));
            this.picB_Image = new System.Windows.Forms.PictureBox();
            this.txt_Classe = new System.Windows.Forms.TextBox();
            this.txt_subClasse = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Image)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picB_Image
            // 
            this.picB_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picB_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picB_Image.Image = global::dndQuiz_Form.Properties.Resources.Barbaro;
            this.picB_Image.Location = new System.Drawing.Point(12, 12);
            this.picB_Image.Name = "picB_Image";
            this.picB_Image.Size = new System.Drawing.Size(323, 333);
            this.picB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB_Image.TabIndex = 0;
            this.picB_Image.TabStop = false;
            // 
            // txt_Classe
            // 
            this.txt_Classe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Classe.Cursor = System.Windows.Forms.Cursors.Help;
            this.txt_Classe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Classe.Location = new System.Drawing.Point(10, 26);
            this.txt_Classe.Name = "txt_Classe";
            this.txt_Classe.ReadOnly = true;
            this.txt_Classe.Size = new System.Drawing.Size(129, 21);
            this.txt_Classe.TabIndex = 1;
            this.txt_Classe.Text = "Feiticeiro";
            this.txt_Classe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_subClasse
            // 
            this.txt_subClasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_subClasse.Cursor = System.Windows.Forms.Cursors.Help;
            this.txt_subClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subClasse.Location = new System.Drawing.Point(7, 26);
            this.txt_subClasse.Name = "txt_subClasse";
            this.txt_subClasse.ReadOnly = true;
            this.txt_subClasse.Size = new System.Drawing.Size(194, 21);
            this.txt_subClasse.TabIndex = 2;
            this.txt_subClasse.Text = "Caminho dos Quatro Elementos";
            this.txt_subClasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Classe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(341, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_subClasse);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(341, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 59);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SubClasse";
            // 
            // Form_End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 338);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picB_Image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_End";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_End";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_End_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picB_Image)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picB_Image;
        private System.Windows.Forms.TextBox txt_Classe;
        private System.Windows.Forms.TextBox txt_subClasse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}