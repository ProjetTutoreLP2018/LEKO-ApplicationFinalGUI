using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using WindowsFormsApp1.modele;

namespace WindowsFormsApp1
{
    public partial class CreerUtilisateur : UserControl
    {

        
        List<Droit> droits = new List<Droit>();
        Model model = new Model();

        public CreerUtilisateur()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            //Your code to run on load goes here 

            // Call the base class OnLoad to ensure any delegate event handlers are still callled

            droits = model.GetListDroit();

            foreach (Droit d in droits)
            {
                Console.WriteLine(d);
                comboDroit.Items.Add(d.Permission);
            }

            base.OnLoad(e);
        }
    }
}
