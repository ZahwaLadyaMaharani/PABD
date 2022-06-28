using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atim_MoviesDataSet1.Table_Film' table. You can move, or remove it, as needed.
            this.table_FilmTableAdapter.Fill(this.atim_MoviesDataSet1.Table_Film);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
        }
    }
}
