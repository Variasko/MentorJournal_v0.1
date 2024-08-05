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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MentorJournal_v0._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DropShadowEffect sideMenueElemntShadowEffect = new DropShadowEffect
        {
            Color = System.Windows.Media.Colors.Gray,
            BlurRadius = 20,
            ShadowDepth = 0

        };

        Image activeImage;
        public MainWindow()
        {
            InitializeComponent();
            activeImage = socialPassport;
            var element = sideMenu.Children;
            profole.MouseDown += sideMenuElement_MouseDown;
            foreach ( Image child in element )
            {
                child.MouseDown += sideMenuElement_MouseDown;
            }
            mainFrame.Navigate(new SocialPassportPage());
        }



        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Application a = Application.Current;
            a.Shutdown();
        }

        private void sideMenuElement_MouseDown(object sender, MouseButtonEventArgs e)
        {
            activeImage.Effect = null;
            Image img = sender as Image;
            img.Effect = sideMenueElemntShadowEffect;
            activeImage = img;
        }

        private void socialPassport_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new SocialPassportPage());
        }

        private void dormitory_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mainFrame.Navigate(new DormitoryPage());
        }
    }
}
