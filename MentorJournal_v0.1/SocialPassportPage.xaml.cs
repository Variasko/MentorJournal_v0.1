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
    /// Логика взаимодействия для SocialPassportPage.xaml
    /// </summary>
    public partial class SocialPassportPage : Page
    {
        
        CommonThings c = new CommonThings();
        
        public SocialPassportPage()
        {
            InitializeComponent();
            groupName.ItemsSource = c.groups;

        }

        private void addInvalidButton_Click(object sender, RoutedEventArgs e)
        {
            ComboBox cbFIO = new ComboBox
            {
                ItemsSource = c.name,
                SelectedIndex = 0,
                Margin = new Thickness(10, 0, 10, 10),
                HorizontalAlignment = HorizontalAlignment.Center,
                Width = 400,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                FontSize = 15
            };
            ComboBox cbStatus = new ComboBox
            { 
                ItemsSource = c.typeSocialStatus,
                SelectedIndex = 0,
                Margin = new Thickness(10, 0, 10, 10),
                HorizontalAlignment = HorizontalAlignment.Center,
                Width = 400,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                FontSize = 15
            };

            fioStack.Children.Add(cbFIO);
            statusStack.Children.Add(cbStatus);
        }

        private void saveSocialStatuses_Click(object sender, RoutedEventArgs e)
        {
            var FIOs = fioStack.Children;
            var statuses = statusStack.Children;

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < FIOs.Count; i++)
            {
                if (FIOs[i] is ComboBox fio && statuses[i] is ComboBox status)
                {
                    stringBuilder.Append($"{fio.SelectedValue} - {status.SelectedValue}\n");
                }
            }

            MessageBox.Show(stringBuilder.ToString());
        }
    }
}
