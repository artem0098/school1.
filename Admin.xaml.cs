using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace school1
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        List<Книги> ServisList1 = Base.CarkEnt.Книги.ToList();
        List<Книги> ServisList = new List<Книги>();
        List<Книги> ClientsList = Base.CarkEnt.Книги.ToList();
        public Admin()
        {
            InitializeComponent();
            ServisList = ServisList1;
            DGServises.ItemsSource = ServisList;
            DGServises.ItemsSource = ClientsList;

        }
        int i = -1;
        private void MediaElement_Initialized(object sender, EventArgs e)
        { 
            i++;
            if (i < ServisList.Count)
            {
               
                MediaElement ME = (MediaElement)sender;
                Книги S = ServisList[i];
                Uri U = new Uri(S.Обложка, UriKind.RelativeOrAbsolute);
                ME.Source = U;

            }
        }

        private void TextBlock_Initialized(object sender, EventArgs e)
        {
            if (i < ServisList.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Книги S = ServisList[i];
                TB.Text = S.Название;

            }

        }

        private void BRed_Initialized(object sender, EventArgs e)
        {
            Button BtnRed = (Button)sender;
            if (BtnRed != null)
            {
                BtnRed.Uid = Convert.ToString(i);
            }
        }
    }
}


