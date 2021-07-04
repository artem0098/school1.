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

namespace school1
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        List<Service> ServiswList = Base.CarkEnt.Service.ToList();
        public Admin()
        {
            InitializeComponent();
            DGServises.ItemsSource = ServiswList;
        }
        int i = -1;
        private void MediaElement_Initialized(object sender, EventArgs e)
        {
            if (i < ServiswList.Count)
            {
                i++;
                MediaElement ME = (MediaElement)sender;
                Service S = ServiswList[i];
                Uri U = new Uri(S.MainImagePath, UriKind.RelativeOrAbsolute);
                ME.Source = U;
                //   i++;
            }
        }

        private void TextBlock_Initialized(object sender, EventArgs e)
        {
            if (i < ServiswList.Count)
            {
                TextBlock TB = (TextBlock)sender;
                Service S = ServiswList[i];
                TB.Text = S.Title;
                //  i++;
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

        private void BRed_Click(object sender, RoutedEventArgs e)
        {
            Button BtnRed = (Button)sender;
            int ind = Convert.ToInt32(BtnRed.Uid);
            Service S = ServiswList[ind];
            MessageBox.Show(S.Title);

        }

        private void StackPanel_Initialized(object sender, EventArgs e)
        {
            if (i < ServiswList.Count)
            {
                StackPanel SP = (StackPanel)sender;
                Service S = ServiswList[i];
                if (S.Discount != 0)
                {
                    SP.Background = new SolidColorBrush(Color.FromRgb(231, 250, 191));

                }
            }
        }

        private void DGServises_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BDel_Initialized(object sender, EventArgs e)
        {
            Button BtnDel = (Button)sender;
            if (BtnDel != null)
            {
                BtnDel.Uid = Convert.ToString(i);
            }
        }

        private void BDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BNew_Initialized(object sender, EventArgs e)
        {
            Button BtnNew = (Button)sender;
            if (BtnNew != null)
            {
                BtnNew.Uid = Convert.ToString(i);
            }
        }

        private void BNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_Initialized_1(object sender, EventArgs e)
        {
            if (i < ServiswList.Count)
            {
                TextBlock TBCost = (TextBlock)sender;
                Service S = ServiswList[i];
                if (S.Discount == 0)
                {
                    TBCost.Text = Convert.ToString(Math.Round(S.Cost) + "руб за " + (S.DurationInSeconds / 60) + " мин");
                }
                else
                {
                    TBCost.Text = Convert.ToString((Math.Round(S.Cost) * Math.Round((decimal)S.Discount) + Math.Round(S.Cost)) + "руб за " + (S.DurationInSeconds / 60) + " мин");
                }
            }
        }

        private void TextBlock_Initialized_2(object sender, EventArgs e)
        {
            if (i < ServiswList.Count)
            {
                TextBlock TBDis = (TextBlock)sender;
                Service S = ServiswList[i];
                
                if (S.Discount != 0)
                {
                    TBDis.Text = Convert.ToString("скидка " + S.Discount + "%");
                   

                }
            }
        }
    }
}

