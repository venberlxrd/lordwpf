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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Image global_sender;

        public MainWindow()
        {
            InitializeComponent();
        }
        double g;
        private void Image_Drop(object sender, DragEventArgs e)
        {
            //((Image) sender).Source = e.Source as ImageSource;

            //Image image = e.Source as Image;

            //((Image)sender).Source = image.Source;

            ((Image)sender).Source = global_sender.Source;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // sender – объект, на котором произошло данное событие.
            Image lbl = sender as Image;
            global_sender = lbl;
            // Создаем источник.
            // Копируем содержимое метки Drop.
            // 1 параметр: Элемент управления, который будет источником.
            // 2 параметр: Данные, которые будут перемещаться.
            // 3 параметр: Эффект при переносе.
            DragDrop.DoDragDrop(lbl, lbl.Source, DragDropEffects.Copy);

        }

        private void Image_DragEnter(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Copy;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RotateTransform rotate = new RotateTransform(g += 90);
            image1.RenderTransform = rotate;
            image2.RenderTransform = rotate;
            image3.RenderTransform = rotate;
            image4.RenderTransform = rotate;
            image5.RenderTransform = rotate;
            image6.RenderTransform = rotate;
        }
    }
}
