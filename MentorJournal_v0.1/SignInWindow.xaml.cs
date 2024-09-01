using MentorJournal_v0._1.common;
using MentorJournal_v0._1.interfaces;
using MentorJournal_v0._1.model;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using System.IO;

namespace MentorJournal_v0._1
{
    /// <summary>
    /// Логика взаимодействия для SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {

        private MainWindow mw = new MainWindow();
        private readonly ApiConnector _apiConnector;

        public SignInWindow()
        {
            InitializeComponent();
            _apiConnector = new ApiConnector(new HttpClient());
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Application a = Application.Current;
            a.Shutdown();
        }

        private async void signIn_Click(object sender, RoutedEventArgs e)
        {

            string login = loginEnter.Text;
            string password = passwordEnter.Password;

            var mentor = await _apiConnector.GetMentorByLoginAndPasswordAsync(login, password);

            if (mentor != null)
            {
                Temp temp = new Temp
                {
                    isAdmin = false,
                    personId = mentor.PersonId
                };
                

                await WriteJsonFileAsync(temp, "current_user.json");

                mw.Show();
                Close();
            }
            else
            {
                var admin = await _apiConnector.GetAdminByLoginAndPasswordAsync(login, password);

                if (admin != null)
                {
                    Temp temp = new Temp
                    {
                        isAdmin = true,
                        personId = admin.PersonId
                    };
                
                    await WriteJsonFileAsync(temp, "current_user.json");

                    MessageBox.Show("Админ панель в разработке!", "Извините", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            
            
        }
        private async Task WriteJsonFileAsync<T>(T obj, string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(obj, options);
            await File.WriteAllTextAsync(filePath, jsonString);
        }
    }
}
