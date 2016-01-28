using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_IHM
{
    public partial class Luminosite : Form
    {

        public int nValue
        {
            get
            {
                return (Convert.ToInt32(Valeur.Text, 10));
            }
            set { Valeur.Text = value.ToString(); }
        }

        public Luminosite()
        {
            InitializeComponent();
            Valide.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valide_Click(object sender, EventArgs e)
        {

        }

        private void Annule_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Luminosite_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.Valeur, "entrez la luminosité voulu");
            toolTip1.SetToolTip(this.Valide, "etes-vous sur de votre valeur");

        }
    }
}
