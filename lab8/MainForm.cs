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
    public partial class MainForm : Form
    {
        private BindingList<Country> countrys = new BindingList<Country>();
        public MainForm()
        {
            InitializeComponent();
            lbCountryInfo.DataSource = countrys;
            lbCountryInfo.DisplayMember = "Name";
            lbCountryInfo.ValueMember = "Towns";
            lbCountryInfo.SelectedIndexChanged += new EventHandler(lbCountryInfo_SelectedIndexChanged);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Country country = new Country();

            CountryForm fp = new CountryForm(country);

            if (fp.ShowDialog() == DialogResult.OK)
            {
                countrys.Add(country);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void lbCountryInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country country = (Country)lbCountryInfo.SelectedItem;
            MessageBox.Show(lbCountryInfo.Text += string.Format("Имя: {0}| Кол-во городов:{1}| Кол-во населения:{2}| Площадь(кв.км.):{3} ({4})", country.Name, country.Towns, country.Population, country.Square, country.HasSea ? "Омывается морями" : "Не омывается морями"));
        }
    }
}
