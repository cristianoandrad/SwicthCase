namespace SwicthCase
{
    partial class Form2
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOpcao = new System.Windows.Forms.ComboBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(166, 180);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 43);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(255, 180);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(99, 43);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Exemplo Anterior";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(73, 180);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 43);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rodízio de Veículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o final da placa";
            // 
            // cboOpcao
            // 
            this.cboOpcao.FormattingEnabled = true;
            this.cboOpcao.Items.AddRange(new object[] {
            "1 ou 2",
            "3 ou 4",
            "5 ou 6",
            "7 ou 8",
            "9 ou 0"});
            this.cboOpcao.Location = new System.Drawing.Point(144, 91);
            this.cboOpcao.Name = "cboOpcao";
            this.cboOpcao.Size = new System.Drawing.Size(121, 21);
            this.cboOpcao.TabIndex = 5;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(103, 135);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 277);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.cboOpcao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSair);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboOpcao;
        private System.Windows.Forms.Label lblRes;
    }
}