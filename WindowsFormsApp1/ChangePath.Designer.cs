namespace LettreCooperation
{
    partial class ChangePath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePath));
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.butonParcour = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.Color.Red;
            this.buttonAnnuler.Location = new System.Drawing.Point(314, 143);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 9;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Enabled = false;
            this.textBoxPath.Location = new System.Drawing.Point(110, 97);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(217, 20);
            this.textBoxPath.TabIndex = 7;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(107, 19);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(35, 13);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "lavel1";
            // 
            // buttonValider
            // 
            this.buttonValider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonValider.BackgroundImage")));
            this.buttonValider.Location = new System.Drawing.Point(405, 143);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 8;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.ButtonValider_Click);
            // 
            // butonParcour
            // 
            this.butonParcour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butonParcour.BackgroundImage")));
            this.butonParcour.Location = new System.Drawing.Point(336, 95);
            this.butonParcour.Name = "butonParcour";
            this.butonParcour.Size = new System.Drawing.Size(75, 23);
            this.butonParcour.TabIndex = 6;
            this.butonParcour.Text = "Parcourir...";
            this.butonParcour.UseVisualStyleBackColor = true;
            this.butonParcour.Click += new System.EventHandler(this.ButonParcour_Click);
            // 
            // ChangePath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 184);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.butonParcour);
            this.Controls.Add(this.labelMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePath";
            this.Text = "ChangePath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button butonParcour;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}