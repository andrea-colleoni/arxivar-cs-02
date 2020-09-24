using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_ef_forms
{
    public partial class Form1 : Form
    {
        private Database db = new Database();

        public Form1()
        {
            InitializeComponent();
            this.cittaBindingSource.DataSource = db.Citta.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var citta = db.Citta.OrderBy(c => c.Nome).First();
            MessageBox.Show(citta.OggettoRegione.Paese);
        }
    }
}
