namespace LettreCooperation
{
    partial class PopUp_ChangeCheminDossierFINACOOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUp_ChangeCheminDossierFINACOOP));
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonParcours = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Red;
            this.buttonAnnuler.Location = new System.Drawing.Point(314, 143);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 4;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(110, 97);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(217, 20);
            this.textBoxPath.TabIndex = 1;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(107, 19);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(35, 13);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "label1";
            // 
            // buttonValider
            // 
            this.buttonValider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonValider.BackgroundImage")));
            this.buttonValider.Location = new System.Drawing.Point(405, 143);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 3;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // buttonParcours
            // 
            this.buttonParcours.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonParcours.BackgroundImage")));
            this.buttonParcours.Location = new System.Drawing.Point(336, 95);
            this.buttonParcours.Name = "buttonParcours";
            this.buttonParcours.Size = new System.Drawing.Size(75, 23);
            this.buttonParcours.TabIndex = 2;
            this.buttonParcours.Text = "Parcourir...";
            this.buttonParcours.UseVisualStyleBackColor = true;
            this.buttonParcours.Click += new System.EventHandler(this.ButtonParcours_Click);
            // 
            // PopUp_ChangeCheminDossierFINACOOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 184);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonParcours);
            this.Controls.Add(this.labelMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PopUp_ChangeCheminDossierFINACOOP";
            this.Text = "ChangePath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonParcours;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}