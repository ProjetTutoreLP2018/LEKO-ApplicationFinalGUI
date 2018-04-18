namespace WindowsFormsApp1
{
    partial class EnvoieLcAuClient
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnvoieLcAuClient));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.LC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCreateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envoyer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LC,
            this.client,
            this.DateCree,
            this.NomCreateur,
            this.NomSign,
            this.envoyer});
            this.dataGridView.Location = new System.Drawing.Point(92, 15);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(644, 364);
            this.dataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(644, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Envoyer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonEnvoyer_Click);
            // 
            // LC
            // 
            this.LC.HeaderText = "Lettres de Coopérations validée en attente d\'envoie";
            this.LC.Name = "LC";
            this.LC.ReadOnly = true;
            // 
            // client
            // 
            this.client.HeaderText = "Raison social du client";
            this.client.Name = "client";
            this.client.ReadOnly = true;
            // 
            // DateCree
            // 
            this.DateCree.HeaderText = "Date de création";
            this.DateCree.Name = "DateCree";
            this.DateCree.ReadOnly = true;
            // 
            // NomCreateur
            // 
            this.NomCreateur.HeaderText = "Déchiffreuse";
            this.NomCreateur.Name = "NomCreateur";
            this.NomCreateur.ReadOnly = true;
            // 
            // NomSign
            // 
            this.NomSign.HeaderText = "Signé par";
            this.NomSign.Name = "NomSign";
            this.NomSign.ReadOnly = true;
            // 
            // envoyer
            // 
            this.envoyer.HeaderText = "Selectionner pour envoie au client";
            this.envoyer.Name = "envoyer";
            // 
            // EnvoieLcAuClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Name = "EnvoieLcAuClient";
            this.Size = new System.Drawing.Size(829, 514);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LC;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCree;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCreateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomSign;
        private System.Windows.Forms.DataGridViewCheckBoxColumn envoyer;
    }
}
