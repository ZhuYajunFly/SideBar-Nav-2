using SideBar_Nav.Pages;
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

namespace SideBar_Nav
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            page1 = new Page1();
            page2 = new Page2();
            page3 = new Page3();
            page4 = new Page4();
        }

        Page1 page1;
        Page2 page2;
        Page3 page3;
        Page4 page4;
        private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var selected = sidebar.SelectedItem as NavButton;

            if (selected == null) { return; }

            if (selected.Content.ToString()=="Page1")
            {
                navframe.Navigate(page1);
                return;
            }

            if (selected.Content.ToString() == "Page2")
            {
                navframe.Navigate(page2);
                return;
            }

            if (selected.Content.ToString() == "Page3")
            {
                navframe.Navigate(page3);
                return;
            }

            if (selected.Content.ToString() == "Page4")
            {
                navframe.Navigate(page4);
                return;
            }


        }
    }
}
  