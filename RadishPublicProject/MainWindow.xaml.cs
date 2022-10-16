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
using ForbiddenWordsLibrary;

namespace RadishPublicProject
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
        /// <summary>
        /// Замена слово "редиска" на звёздочки "***"
        /// </summary>
        private void ActiveButtonClick(object sender, RoutedEventArgs e)
        {
            RadishTextBox.Text = CensoreWordsClass.Censore(RadishTextBox.Text);
        }

    }
}
