namespace LettreCooperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetourClientLC));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.LC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCreateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envoyer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonEnvoyer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LC,
            this.client,
            this.DateCree,
            this.NomCreateur,
            this.NomSign,
            this.envoyer});
            this.dataGridView.Location = new System.Drawing.Point(43, 10);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(733, 364);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // LC
            // 
            this.LC.HeaderText = "Lettres de Coopérations validée en attente d\'envoie";
            this.LC.Name = "LC";
            this.LC.ReadOnly = true;
            this.LC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LC.Width = 195;
            // 
            // client
            // 
            this.client.HeaderText = "Raison social du client";
            this.client.Name = "client";
            this.client.ReadOnly = true;
            this.client.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateCree
            // 
            this.DateCree.HeaderText = "Date de création";
            this.DateCree.Name = "DateCree";
            this.DateCree.ReadOnly = true;
            this.DateCree.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NomCreateur
            // 
            this.NomCreateur.HeaderText = "Déchiffreuse";
            this.NomCreateur.Name = "NomCreateur";
            this.NomCreateur.ReadOnly = true;
            this.NomCreateur.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NomSign
            // 
            this.NomSign.HeaderText = "Signé par";
            this.NomSign.Name = "NomSign";
            this.NomSign.ReadOnly = true;
            this.NomSign.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // envoyer
            // 
            this.envoyer.HeaderText = "Selectionner pour envoie par Email au client";
            this.envoyer.Name = "envoyer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Merci de renseigner le Mot de Passe de votre adresse Email";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(389, 398);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(237, 20);
            this.textBoxPass.TabIndex = 3;
            this.textBoxPass.TextChanged += new System.EventHandler(this.TextBoxPass_TextChanged);
            // 
            // buttonEnvoyer
            // 
            this.buttonEnvoyer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEnvoyer.BackgroundImage")));
            this.buttonEnvoyer.Location = new System.Drawing.Point(661, 395);
            this.buttonEnvoyer.Name = "buttonEnvoyer";
            this.buttonEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnvoyer.TabIndex = 1;
            this.buttonEnvoyer.Text = "Envoyer";
            this.buttonEnvoyer.UseVisualStyleBackColor = true;
            this.buttonEnvoyer.Click += new System.EventHandler(this.ButtonEnvoyer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(782, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // EnvoieLcAuClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEnvoyer);
            this.Controls.Add(this.dataGridView);
            this.Name = "EnvoieLcAuClient";
            this.Size = new System.Drawing.Size(829, 514);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonEnvoyer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LC;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCree;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCreateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomSign;
        private System.Windows.Forms.DataGridViewCheckBoxColumn envoyer;
    }
}
