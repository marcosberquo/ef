namespace WindowsFormsApp1
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
            this.bntTestar = new System.Windows.Forms.Button();
            this.txtStrCon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkListTabelas = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGerarClasses = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPastaDestino = new System.Windows.Forms.TextBox();
            this.btnPasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntTestar
            // 
            this.bntTestar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bntTestar.Location = new System.Drawing.Point(15, 89);
            this.bntTestar.Name = "bntTestar";
            this.bntTestar.Size = new System.Drawing.Size(95, 25);
            this.bntTestar.TabIndex = 7;
            this.bntTestar.Text = "Conectar";
            this.bntTestar.UseVisualStyleBackColor = true;
            this.bntTestar.Click += new System.EventHandler(this.bntTestar_Click);
            // 
            // txtStrCon
            // 
            this.txtStrCon.Location = new System.Drawing.Point(12, 29);
            this.txtStrCon.Multiline = true;
            this.txtStrCon.Name = "txtStrCon";
            this.txtStrCon.Size = new System.Drawing.Size(509, 54);
            this.txtStrCon.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "String de conexão";
            // 
            // chkListTabelas
            // 
            this.chkListTabelas.CheckOnClick = true;
            this.chkListTabelas.FormattingEnabled = true;
            this.chkListTabelas.Location = new System.Drawing.Point(12, 144);
            this.chkListTabelas.Name = "chkListTabelas";
            this.chkListTabelas.Size = new System.Drawing.Size(299, 94);
            this.chkListTabelas.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tabelas";
            // 
            // btnGerarClasses
            // 
            this.btnGerarClasses.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGerarClasses.Location = new System.Drawing.Point(398, 283);
            this.btnGerarClasses.Name = "btnGerarClasses";
            this.btnGerarClasses.Size = new System.Drawing.Size(123, 37);
            this.btnGerarClasses.TabIndex = 28;
            this.btnGerarClasses.Text = "Gerar classes";
            this.btnGerarClasses.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Pasta destino";
            // 
            // txtPastaDestino
            // 
            this.txtPastaDestino.Location = new System.Drawing.Point(12, 257);
            this.txtPastaDestino.Name = "txtPastaDestino";
            this.txtPastaDestino.Size = new System.Drawing.Size(509, 20);
            this.txtPastaDestino.TabIndex = 30;
            // 
            // btnPasta
            // 
            this.btnPasta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPasta.Location = new System.Drawing.Point(15, 283);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(123, 25);
            this.btnPasta.TabIndex = 31;
            this.btnPasta.Text = "Selecionar pasta";
            this.btnPasta.UseVisualStyleBackColor = true;
            this.btnPasta.Click += new System.EventHandler(this.btnPasta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 346);
            this.Controls.Add(this.btnPasta);
            this.Controls.Add(this.txtPastaDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGerarClasses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkListTabelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntTestar);
            this.Controls.Add(this.txtStrCon);
            this.Name = "Form1";
            this.Text = "Entity Framework Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntTestar;
        private System.Windows.Forms.TextBox txtStrCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkListTabelas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGerarClasses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtPastaDestino;
        private System.Windows.Forms.Button btnPasta;
    }
}

