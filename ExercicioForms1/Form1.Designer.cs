namespace ExercicioForms1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nomeCompleto = new System.Windows.Forms.TextBox();
            this.textBox_listaNomes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo";
            // 
            // textBox_nomeCompleto
            // 
            this.textBox_nomeCompleto.Location = new System.Drawing.Point(126, 12);
            this.textBox_nomeCompleto.Name = "textBox_nomeCompleto";
            this.textBox_nomeCompleto.Size = new System.Drawing.Size(514, 23);
            this.textBox_nomeCompleto.TabIndex = 1;
            // 
            // textBox_listaNomes
            // 
            this.textBox_listaNomes.Location = new System.Drawing.Point(98, 103);
            this.textBox_listaNomes.Multiline = true;
            this.textBox_listaNomes.Name = "textBox_listaNomes";
            this.textBox_listaNomes.ReadOnly = true;
            this.textBox_listaNomes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_listaNomes.Size = new System.Drawing.Size(542, 262);
            this.textBox_listaNomes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista dos nomes já cadastrados";
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(481, 41);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 4;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(565, 41);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_listaNomes);
            this.Controls.Add(this.textBox_nomeCompleto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro de Pessoas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_nomeCompleto;
        private TextBox textBox_listaNomes;
        private Label label2;
        private Button btn_inserir;
        private Button btn_limpar;
    }
}