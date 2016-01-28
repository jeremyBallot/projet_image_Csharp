using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace projet_IHM
{
    public partial class Form1 : Form
    {
        
        private double Zoom = 1.0;
        private System.Windows.Forms.MenuItem Zoom50;
        private System.Windows.Forms.MenuItem Zoom100;
        private System.Windows.Forms.MenuItem Zoom150;
        private System.Windows.Forms.MenuItem Zoom200;
        private System.Windows.Forms.MenuItem Zoom300;
        private System.Windows.Forms.MenuItem Zoom500;
        private System.Drawing.Bitmap m_Bitmap;
        private System.Drawing.Bitmap b_Bitmap;
        
        public FixedPanel FixedPanel { get; set; }

        public Form1()
        { // initialise le formulaire et declaration de l'image
            InitializeComponent();
            m_Bitmap = new Bitmap(2, 2);
            this.comboBox1.Enabled = false;
            this.comboBox1.SelectedIndex = 0;
            //b_Bitmap = new Bitmap(2, 2);


            
          
        }



       
        public Bitmap image
        {
            get
            {
                return (this.b_Bitmap);
            }
            set { this.b_Bitmap = value;
            }
        }

        private void enregistrerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = "c:\\";
            saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (DialogResult.OK == saveFileDialog.ShowDialog())
            {
                m_Bitmap.Save(saveFileDialog.FileName);
            }

        }

        private void OUVRIR_Click(object sender, EventArgs e)
        {// permet d'aller chercher dans nos dossier l'image souhaité
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
            //format prit en compte
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
        

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                
                m_Bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);
                b_Bitmap = (Bitmap)new Bitmap(m_Bitmap);
                this.AutoScroll = true;
                this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
                
                byte[] pixel_map = this.GetPixelMap(m_Bitmap);
                this.pictureBox2.Image = this.CreatationHistogram(pixel_map);
                // appel la fonction qui permet l'affichage de l'histogramme
                this.comboBox1.Enabled = true;
                this.Invalidate();
                this.Refresh();
            }


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        { // permet de dessiner l'image
            Graphics g = e.Graphics;

            g.DrawImage(m_Bitmap, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y, (int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom)));
            

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        { // quitte l'application
            this.Close();
        }

         private void ImgBase_Click(object sender, EventArgs e)
                {// permet de garder en mémoire l'image de base et la réafficher
                    m_Bitmap = (Bitmap) new Bitmap (b_Bitmap);
                    this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
                    this.Refresh();
             
                }
    // choix du zoom de l'image 
        private void zoom25_Click(object sender, EventArgs e)
        {   
            Zoom = .25;
            this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
            this.Invalidate();
            this.Refresh();

        }

        private void zoom_50_Click(object sender, EventArgs e)
        {
            Zoom = .5;
            this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
            this.Invalidate();
            this.Refresh();

        }

        private void zoom_100_Click(object sender, EventArgs e)
        {
            Zoom = 1.0;
            this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
            this.Invalidate();
            this.Refresh();


        }

        private void zoom_150_Click(object sender, EventArgs e)
        {
            Zoom = 1.5;
            this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
            this.Invalidate();
            this.Refresh();

        }

        private void zoom_200_Click(object sender, EventArgs e)
        {
            Zoom = 2.0;
            this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
            this.Invalidate();
            this.Refresh();

        }

        private void zoom_300_Click(object sender, EventArgs e)
        {
            Zoom = 3.0;
            this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
            this.Invalidate();
            this.Refresh();

        }

        private void zoom_500_Click(object sender, EventArgs e)
        {
            Zoom = 5;
            this.AutoScrollMinSize = new Size((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
            this.Invalidate();
            this.Refresh();

        }




        private void filtre_inverse_Click(object sender, EventArgs e)
        { // appel la classe filtres et applique le filtre inverse pour ensuite réafficher l'image dans le panel

            if (filtres.Inverve(m_Bitmap))
                this.Invalidate();
                this.Refresh();
  
        }


        private void luminosite_Click(object sender, EventArgs e)
        { // appel la boite de dialogue luminosité pour récupéré les paramètres choisit par l'utilisateur et ensuite appel 
            // la classe filtres et applique le filtre luminosité  pour ensuite réafficher l'image dans le panel

            Luminosite dlg = new Luminosite();
            dlg.nValue = 0;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                if (filtres.Luminosite(m_Bitmap, dlg.nValue))
                    this.Invalidate();
                     this.Refresh();

            }

        }
        

        private void NIveauGris_Click(object sender, EventArgs e)
        {
            if (filtres.NiveauGris(m_Bitmap))
                this.Invalidate();
            this.Refresh();
        }

        private void matrice_Click(object sender, EventArgs e)
        {
            Matrice dlg= new Matrice(m_Bitmap);
            dlg.Show();

        }

        private void Contraste_Click(object sender, EventArgs e)
        {
            Contraste dlg = new Contraste();
            dlg.nValue = 0;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                if (filtres.Contraste(m_Bitmap, (sbyte)dlg.nValue))
                    this.Invalidate();
                     this.Refresh();

            }

        }

        

        private void filtreCouleur_Click(object sender, EventArgs e)
        {
            filtreCouleur dlg = new filtreCouleur();
            dlg.rouge = dlg.vert = dlg.bleu = 0;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                if (filtres.Couleur(m_Bitmap, dlg.rouge, dlg.vert, dlg.bleu))
                    this.Invalidate();
                    this.Refresh();
            }

        }

        private void Gamma_Click(object sender, EventArgs e)
        {
            Gamma dlg = new Gamma();
            dlg.rouge = dlg.vert = dlg.bleu = 1;

            if (DialogResult.OK == dlg.ShowDialog())
            {
                if (filtres.Gamma(m_Bitmap, dlg.rouge, dlg.vert, dlg.bleu))
                    this.Invalidate();
                    this.Refresh();
            }
        }
          private void tf_Click(object sender, EventArgs e)
           {
               Fourier.fourier(m_Bitmap);
               this.Invalidate();
               this.Refresh();

                }
    

        
         private byte[] GetPixelMap(Bitmap picture)
        {   // permet de renvoyé un tableau de type byte lors de l'appel de la fonction avec pour paramètre une image
             // cette fonction est appelé a chaque changement dans le combo box afin de mettre a jour la pictureBox et afficher correctement l'histogramme
             // la fonction recupère la couleur sélectionné et renvoit un tableau contenent la couleur choisit
            int size = picture.Width * picture.Height;
            int channel_index = this.comboBox1.SelectedIndex;
            int picture_width = picture.Width;
            int picture_height = picture.Height;
            byte[] pixels_map = new byte[size];

            for (int i = 0; i < picture_height; i++)
            {
                for (int j = 0; j < picture_width; j++)
                {
                    Color color = picture.GetPixel(j, i);
                    byte color_intensity = 0;
                    switch(channel_index)
                    {
                        case 0:
                            color_intensity = color.R;
                            break;
                        case 1:
                            color_intensity = color.G;
                            break;
                        case 2:
                            color_intensity = color.B;
                            break;
                        case 3:
                            color_intensity = color.A;
                            break;
                    }

                    pixels_map[j + picture_width * i] = color_intensity;
                }
            }
            this.pictureBox2.Refresh();
            return pixels_map;
            
        }

        private Bitmap CreatationHistogram(byte[] pixel_map)
        { // cette méthode permet de récupéré le tableau de type byte qui a été generé dans la méthode précédente et d'affiché l'histogramme qui va avec la couleur du tableau
            int taille = pixel_map.Length;
            int index = this.comboBox1.SelectedIndex;
            int[] histogram = new int[256];
            int max = 0;

            for (int i = 0; i < taille; i++)
            {
                int pixel_value = pixel_map[i];
                histogram[pixel_value]++;
                if (histogram[pixel_value] > max)
                {
                    max = histogram[pixel_value];
                } 
            }

            Point[] points = new Point[Byte.MaxValue + 3];
            points[0].X = 0;
            points[0].Y = 190;

            for (int i = 0; i < Byte.MaxValue + 1; i++)
            {
                points[i + 1].X = i;
                points[i + 1].Y = Convert.ToInt32(190 - Convert.ToDouble(histogram[i]) / max * 180);
            }

            points[Byte.MaxValue + 2].X = Byte.MaxValue;
            points[Byte.MaxValue + 2].Y = 190;


            Bitmap picture_histogram = new Bitmap(300, 300);
            Graphics graphic_histogram = Graphics.FromImage(picture_histogram);
            Pen pen = new Pen(Color.Black);
            pen.Brush = new SolidBrush(Color.Black);
            graphic_histogram.FillPolygon(pen.Brush, points);
            graphic_histogram.DrawLine(pen, new Point(0, 195), new Point(260, 195));
            graphic_histogram.DrawLine(pen, new Point(255, 197), new Point(260, 195));
            graphic_histogram.DrawLine(pen, new Point(255, 193), new Point(260, 195));

            this.pictureBox2.Refresh();
            return picture_histogram;
            
            
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { // appel les différente méthode decrit précedament lors d'un changement de la couleur choisit
              if (m_Bitmap != null)
            {
                byte[] pixel_map = this.GetPixelMap(m_Bitmap);
                this.pictureBox2.Image = this.CreatationHistogram(pixel_map);
                //this.Refresh();
                
            }
            this.pictureBox2.Refresh();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.OUVRIR, "Permet d'ouvrir l'image de notre choix");
            toolTip1.SetToolTip(this.ImgBase, "permet de réafficher l'image de base sélectionné");
            toolTip1.SetToolTip(this.filtre_inverse, "permet d'appliquer un filtre inverse sur l'image");
            toolTip1.SetToolTip(this.NIveauGris, "permet de réafficher l'image en niveau de gris");
            toolTip1.SetToolTip(this.Contraste, "permet de modifier les contrastes de l'image");
            toolTip1.SetToolTip(this.Gamma, "permet d'appliquer un filtre gamma sur l'image");
            toolTip1.SetToolTip(this.filtreCouleur, "permet d'appliquer un filtre couleur");
            toolTip1.SetToolTip(this.matrice, "permet d'afficher la matrice de l'image dans un dataGridView");
            toolTip1.SetToolTip(this.tf, "permet d'appliquer la transformer de fourier ");
            toolTip1.SetToolTip(this.splitContainer1.Panel2, "Panel ou est afficher l'image");
            toolTip1.SetToolTip(this.luminosite, "permet d'éclaicir l'image");
            toolTip1.SetToolTip(this.pictureBox2, "histogramme de l'image selon la couleur choisit ci-dessus");
            toolTip1.SetToolTip(this.comboBox1, "choix de la couleur de l'image que l'on souhaite afficher dans l'histogramme");
            toolTip1.SetToolTip(this.menuStrip1, "permet d'enregistrer, quitter ou de changer la grandeur de l'image");
            
        }

        

       

        }

      


   
    }

    
            
  