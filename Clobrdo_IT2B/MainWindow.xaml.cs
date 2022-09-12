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

namespace Clobrdo_IT2B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dice dice;

        public MainWindow()
        {
            InitializeComponent();
            dice = new Dice();
            BtnTest.Content = dice.Value.ToString();
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            dice.Throw();
            BtnTest.Content = dice.Value.ToString();
        }
    }
}
