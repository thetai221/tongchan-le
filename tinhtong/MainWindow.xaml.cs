using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void huy_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void r1_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void rc_Checked(object sender, RoutedEventArgs e)
        {
          
        }

        private void rl_Checked(object sender, RoutedEventArgs e)
        {

           
        }

        private void btntong_Click(object sender, RoutedEventArgs e)
        {
            double n = Double.Parse(txtn.Text);
            txtdapan.Text = tong(n).ToString();
        }

        public double tong(double n)
        {
            int nhap = Convert.ToInt32(txtn.Text);
            int tongday = 0;
            for (int i = 0; i <= nhap; i++)
            {
                tongday = tongday + i;
            }
            txtdapan.Text = tongday.ToString();
            return tongday;
        }

        private void btntongle_Click(object sender, RoutedEventArgs e)
        {
            double n = Double.Parse(txtn.Text);
            txtdapan.Text = tongl(n).ToString();
        }

        public double tongl(double n)
        {
            int nhap = Convert.ToInt32(txtn.Text);
            int tongle = 0;
            for (int i = 0; i <= nhap; i++)
                if (i % 2 != 0)
                {
                    tongle += i;
                    
                }
            txtdapan.Text = tongle.ToString();
            return tongle;
        }

        private void btntongchan_Click(object sender, RoutedEventArgs e)
        {
            double n = Double.Parse(txtn.Text);
            txtdapan.Text = tongc(n).ToString();
        }

        public double tongc(double n)
        {
            int nhap = Convert.ToInt32(txtn.Text);
            int tongchan = 0;
            for (int i = 0; i <= nhap; i++)
                if (i % 2 == 0)
                {
                    tongchan += i;

                }
            txtdapan.Text = tongchan.ToString();
            return tongchan;
        }
    }
}