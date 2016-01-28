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
    public partial class Contraste : Form
    { 
        public int nValue
        {
            get
            {
                return (Convert.ToInt32(Valeur.Text, 10));
            }
            set { Valeur.Text = value.ToString(); }
        }
    
        public Contraste()
        {
            InitializeComponent();
            Valide.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Contraste_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.Valeur, "entrez la valeur du contraste voulu");
     
            toolTip1.SetToolTip(this.Valide, "etes-vous sur de vos valeurs");

        }

        private void Annule_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
      } 
}
