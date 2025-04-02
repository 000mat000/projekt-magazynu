using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace magazyn
{
    /// <summary>
    /// Logika interakcji dla klasy Dodaj.xaml
    /// </summary>
    public partial class Dodaj : Window
    {
        public Dodaj()
        {
            InitializeComponent();
        }
        private void btnDodaj_Click()
        {
            try
            {
                string kod = txbKod.Text;
                string firm = txbFirma.Text;
                string kat = txbKategoria.Text;
                string naz = txbNazwa.Text;
                string kol = txbKolor.Text;
                double cen;
                if (!(double.TryParse(txbCena.Text, out cen)))
                {
                    cen = 0;
                }
                cmd

            }
            catch
            {
                MessageBox.Show("Niewłaściwe dane");
            }
        }
    }
}
