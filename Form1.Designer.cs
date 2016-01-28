namespace projet_IHM
{
    partial class Form1
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
        private void  InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Gamma = new System.Windows.Forms.Button();
            this.filtreCouleur = new System.Windows.Forms.Button();
            this.tf = new System.Windows.Forms.Button();
            this.Contraste = new System.Windows.Forms.Button();
            this.ImgBase = new System.Windows.Forms.Button();
            this.matrice = new System.Windows.Forms.Button();
            this.luminosite = new System.Windows.Forms.Button();
            this.NIveauGris = new System.Windows.Forms.Button();
            this.filtre_inverse = new System.Windows.Forms.Button();
            this.OUVRIR = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enregisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zOOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom_25 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom_50 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom_100 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom_150 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom_200 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom_300 = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom_500 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScrollMargin = new System.Drawing.Size(50, 0);
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.Gamma);
            this.splitContainer1.Panel1.Controls.Add(this.filtreCouleur);
            this.splitContainer1.Panel1.Controls.Add(this.tf);
            this.splitContainer1.Panel1.Controls.Add(this.Contraste);
            this.splitContainer1.Panel1.Controls.Add(this.ImgBase);
            this.splitContainer1.Panel1.Controls.Add(this.matrice);
            this.splitContainer1.Panel1.Controls.Add(this.luminosite);
            this.splitContainer1.Panel1.Controls.Add(this.NIveauGris);
            this.splitContainer1.Panel1.Controls.Add(this.filtre_inverse);
            this.splitContainer1.Panel1.Controls.Add(this.OUVRIR);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1284, 638);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rouge",
            "Vert",
            "Bleu",
            "Alpha"});
            this.comboBox1.Location = new System.Drawing.Point(0, 491);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(0, 518);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 117);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Gamma
            // 
            this.Gamma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gamma.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Gamma.ForeColor = System.Drawing.Color.White;
            this.Gamma.Location = new System.Drawing.Point(0, 148);
            this.Gamma.Name = "Gamma";
            this.Gamma.Size = new System.Drawing.Size(231, 23);
            this.Gamma.TabIndex = 5;
            this.Gamma.Text = "Filtre Gamma";
            this.Gamma.UseVisualStyleBackColor = false;
            this.Gamma.Click += new System.EventHandler(this.Gamma_Click);
            // 
            // filtreCouleur
            // 
            this.filtreCouleur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtreCouleur.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.filtreCouleur.ForeColor = System.Drawing.Color.White;
            this.filtreCouleur.Location = new System.Drawing.Point(0, 207);
            this.filtreCouleur.Name = "filtreCouleur";
            this.filtreCouleur.Size = new System.Drawing.Size(231, 23);
            this.filtreCouleur.TabIndex = 7;
            this.filtreCouleur.Text = "Filtre Couleur";
            this.filtreCouleur.UseVisualStyleBackColor = false;
            this.filtreCouleur.Click += new System.EventHandler(this.filtreCouleur_Click);
            // 
            // tf
            // 
            this.tf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tf.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tf.ForeColor = System.Drawing.Color.White;
            this.tf.Location = new System.Drawing.Point(0, 266);
            this.tf.Name = "tf";
            this.tf.Size = new System.Drawing.Size(231, 39);
            this.tf.TabIndex = 9;
            this.tf.Text = "          Transformer de Fourier (1er clic)                Transformer de Fourier" +
    " Inverse(2me clic)";
            this.tf.UseVisualStyleBackColor = false;
            this.tf.Click += new System.EventHandler(this.tf_Click);
            // 
            // Contraste
            // 
            this.Contraste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contraste.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Contraste.ForeColor = System.Drawing.Color.White;
            this.Contraste.Location = new System.Drawing.Point(0, 178);
            this.Contraste.Name = "Contraste";
            this.Contraste.Size = new System.Drawing.Size(231, 23);
            this.Contraste.TabIndex = 6;
            this.Contraste.Text = "Contraste";
            this.Contraste.UseVisualStyleBackColor = false;
            this.Contraste.Click += new System.EventHandler(this.Contraste_Click);
            // 
            // ImgBase
            // 
            this.ImgBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgBase.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ImgBase.ForeColor = System.Drawing.Color.White;
            this.ImgBase.Location = new System.Drawing.Point(3, 32);
            this.ImgBase.Name = "ImgBase";
            this.ImgBase.Size = new System.Drawing.Size(231, 23);
            this.ImgBase.TabIndex = 1;
            this.ImgBase.Text = "Image de base";
            this.ImgBase.UseVisualStyleBackColor = false;
            this.ImgBase.Click += new System.EventHandler(this.ImgBase_Click);
            // 
            // matrice
            // 
            this.matrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matrice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.matrice.ForeColor = System.Drawing.Color.White;
            this.matrice.Location = new System.Drawing.Point(0, 237);
            this.matrice.Name = "matrice";
            this.matrice.Size = new System.Drawing.Size(231, 23);
            this.matrice.TabIndex = 8;
            this.matrice.Text = "Matrice";
            this.matrice.UseVisualStyleBackColor = false;
            this.matrice.Click += new System.EventHandler(this.matrice_Click);
            // 
            // luminosite
            // 
            this.luminosite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.luminosite.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.luminosite.ForeColor = System.Drawing.Color.White;
            this.luminosite.Location = new System.Drawing.Point(0, 119);
            this.luminosite.Name = "luminosite";
            this.luminosite.Size = new System.Drawing.Size(231, 23);
            this.luminosite.TabIndex = 4;
            this.luminosite.Text = "Luminosite";
            this.luminosite.UseVisualStyleBackColor = false;
            this.luminosite.Click += new System.EventHandler(this.luminosite_Click);
            // 
            // NIveauGris
            // 
            this.NIveauGris.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NIveauGris.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NIveauGris.ForeColor = System.Drawing.Color.White;
            this.NIveauGris.Location = new System.Drawing.Point(0, 90);
            this.NIveauGris.Name = "NIveauGris";
            this.NIveauGris.Size = new System.Drawing.Size(231, 23);
            this.NIveauGris.TabIndex = 3;
            this.NIveauGris.Text = "Niveau de gris";
            this.NIveauGris.UseVisualStyleBackColor = false;
            this.NIveauGris.Click += new System.EventHandler(this.NIveauGris_Click);
            // 
            // filtre_inverse
            // 
            this.filtre_inverse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filtre_inverse.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.filtre_inverse.ForeColor = System.Drawing.Color.White;
            this.filtre_inverse.Location = new System.Drawing.Point(0, 61);
            this.filtre_inverse.Name = "filtre_inverse";
            this.filtre_inverse.Size = new System.Drawing.Size(231, 23);
            this.filtre_inverse.TabIndex = 2;
            this.filtre_inverse.Text = "Filtre inverse";
            this.filtre_inverse.UseVisualStyleBackColor = false;
            this.filtre_inverse.Click += new System.EventHandler(this.filtre_inverse_Click);
            // 
            // OUVRIR
            // 
            this.OUVRIR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OUVRIR.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.OUVRIR.FlatAppearance.BorderSize = 0;
            this.OUVRIR.ForeColor = System.Drawing.Color.White;
            this.OUVRIR.Location = new System.Drawing.Point(0, 3);
            this.OUVRIR.Name = "OUVRIR";
            this.OUVRIR.Size = new System.Drawing.Size(231, 23);
            this.OUVRIR.TabIndex = 0;
            this.OUVRIR.Text = "OUVRIR";
            this.OUVRIR.UseVisualStyleBackColor = false;
            this.OUVRIR.Click += new System.EventHandler(this.OUVRIR_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregisToolStripMenuItem,
            this.zOOMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enregisToolStripMenuItem
            // 
            this.enregisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.enregisToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.enregisToolStripMenuItem.Name = "enregisToolStripMenuItem";
            this.enregisToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.enregisToolStripMenuItem.Text = "FICHIER";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Image = global::projet_IHM.Properties.Resources.enregistrer;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.enregistrerToolStripMenuItem.Text = "enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click_1);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = global::projet_IHM.Properties.Resources.quitter;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // zOOMToolStripMenuItem
            // 
            this.zOOMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoom_25,
            this.zoom_50,
            this.zoom_100,
            this.zoom_150,
            this.zoom_200,
            this.zoom_300,
            this.zoom_500});
            this.zOOMToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.zOOMToolStripMenuItem.Name = "zOOMToolStripMenuItem";
            this.zOOMToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.zOOMToolStripMenuItem.Text = "ZOOM";
            // 
            // zoom_25
            // 
            this.zoom_25.Image = global::projet_IHM.Properties.Resources.loupe;
            this.zoom_25.Name = "zoom_25";
            this.zoom_25.Size = new System.Drawing.Size(102, 22);
            this.zoom_25.Text = "25%";
            this.zoom_25.Click += new System.EventHandler(this.zoom25_Click);
            // 
            // zoom_50
            // 
            this.zoom_50.Image = global::projet_IHM.Properties.Resources.loupe;
            this.zoom_50.Name = "zoom_50";
            this.zoom_50.Size = new System.Drawing.Size(102, 22);
            this.zoom_50.Text = "50%";
            this.zoom_50.Click += new System.EventHandler(this.zoom_50_Click);
            // 
            // zoom_100
            // 
            this.zoom_100.Image = global::projet_IHM.Properties.Resources.loupe;
            this.zoom_100.Name = "zoom_100";
            this.zoom_100.Size = new System.Drawing.Size(102, 22);
            this.zoom_100.Text = "100%";
            this.zoom_100.Click += new System.EventHandler(this.zoom_100_Click);
            // 
            // zoom_150
            // 
            this.zoom_150.Image = global::projet_IHM.Properties.Resources.loupe;
            this.zoom_150.Name = "zoom_150";
            this.zoom_150.Size = new System.Drawing.Size(102, 22);
            this.zoom_150.Text = "150%";
            this.zoom_150.Click += new System.EventHandler(this.zoom_150_Click);
            // 
            // zoom_200
            // 
            this.zoom_200.Image = global::projet_IHM.Properties.Resources.loupe;
            this.zoom_200.Name = "zoom_200";
            this.zoom_200.Size = new System.Drawing.Size(102, 22);
            this.zoom_200.Text = "200%";
            this.zoom_200.Click += new System.EventHandler(this.zoom_200_Click);
            // 
            // zoom_300
            // 
            this.zoom_300.Image = global::projet_IHM.Properties.Resources.loupe;
            this.zoom_300.Name = "zoom_300";
            this.zoom_300.Size = new System.Drawing.Size(102, 22);
            this.zoom_300.Text = "300%";
            this.zoom_300.Click += new System.EventHandler(this.zoom_300_Click);
            // 
            // zoom_500
            // 
            this.zoom_500.Image = global::projet_IHM.Properties.Resources.loupe;
            this.zoom_500.Name = "zoom_500";
            this.zoom_500.Size = new System.Drawing.Size(102, 22);
            this.zoom_500.Text = "500%";
            this.zoom_500.Click += new System.EventHandler(this.zoom_500_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1284, 662);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button NIveauGris;
        private System.Windows.Forms.Button filtre_inverse;
        private System.Windows.Forms.Button OUVRIR;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enregisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zOOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoom_25;
        private System.Windows.Forms.ToolStripMenuItem zoom_50;
        private System.Windows.Forms.ToolStripMenuItem zoom_100;
        private System.Windows.Forms.ToolStripMenuItem zoom_150;
        private System.Windows.Forms.ToolStripMenuItem zoom_200;
        private System.Windows.Forms.ToolStripMenuItem zoom_300;
        private System.Windows.Forms.ToolStripMenuItem zoom_500;
        private System.Windows.Forms.Button matrice;
        private System.Windows.Forms.Button luminosite;
        private System.Windows.Forms.Button ImgBase;
        private System.Windows.Forms.Button Contraste;
        private System.Windows.Forms.Button tf;
        private System.Windows.Forms.Button filtreCouleur;
        private System.Windows.Forms.Button Gamma;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

