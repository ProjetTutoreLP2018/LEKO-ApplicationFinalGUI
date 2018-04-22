namespace LettreCooperation
{
    partial class FenPreRemplissageAutomatique
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
            this.label2 = new System.Windows.Forms.Label();
            this.ListeChoixEntreprises = new System.Windows.Forms.ListBox();
            this.MotsCles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoutonRechercher = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Résultats :";
            // 
            // ListeChoixEntreprises
            // 
            this.ListeChoixEntreprises.FormattingEnabled = true;
            this.ListeChoixEntreprises.Location = new System.Drawing.Point(12, 86);
            this.ListeChoixEntreprises.Name = "ListeChoixEntreprises";
            this.ListeChoixEntreprises.Size = new System.Drawing.Size(535, 160);
            this.ListeChoixEntreprises.TabIndex = 35;
            this.ListeChoixEntreprises.DoubleClick += new System.EventHandler(this.ListeChoixEntreprises_DoubleClick);
            // 
            // MotsCles
            // 
            this.MotsCles.Location = new System.Drawing.Point(80, 12);
            this.MotsCles.Name = "MotsCles";
            this.MotsCles.Size = new System.Drawing.Size(370, 22);
            this.MotsCles.TabIndex = 33;
            this.MotsCles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MotsCles_KeyDownAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mots-clés : ";
            // 
            // BoutonRechercher
            // 
            this.BoutonRechercher.Location = new System.Drawing.Point(457, 13);
            this.BoutonRechercher.Name = "BoutonRechercher";
            this.BoutonRechercher.Size = new System.Drawing.Size(90, 23);
            this.BoutonRechercher.TabIndex = 37;
            this.BoutonRechercher.Text = "Rechercher";
            this.BoutonRechercher.UseVisualStyleBackColor = true;
            this.BoutonRechercher.Click += new System.EventHandler(this.BoutonRechercher_ClickAsync);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Par exemple : FINACOOP PARIS";
            // 
            // FenPreRemplissageAutomatique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 258);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoutonRechercher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListeChoixEntreprises);
            this.Controls.Add(this.MotsCles);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FenPreRemplissageAutomatique";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Assistant de pré-remplissage automatique";
            this.Load += new System.EventHandler(this.FenSelectionEntreprise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListeChoixEntreprises;
        private System.Windows.Forms.TextBox MotsCles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BoutonRechercher;
        private System.Windows.Forms.Label label3;
    }
}