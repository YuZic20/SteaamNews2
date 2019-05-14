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
        public ObservableCollection<News> Items { get; set; } //inotifypropetychanged  on list / binding mmvm lite/prison
        public MainWindow()
        {
            InitializeComponent();
            News item = new News();
            item.Title = "Novinka";
            item.Date = "23.1.2222";
            item.FeedLabel = "Fun";
            item.Autor = "pepa";
            item.NewsContent = "hskahfdasjkuhd faskdufhaskdufha usdkhflasidufhlaskdjfh asliudhfalsikudfh alskdjfgaslkjdfglaksudg fasijldgfaslkdugfsiaudk gfslakdjfgasldfg saldfg asgafadsh flasuigfazuwefba wwefg afhbaslkf ga jf ashjf ";

            Items = new ObservableCollection<News>() { item , item};


            AllItems.ItemsSource = Items;

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            News item = new News();
            item.Title = "Novinka";
            item.Date = "23.1.2222";
            item.FeedLabel = "Fun";
            item.Autor = "pepa";
            item.NewsContent = "hskahfdasjkuhd faskdufhaskdufha usdkhflasidufhlaskdjfh asliudhfalsikudfh alskdjfgaslkjdfglaksudg fasijldgfaslkdugfsiaudk gfslakdjfgasldfg saldfg asgafadsh flasuigfazuwefba wwefg afhbaslkf ga jf ashjf ";

            Items.Add(item);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Items.RemoveAt(0);
        }
    }
}
