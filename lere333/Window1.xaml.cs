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

namespace lere333
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        lereEntities context;
        public Window1(lereEntities context, Оформление newRegistration)
        {
            InitializeComponent();

            this.context = context;
            this.DataContext = newRegistration;
        }
        //public Window1(lereEntities context, Оформление curretRegistration)
        //{
        //    InitializeComponent();

        //    this.context = context;
        //    this.DataContext = curretRegistration;
        //}

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }
    }
}