namespace projet_IHM
{
    partial class Luminosite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Valeur = new System.Windows.Forms.TextBox();
            this.Valide = new System.Windows.Forms.Button();
            this.Annule = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "taper la luminosité ";
            // 
            // Valeur
            // 
            this.Valeur.Location = new System.Drawing.Point(154, 35);
            this.Valeur.Name = "Valeur";
            this.Valeur.Size = new System.Drawing.Size(100, 20);
            this.Valeur.TabIndex = 1;
            this.Valeur.Text = "Valeur";
            this.Valeur.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Valide
            // 
            this.Valide.Location = new System.Drawing.Point(42, 79);
            this.Valide.Name = "Valide";
            this.Valide.Size = new System.Drawing.Size(75, 23);
            this.Valide.TabIndex = 2;
            this.Valide.Text = "Validé";
            this.Valide.UseVisualStyleBackColor = true;
            this.Valide.Click += new System.EventHandler(this.Valide_Click);
            // 
            // Annule
            // 
            this.Annule.Location = new System.Drawing.Point(154, 78);
            this.Annule.Name = "Annule";
            this.Annule.Size = new System.Drawing.Size(75, 23);
            this.Annule.TabIndex = 3;
            this.Annule.Text = "Annulé";
            this.Annule.UseVisualStyleBackColor = true;
            this.Annule.Click += new System.EventHandler(this.Annule_Click);
            // 
            // Luminosite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 114);
            this.Controls.Add(this.Annule);
            this.Controls.Add(this.Valide);
            this.Controls.Add(this.Valeur);
            this.Controls.Add(this.label1);
            this.Name = "Luminosite";
            this.Text = "Brightness";
            this.Load += new System.EventHandler(this.Luminosite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Valeur;
        private System.Windows.Forms.Button Valide;
        private System.Windows.Forms.Button Annule;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}