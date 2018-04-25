namespace LettreCooperation
{
    partial class SignatureExp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignatureExp));
            this.LCDataGridView = new System.Windows.Forms.DataGridView();
            this.nom_LC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_Création = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dechiffreuse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectionner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LCDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LCDataGridView
            // 
            this.LCDataGridView.AllowUserToAddRows = false;
            this.LCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LCDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom_LC,
            this.nom_client,
            this.date_Création,
            this.dechiffreuse,
            this.selectionner});
            this.LCDataGridView.Location = new System.Drawing.Point(48, 9);
            this.LCDataGridView.Name = "LCDataGridView";
            this.LCDataGridView.Size = new System.Drawing.Size(721, 364);
            this.LCDataGridView.TabIndex = 0;
            this.LCDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LCDataGridView_CellContentClick);
            // 
            // nom_LC
            // 
            this.nom_LC.HeaderText = "Lettres de Coopérations validée en attente d\'envoie";
            this.nom_LC.Name = "nom_LC";
            this.nom_LC.ReadOnly = true;
            this.nom_LC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nom_LC.Width = 280;
            // 
            // nom_client
            // 
            this.nom_client.HeaderText = "Raison social du client";
            this.nom_client.Name = "nom_client";
            this.nom_client.ReadOnly = true;
            this.nom_client.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // date_Création
            // 
            this.date_Création.HeaderText = "Date Création";
            this.date_Création.Name = "date_Création";
            this.date_Création.ReadOnly = true;
            this.date_Création.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dechiffreuse
            // 
            this.dechiffreuse.HeaderText = "Déchiffreuse";
            this.dechiffreuse.Name = "dechiffreuse";
            this.dechiffreuse.ReadOnly = true;
            this.dechiffreuse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // selectionner
            // 
            this.selectionner.HeaderText = "Selectionner pour signer et valider la Lettre de coopération";
            this.selectionner.Name = "selectionner";
            this.selectionner.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(596, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Signer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonSigner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Merci de renseigner le Mot de Passe sur cette application";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(414, 389);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(176, 20);
            this.textBoxPass.TabIndex = 4;
            this.textBoxPass.TextChanged += new System.EventHandler(this.TextBoxPass_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(775, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // SignatureExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LCDataGridView);
            this.Name = "SignatureExp";
            this.Size = new System.Drawing.Size(829, 514);
            ((System.ComponentModel.ISupportInitialize)(this.LCDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LCDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_LC;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_Création;
        private System.Windows.Forms.DataGridViewTextBoxColumn dechiffreuse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectionner;
    }
}
