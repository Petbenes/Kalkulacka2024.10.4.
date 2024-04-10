using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulacka2024
{
    public partial class Form1 : Form
    {
        // číslo pro provedení operace
        float mflCislo1, mflCislo2;

        // potřeba smazat display
        bool mblSmazatDisplay;

        public Form1()
        {
            InitializeComponent();

            mblSmazatDisplay = false;
        }

        // -----------------------------------------
        // Vypisuje stisknutá tlačítka na display
        // -----------------------------------------
        private void btTlacitko0_Click(object sender, EventArgs e)
        {
            Button lbtMojeTlacitko;

            lbtMojeTlacitko = (Button)sender;

            // test zda je potřeba smazat display
            if (mblSmazatDisplay == true)
            {
                txtDisplay.Text = "";

                // dal nemazat
                mblSmazatDisplay = false;
            }

            // test zda tam není samotná nula
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }

            // vypsat číslo na display
            txtDisplay.Text = txtDisplay.Text + lbtMojeTlacitko.Text;
        }

        // -----------------------------------------
        // Začít sčítání
        // -----------------------------------------
        private void btSecist_Click(object sender, EventArgs e)
        {
            mflCislo1 = Convert.ToSingle(txtDisplay.Text);

            mblSmazatDisplay = true;
        }

        // -----------------------------------------
        // Vypočíst výsledek
        // -----------------------------------------
        private void btVypocet_Click(object sender, EventArgs e)
        {
            float lflVysledek;

            // načíst číslo 2
            mflCislo2 = Convert.ToSingle(txtDisplay.Text);

            // vypočítat
            lflVysledek = mflCislo1 + mflCislo2;

            // zobrazit výsledek na display
            txtDisplay.Text = lflVysledek.ToString();
        }

        // -----------------------------------------
        // Vymazat vše na kalkulačce
        // -----------------------------------------
        private void btSmazat_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
    }
}
