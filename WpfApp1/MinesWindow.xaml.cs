using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings;
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
    /// Логика взаимодействия для MinesWindow.xaml
    /// </summary>
    public partial class MinesWindow : Window
    {
        private Random rnd = new();
        public MinesWindow()
        {
            InitializeComponent();
            for (int y = 0; y < App.FIELD_SIZE_Y; y++)
            {
                for (int x = 0; x < App.FIELD_SIZE_X; x++)
                {
                    FieldLabel label = new()
                    {
                        X = x,
                        Y = y,
                        IsMine = rnd.Next(3) == 0

                    };
                    label.Content = label.IsMine ? "\x2622" : "\x0DF4";
                    label.HorizontalContentAlignment = HorizontalAlignment.Center;

                    label.Background = Brushes.Beige;
                    label.Margin = new Thickness(1);

                    // подключаем обработчик события
                    label.MouseLeftButtonUp += LabelClick;

                    // регистрируем имя для элемента
                    // по этому имени его можно будет найти (в другом коде)
                    this.RegisterName($"label_{x}_{y}", label);

                    Field.Children.Add(label);
                }
            }
        }
        /// <summary>
        /// Обработчик события нажатия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelClick(object sender, RoutedEventArgs e)
        {
            if (sender is FieldLabel label)
            {
                String[] names =
                {
                    $"label_{label.X - 1}_{label.Y - 1}",
                    $"label_{label.X - 1}_{label.Y    }",
                    $"label_{label.X - 1}_{label.Y + 1}",
                    $"label_{label.X    }_{label.Y - 1}",
                    $"label_{label.X    }_{label.Y + 1}",
                    $"label_{label.X + 1}_{label.Y - 1}",
                    $"label_{label.X + 1}_{label.Y    }",
                    $"label_{label.X + 1}_{label.Y + 1}",
                };
                int mines = 0;
                foreach (var name in names)
                {
                    if (this.FindName(name) is FieldLabel neighbour)
                    {
                        if (neighbour.IsMine)
                        {
                            mines += 1;
                        }
                        //MessageBox.Show($"X={neighbour.X}, Y={neighbour.Y}, \nMine:{neighbour.IsMine}");
                    }
                }
                MessageBox.Show(mines.ToString());
            }
        }
    }

    

    /// <summary>
    /// Класс, расширяющий Label дополнительными полями
    /// </summary>
    class FieldLabel : Label
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsMine { get; set; }
    }
    /*
     * Взаимодействие элементов
     * на примере игры Сапёр
     * Главная идея - по щелчку на ячейке поля отображается кол-во "мин", находящихся в соседних ячейках
     * 
     * 1.   Обьявляем константы, которые будут доступны во всем приложении
     * (и в коде и в разметке): в файле приложения App.xaml.cs
     * public const int FIELD_SIZE_X = 8; // размер поля по горизонтали
     * 
     * 2.   Разметка
     * <UniformGrid
     *  x:Name="Field" - имя, по которому UniformGrid будет доступен в коде
     *  Columns="{x:Static local:App.FIELD_SIZE_X}" - "обратная" связь - используем данные из кода
     *  
     * 3. Код
     *      - организовываем циклы по введенным в App константам
     *      - создаем элементы Label и добавляем их в коллекцию
     *          Field.children - дочерние элементы контейнера Field (см. UniformGrid)
     *          
     *    
     *
     *
     */
}
