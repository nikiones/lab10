using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab8lib;

namespace lab8
{
    public partial class CountryForm : Form
    {
        private Country TheCountry;
        internal CountryForm(Country t)
        {
            TheCountry = t;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TheCountry.Name = tbName.Text.Trim();
            TheCountry.Towns = tbTowns.Text.Trim();
            TheCountry.Population = int.Parse(tbPopulation.Text.Trim());
            TheCountry.Square = int.Parse(tbSquare.Text.Trim());
            TheCountry.HasSea = chbHasSea.Checked;
            DialogResult = DialogResult.OK; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CountryForm_Load(object sender, EventArgs e)
        {
            if(TheCountry != null)
            {
                tbName.Text = TheCountry.Name;
                tbTowns.Text = TheCountry.Towns;
                tbPopulation.Text = TheCountry.Population.ToString("");
                tbSquare.Text = TheCountry.Square.ToString("");
                chbHasSea.Checked = TheCountry.HasSea;
            }
        }

        
    }
}
