namespace Formulaires_prestations
{
    partial class FormSaisieJoursPrestees
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
            this.Utilisateur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxListUtilisateur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNomProjet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DateSaisieJP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTrancheJour = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Utilisateur
            // 
            this.Utilisateur.AutoSize = true;
            this.Utilisateur.Location = new System.Drawing.Point(12, 74);
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.Size = new System.Drawing.Size(59, 13);
            this.Utilisateur.TabIndex = 0;
            this.Utilisateur.Text = "Utilisateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "saisie Jours prestées";
            // 
            // comboBoxListUtilisateur
            // 
            this.comboBoxListUtilisateur.FormattingEnabled = true;
            this.comboBoxListUtilisateur.Location = new System.Drawing.Point(77, 74);
            this.comboBoxListUtilisateur.Name = "comboBoxListUtilisateur";
            this.comboBoxListUtilisateur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListUtilisateur.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Projet : ";
            // 
            // comboBoxNomProjet
            // 
            this.comboBoxNomProjet.FormattingEnabled = true;
            this.comboBoxNomProjet.Location = new System.Drawing.Point(77, 155);
            this.comboBoxNomProjet.Name = "comboBoxNomProjet";
            this.comboBoxNomProjet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNomProjet.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "date :";
            // 
            // DateSaisieJP
            // 
            this.DateSaisieJP.Location = new System.Drawing.Point(280, 75);
            this.DateSaisieJP.Name = "DateSaisieJP";
            this.DateSaisieJP.Size = new System.Drawing.Size(200, 20);
            this.DateSaisieJP.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "tranche Journaliere :";
            // 
            // comboBoxTrancheJour
            // 
            this.comboBoxTrancheJour.FormattingEnabled = true;
            this.comboBoxTrancheJour.Items.AddRange(new object[] {
            "0,25",
            "0,50",
            "0,75",
            "1,00"});
            this.comboBoxTrancheJour.Location = new System.Drawing.Point(381, 155);
            this.comboBoxTrancheJour.Name = "comboBoxTrancheJour";
            this.comboBoxTrancheJour.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrancheJour.TabIndex = 8;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(592, 155);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(110, 23);
            this.btnValider.TabIndex = 9;
            this.btnValider.Text = "Valider...";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // FormSaisieJoursPrestees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 559);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.comboBoxTrancheJour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateSaisieJP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxNomProjet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxListUtilisateur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Utilisateur);
            this.Name = "FormSaisieJoursPrestees";
            this.Text = "FormSaisieJoursPrestees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Utilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxListUtilisateur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNomProjet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateSaisieJP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTrancheJour;
        private System.Windows.Forms.Button btnValider;
    }
}