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

namespace MentorJournal_v0._1
{
    /// <summary>
    /// Логика взаимодействия для AddNewParrentConferencePage.xaml
    /// </summary>
    public partial class AddNewParrentConferencePage : Page
    {
        CommonThings c = new CommonThings();

        public AddNewParrentConferencePage()
        {
            InitializeComponent();
            groupName.ItemsSource = c.groups;
        }

        private void saveConference_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            string theme = conferenceTheme.Text;
            int visited = int.Parse(howMuchVisited.Text);
            int notVisited = int.Parse(howMuchNotVisited.Text);
            int notVisitedWithReason = int.Parse(howMuchNotVisitedWithReason.Text);

            string group = groupName.SelectedItem.ToString();
            string date = conferenceDate.Text;
            string d = decision.Text;

            stringBuilder.Append($"Посетили: {visited}\nОтсутствовали: {notVisited}\nПо уважительной: {notVisitedWithReason}\nГруппа: {group}\nДата: {date}\nРешение: {d}\n");

            MessageBox.Show(stringBuilder.ToString(), theme, MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
