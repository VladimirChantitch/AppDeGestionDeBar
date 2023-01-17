using GestionBarInterface.bar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBarInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbSelectionTable.Items.Add("1");
            cmbSelectionTable.Items.Add("2");
            cmbSelectionTable.Items.Add("3");

            cmbSelectionBiere.Items.Add("Grimbergen");

            cmbSelectionCocktail.Items.Add("Tequilla sun rise");

            Table table = new Table(1, "table");
        }


        private void btnValiderCommande_Click(object sender, EventArgs e)
        {
            txbPrixTotal.Text = "Bien";
        }
    }
}
