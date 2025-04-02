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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace magazyn
{

    public partial class MainWindow : Window
    {
        private ObservableCollection<but> ListaProduktow = null;

        public MainWindow()
        {
            InitializeComponent();
            polaczZBaza();
        }
        public void polaczZBaza()
        {
            SQLiteConnection conn = new SQLiteConnection();
            conn.ConnectionString = @"Data Source=.\buty.db;Version=3";
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = conn;
         
            ListaProduktow = new ObservableCollection<but>();

            cmd.CommandText = "SELECT Kod, Firma, Kategoria, Nazwa, Kolor, Cena FROM buty";

            using (SQLiteDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    string kod = dr["Kod"].ToString();
                    string f = dr["Firma"].ToString();
                    string kat = dr["Kategoria"].ToString();
                    string n = dr["Nazwa"].ToString();
                    string kol = dr["Kolor"].ToString();
                    double cen;
                    if(!(double.TryParse(dr["Cena"].ToString(), out cen)))
                    {
                        cen = 0;
                    }
                    ListaProduktow.Add(new but(kod, f, kat, n, kol, cen));

                }
            }
            lstProdukty.ItemsSource = ListaProduktow;
            CollectionView widok = (CollectionView)CollectionViewSource.GetDefaultView(lstProdukty.ItemsSource);
        }

    }
}
