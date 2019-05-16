using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace SteaamNews2
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<int> AppID { get; set; } 
        public ObservableCollection<newsitem> Items { get; set; } //inotifypropetychanged  on list / binding mmvm lite/prison
        public MainWindow()
        {
            InitializeComponent();

            AppID = new ObservableCollection<int>(DataHandle.LoadIds());
            Items = new ObservableCollection<newsitem>(SteamLoadData.GetNewsByIDs(AppID.ToList()));

            AllItems.ItemsSource = Items = new ObservableCollection<newsitem>(SteamLoadData.GetNewsByIDs(AppID.ToList()));
            AllGames.ItemsSource = AppID;

            NewsWindow.Visibility = Visibility.Visible;
            GameEditWindow.Visibility = Visibility.Hidden;

            if (Items.Count()==0)
            {
                IsEmpty.Visibility = Visibility.Visible;
            }
            
        }

        private void News_Click(object sender, RoutedEventArgs e)
        {
            NewsWindow.Visibility = Visibility.Visible;
            GameEditWindow.Visibility = Visibility.Hidden;
            AllItems.ItemsSource = Items = new ObservableCollection<newsitem>(SteamLoadData.GetNewsByIDs(AppID.ToList()));
        }

        private void EditGames_Click(object sender, RoutedEventArgs e)
        {
            NewsWindow.Visibility = Visibility.Hidden;
            GameEditWindow.Visibility = Visibility.Visible;
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            
            var isNumeric = int.TryParse(GameIdInput.Text, out int n);
            if (isNumeric)
            {
                AppID.Add(n);
            }
            GameIdInput.Clear();
            DataHandle.SaveIds(AppID.ToList());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            AppID.Remove((int)button.Tag);
            DataHandle.SaveIds(AppID.ToList());
        }
    }
}
