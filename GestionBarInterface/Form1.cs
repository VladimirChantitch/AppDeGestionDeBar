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

            List<Stock> stock = new List<Stock>();

            cmbSelectionTable.Items.Add("1");
            cmbSelectionTable.Items.Add("2");
            cmbSelectionTable.Items.Add("3");


            cmbSelectionCocktail.Items.Add("Tequilla sun rise");

            Stock biere = new Stock(1, "Grimbergen", 25, 3.5);
            Stock jack = new Stock(2, "Jack Daniel", 5, 7);
            Stock vodka = new Stock(3, "Poliakov", 5, 5);
            stock.Add(biere);
            stock.Add(jack);
            stock.Add(vodka);

            foreach(Stock st in stock)
            {
                cmbSelectionBiere.Items.Add($"{st.Libelle} + ({st.volume} ): + {st.prix}");
            }

            Table table = new Table(1, "table");
        }


        private void btnValiderCommande_Click(object sender, EventArgs e)
        {
            txbPrixTotal.Text = "Bien";
        }
    }
}
