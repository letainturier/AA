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
using System.Data.SqlClient;

namespace IndicateursAA
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //string connectionString = "SERVER=127.0.0.1; DATABASE=airatlantique; UID=root; PASSWORD=";
            c.cnx.Open();
            c.s = "select * from recherche1";
            SqlCommand cmd = new SqlCommand(c.s, c.cnx);
            c.dr = cmd.ExecuteReader();
            while (c.dr.Read())
            {
                comboBox1.Items.Add(c.dr[0]);
                comboBox2.Items.Add(c.dr[0]);
            }
            c.dr.Close();
            
            
        }

        Class1 c = new Class1();
        

        


        private void Rechercher_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            

        }
    }
}
