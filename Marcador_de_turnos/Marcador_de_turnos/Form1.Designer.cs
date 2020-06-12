namespace Marcador_de_turnos
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
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.txt_turnos = new System.Windows.Forms.TextBox();
            this.txt_rodadas = new System.Windows.Forms.TextBox();
            this.btn_diminui = new System.Windows.Forms.Button();
            this.txt_participantes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(26, 99);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 0;
            this.btn_Confirmar.Text = "OK";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de Participantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Turno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rodada Atual";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(369, 99);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_soma
            // 
            this.btn_soma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_soma.Location = new System.Drawing.Point(282, 99);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(30, 30);
            this.btn_soma.TabIndex = 7;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // txt_turnos
            // 
            this.txt_turnos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_turnos.Enabled = false;
            this.txt_turnos.Location = new System.Drawing.Point(212, 57);
            this.txt_turnos.Name = "txt_turnos";
            this.txt_turnos.ReadOnly = true;
            this.txt_turnos.Size = new System.Drawing.Size(100, 20);
            this.txt_turnos.TabIndex = 8;
            // 
            // txt_rodadas
            // 
            this.txt_rodadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rodadas.Enabled = false;
            this.txt_rodadas.Location = new System.Drawing.Point(355, 57);
            this.txt_rodadas.Name = "txt_rodadas";
            this.txt_rodadas.ReadOnly = true;
            this.txt_rodadas.Size = new System.Drawing.Size(100, 20);
            this.txt_rodadas.TabIndex = 9;
            // 
            // btn_diminui
            // 
            this.btn_diminui.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_diminui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diminui.Location = new System.Drawing.Point(212, 99);
            this.btn_diminui.Name = "btn_diminui";
            this.btn_diminui.Size = new System.Drawing.Size(30, 30);
            this.btn_diminui.TabIndex = 10;
            this.btn_diminui.Text = "-";
            this.btn_diminui.UseVisualStyleBackColor = true;
            this.btn_diminui.Click += new System.EventHandler(this.btn_diminui_Click);
            // 
            // txt_participantes
            // 
            this.txt_participantes.Location = new System.Drawing.Point(12, 57);
            this.txt_participantes.Name = "txt_participantes";
            this.txt_participantes.Size = new System.Drawing.Size(120, 20);
            this.txt_participantes.TabIndex = 11;
            this.txt_participantes.Text = "0";
            this.txt_participantes.Enter += new System.EventHandler(this.txt_participantes_Enter);
            this.txt_participantes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.participantes_txt_KeyPress);
            this.txt_participantes.Leave += new System.EventHandler(this.txt_participantes_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 164);
            this.Controls.Add(this.txt_participantes);
            this.Controls.Add(this.btn_diminui);
            this.Controls.Add(this.txt_rodadas);
            this.Controls.Add(this.txt_turnos);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Confirmar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcador de Turno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.TextBox txt_turnos;
        private System.Windows.Forms.TextBox txt_rodadas;
        private System.Windows.Forms.Button btn_diminui;
        private System.Windows.Forms.TextBox txt_participantes;
    }
}

