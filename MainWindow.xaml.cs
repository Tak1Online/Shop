using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnDone_Click(object sender, RoutedEventArgs e)
        {

        }
        Hleb hleb = new Hleb();
        Order order = new Order();
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (cbHleb.SelectedIndex == 0)
            {
                hleb.cost = 28;
                hleb.height = 400;
                hleb.count = Convert.ToInt32(tbCount.Text);
                hleb.Costs();
                tbRezult.Text = "Стоимость добавленного хлеба: " + hleb.summ.ToString();
                order.countOrder = Convert.ToInt32(tbCount.Text);
                order.cost = + hleb.summ;
                order.Sum();
                order.WhiteHleb();
            }
            if (cbHleb.SelectedIndex == 1)
            {
                hleb.cost = 31;
                hleb.height = 460;
                hleb.count = Convert.ToInt32(tbCount.Text);
                hleb.Costs();
                tbRezult.Text = "Стоимость добавленного хлеба: " + hleb.summ.ToString();
                order.countOrder = Convert.ToInt32(tbCount.Text);
                order.cost = + hleb.summ;
                order.Sum();
                order.BlackHleb();
            }
            tbOrder.Text = "У вас " + order.countWhite + " белого хлеба и " +  order.countBlack + " черного хлеба \n Стоимость заказа: " + order.sum;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (cbHleb.SelectedIndex == 0)
            {
                if(order.countWhite < 0) 
                {
                    order.countOrder = -Convert.ToInt32(tbCount.Text);
                    order.cost = -hleb.summ;
                    order.Sum();
                    order.WhiteHleb();
                }
                MessageBox.Show("Не может быть меньше 0");
            }
            if (cbHleb.SelectedIndex == 1)
            {
                if(order.countBlack <0)
                {
                    order.countOrder = -Convert.ToInt32(tbCount.Text);
                    order.cost = -hleb.summ;
                    order.Sum();
                    order.BlackHleb();
                }
                MessageBox.Show("Не может быть меньше 0");
            }
            tbOrder.Text = "У вас " + order.countWhite + " белого хлеба и " + order.countBlack + " черного хлеба \n Стоимость заказа: " + order.sum;
        }
    }
}
