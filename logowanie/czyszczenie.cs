using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logowanie
{
    public partial class czyszczenie : Form
    {
        string slowa;
        public czyszczenie()
        {
            InitializeComponent();
            string[] Wyczyszczenie = File.ReadAllLines(@"C:\Users\Michal\source\repos\logowanie\logowanie\loginytxt\loginhaslo.txt");
            string listadostringa = string.Join(Environment.NewLine, Wyczyszczenie ); //konwertuje liste do stringa //Environment.NewLine - Odstep od tekstu
            txbTXT.Text = listadostringa;
        }

        private void btnCzysc_Click(object sender, EventArgs e) 
        {
            string slowa = txbKtoraLinijka.Text;
            var linijki = txbTXT.Lines.Where(x => !String.IsNullOrWhiteSpace(x)).Count(); //liczy ile linijek jest w .txt
            MessageBox.Show(linijki.ToString());
            string line = File.ReadLines(@"C:\Users\Michal\source\repos\logowanie\logowanie\loginytxt\loginhaslo.txt").Skip(linijki - 1).Take(int.Parse(slowa)).First();
            MessageBox.Show(linijki.ToString());
            if (string.IsNullOrEmpty(slowa) || Int32.Parse(slowa) > linijki)
            {
            MessageBox.Show("Spróbuj ponownie!");
            }
            else
            {
            File.WriteAllLines(@"C:\Users\Michal\source\repos\logowanie\logowanie\loginytxt\loginhaslo.txt", File.ReadLines(@"C:\Us ers\Michal\source\repos\logowanie\logowanie\loginytxt\loginhaslo.txt").Where(l => l != line).ToList());
                MessageBox.Show("gotowe");
            }

        }

        private void txbKtoraLinijka_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
