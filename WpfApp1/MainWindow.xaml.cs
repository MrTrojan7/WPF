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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
/*
* Одно из главных отличий WPF - в позиционировании на окне 
* Применяется идея контейнеров - элементов, которые по разному
* организовывают свои внутренние (дочерние) элементы
* В окне может быть только один элемент (обычно контейнер)б а он уже может
* 
 */
