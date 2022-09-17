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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ContainersWindow.xaml
    /// </summary>
    public partial class ContainersWindow : Window
    {
        public ContainersWindow()
        {
            InitializeComponent();
        }
        private void ButtonContainers_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click");
        }
    }
}
/*
* Одно из главных отличий WPF - в позиционировании на окне 
* Применяется идея контейнеров - элементов, которые по разному
* организовывают свои внутренние (дочерние) элементы
* 
* В окне может быть только один элемент (обычно контейнер)б а он уже может
* может содержать любое кол-во элементов, в т.ч. других контейнеров
* 
* Основные виды контейнеров
* StackPanel - "одномерная" групировка, "стопка"
*  Orientation="Horizontal" (или Vertical)
*  
*  свойства лучше ставить по алфавиту - хороший тон разметочных языков
*  
*  "+" -> самый простой контейнер по ресурсоёмкости (в т.ч. по ресурсам)
*  "-" -> обрезается, если не влазит в родительский контейнер (
* 
* WrapPanel - то же самое, что и StackPanel, но при переполнении происходит перенос элементов
* 
* DockPanel - контейнер с "притяжением" - элементы притягиваются к одной из 
* четырёх сторон (верх-низ-лево-право), при изменении размеров 
* притяжение движет элементы вместе с гранями
* 
* Применяется для сайто-подобных окон с выделенными "футером" - нижней частью,
* и правым меню
* 
* Задание: исп. док-панель сделать образ страницы сайта
* Header
* Left Content Right
* Footer
* (+ BackgroundColor)
* 
* 
* <UniformGrid Rows="3" Columns="3"> - простой контейнер с ячейками одинакового размера.
* Каждый дочерний элемент автоматически помещается в новую ячейку
* 
* <Grid> - наиболее универсальный контейнер
* каждая ячейка собирается отдельно, дочерние элементы
* должны быть явно указаны к какой ячейке они относятся. Иначе
* все они попадают в одну ячейку и перекрывают друг друга
* 
* 
*/
