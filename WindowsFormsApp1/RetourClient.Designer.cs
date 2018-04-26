namespace LettreCooperation
{
    partial class RetourClientLC
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetourClientLC));
            this.cbChoixClient = new System.Windows.Forms.ComboBox();
            this.cbChoixLcDuClient = new System.Windows.Forms.ComboBox();
            this.lblChoixClient = new System.Windows.Forms.Label();
            this.lblChoixLcDuClient = new System.Windows.Forms.Label();
            this.btnArchiverLC = new System.Windows.Forms.Button();
            this.btnRefuserLC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbChoixClient
            // 
            this.cbChoixClient.FormattingEnabled = true;
            this.cbChoixClient.Location = new System.Drawing.Point(212, 19);
            this.cbChoixClient.Name = "cbChoixClient";
            this.cbChoixClient.Size = new System.Drawing.Size(161, 21);
            this.cbChoixClient.TabIndex = 0;
            this.cbChoixClient.SelectedIndexChanged += new System.EventHandler(this.CbChoixClient_SelectedIndexChanged);
            // 
            // cbChoixLcDuClient
            // 
            this.cbChoixLcDuClient.FormattingEnabled = true;
            this.cbChoixLcDuClient.Location = new System.Drawing.Point(212, 71);
            this.cbChoixLcDuClient.Name = "cbChoixLcDuClient";
            this.cbChoixLcDuClient.Size = new System.Drawing.Size(300, 21);
            this.cbChoixLcDuClient.TabIndex = 1;
            this.cbChoixLcDuClient.SelectedIndexChanged += new System.EventHandler(this.CbChoixLcDuClient_SelectedIndexChanged);
            // 
            // lblChoixClient
            // 
            this.lblChoixClient.AutoSize = true;
            this.lblChoixClient.Location = new System.Drawing.Point(33, 28);
            this.lblChoixClient.Name = "lblChoixClient";
            this.lblChoixClient.Size = new System.Drawing.Size(82, 13);
            this.lblChoixClient.TabIndex = 2;
            this.lblChoixClient.Text = "Choix du client :";
            // 
            // lblChoixLcDuClient
            // 
            this.lblChoixLcDuClient.AutoSize = true;
            this.lblChoixLcDuClient.Location = new System.Drawing.Point(33, 73);
            this.lblChoixLcDuClient.Name = "lblChoixLcDuClient";
            this.lblChoixLcDuClient.Size = new System.Drawing.Size(173, 13);
            this.lblChoixLcDuClient.TabIndex = 3;
            this.lblChoixLcDuClient.Text = "Choix de la Lettre de Coopération : ";
            // 
            // btnArchiverLC
            // 
            this.btnArchiverLC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnArchiverLC.BackgroundImage")));
            this.btnArchiverLC.Location = new System.Drawing.Point(214, 182);
            this.btnArchiverLC.Name = "btnArchiverLC";
            this.btnArchiverLC.Size = new System.Drawing.Size(75, 23);
            this.btnArchiverLC.TabIndex = 4;
            this.btnArchiverLC.Text = "Archiver";
            this.btnArchiverLC.UseVisualStyleBackColor = true;
            this.btnArchiverLC.Click += new System.EventHandler(this.BtnArchiverLC_Click);
            // 
            // btnRefuserLC
            // 
            this.btnRefuserLC.BackColor = System.Drawing.Color.Red;
            this.btnRefuserLC.Location = new System.Drawing.Point(391, 182);
            this.btnRefuserLC.Name = "btnRefuserLC";
            this.btnRefuserLC.Size = new System.Drawing.Size(75, 23);
            this.btnRefuserLC.TabIndex = 8;
            this.btnRefuserLC.Text = "Refuser";
            this.btnRefuserLC.UseVisualStyleBackColor = false;
            this.btnRefuserLC.Click += new System.EventHandler(this.btnRefuserLC_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblChoixLcDuClient);
            this.groupBox1.Controls.Add(this.cbChoixClient);
            this.groupBox1.Controls.Add(this.lblChoixClient);
            this.groupBox1.Controls.Add(this.cbChoixLcDuClient);
            this.groupBox1.Location = new System.Drawing.Point(47, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 145);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // RetourClientLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 247);
            this.Controls.Add(this.btnRefuserLC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnArchiverLC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RetourClientLC";
            this.Text = "Gestion des retours client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChoixClient;
        private System.Windows.Forms.ComboBox cbChoixLcDuClient;
        private System.Windows.Forms.Label lblChoixClient;
        private System.Windows.Forms.Label lblChoixLcDuClient;
        private System.Windows.Forms.Button btnArchiverLC;
        private System.Windows.Forms.Button btnRefuserLC;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

