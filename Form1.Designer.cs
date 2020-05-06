namespace Pa19
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
            this.labelMembre = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.dataGridViewMem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMembre
            // 
            this.labelMembre.AutoSize = true;
            this.labelMembre.Location = new System.Drawing.Point(28, 27);
            this.labelMembre.Name = "labelMembre";
            this.labelMembre.Size = new System.Drawing.Size(74, 17);
            this.labelMembre.TabIndex = 1;
            this.labelMembre.Text = "Membres :";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(6, 35);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(145, 17);
            this.labelNum.TabIndex = 3;
            this.labelNum.Text = "Numéro d\'inscriotion :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(6, 79);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(98, 17);
            this.labelNom.TabIndex = 4;
            this.labelNom.Text = "Nom complet :";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.Color.Red;
            this.buttonSupprimer.Location = new System.Drawing.Point(74, 127);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(97, 31);
            this.buttonSupprimer.TabIndex = 7;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAjouter.Location = new System.Drawing.Point(244, 127);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(97, 31);
            this.buttonAjouter.TabIndex = 8;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // dataGridViewMem
            // 
            this.dataGridViewMem.AllowUserToAddRows = false;
            this.dataGridViewMem.BackgroundColor = System.Drawing.Color.Aqua;
            this.dataGridViewMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMem.Location = new System.Drawing.Point(137, 27);
            this.dataGridViewMem.Name = "dataGridViewMem";
            this.dataGridViewMem.RowTemplate.Height = 24;
            this.dataGridViewMem.Size = new System.Drawing.Size(388, 244);
            this.dataGridViewMem.TabIndex = 9;
            this.dataGridViewMem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNom);
            this.groupBox1.Controls.Add(this.textNum);
            this.groupBox1.Controls.Add(this.labelNum);
            this.groupBox1.Controls.Add(this.labelNom);
            this.groupBox1.Controls.Add(this.buttonAjouter);
            this.groupBox1.Controls.Add(this.buttonSupprimer);
            this.groupBox1.Location = new System.Drawing.Point(137, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 194);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mise a jour :";
            // 
            // textNom
            // 
            this.textNom.BackColor = System.Drawing.Color.Bisque;
            this.textNom.Location = new System.Drawing.Point(157, 76);
            this.textNom.Multiline = true;
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(217, 36);
            this.textNom.TabIndex = 10;
            // 
            // textNum
            // 
            this.textNum.BackColor = System.Drawing.Color.Bisque;
            this.textNum.Location = new System.Drawing.Point(157, 21);
            this.textNum.Multiline = true;
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(217, 36);
            this.textNum.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(827, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelMembre);
            this.Controls.Add(this.dataGridViewMem);
            this.Name = "Form1";
            this.Text = "Gestion des Stagiaire";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMembre;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.DataGridView dataGridViewMem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textNum;
    }
}

