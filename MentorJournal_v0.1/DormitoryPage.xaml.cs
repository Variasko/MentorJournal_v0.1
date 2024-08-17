using MentorJournal_v0._1.common;
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
using System.Xml.Linq;

namespace MentorJournal_v0._1
{
    /// <summary>
    /// Логика взаимодействия для DormitoryPage.xaml
    /// </summary>
    public partial class DormitoryPage : Page
    {

        CommonThings c = new CommonThings();

        public DormitoryPage()
        {
            InitializeComponent();
            groupName.ItemsSource = c.groups;
        }

        private void addDormitoryLiverButton_Click(object sender, RoutedEventArgs e)
        {
            ComboBox cbFIO = new ComboBox 
            {
                ItemsSource = c.name,
                SelectedIndex = 0,
                Margin = new Thickness(10, 0, 50, 10),
                Height = 30,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                FontSize = 15,
                HorizontalAlignment = HorizontalAlignment.Center,
                Width = 400
            };
            TextBox roomBox = new TextBox
            {
                Margin = new Thickness(10, 0, 10, 10),
                Height = 30,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                FontSize = 15,
                HorizontalAlignment = HorizontalAlignment.Center,
                Width = 400
            };

            fioStack.Children.Add(cbFIO);
            roomStack.Children.Add(roomBox);
        }

        private void saveRooms_Click(object sender, RoutedEventArgs e)
        {
            var FIOs = fioStack.Children;
            var rooms = roomStack.Children;

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < FIOs.Count; i++)
            {
                if (FIOs[i] is ComboBox fio && rooms[i] is TextBox room)
                {
                    stringBuilder.Append($"{fio.SelectedValue} - {room.Text}\n");
                }
            }

            MessageBox.Show(stringBuilder.ToString());
        }
    }
}
