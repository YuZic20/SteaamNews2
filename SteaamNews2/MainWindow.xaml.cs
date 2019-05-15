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
        public List<int> AppID = DataHandle.LoadIds();
        public ObservableCollection<newsitem> Items { get; set; } //inotifypropetychanged  on list / binding mmvm lite/prison
        public MainWindow()
        {
            InitializeComponent();
            /*
            
            Newsitem item = new Newsitem();
            item.title = "Novinka";
            item.date = 254557;
            item.feedname = "Fun";
            item.author = "pepa";
            item.contents = "hskahfdasjkuhd faskdufhaskdufha usdkhflasidufhlaskdjfh asliudhfalsikudfh alskdjfgaslkjdfglaksudg fasijldgfaslkdugfsiaudk gfslakdjfgasldfg saldfg asgafadsh flasuigfazuwefba wwefg afhbaslkf ga jf ashjf ";

            Items = new ObservableCollection<Newsitem>() { item , item};

            */

            Items = new ObservableCollection<newsitem>(SteamLoadData.GetNewsByID(440, 3, 300));
            
            AllItems.ItemsSource = Items;

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*
            Newsitem item = new Newsitem();
            item.title = "Novinka";
            item.date = 5455488;
            item.feedname = "Fun";
            item.author = "pepa";
            item.contents = "hskahfdasjkuhd faskdufhaskdufha usdkhflasidufhlaskdjfh asliudhfalsikudfh alskdjfgaslkjdfglaksudg fasijldgfaslkdugfsiaudk gfslakdjfgasldfg saldfg asgafadsh flasuigfazuwefba wwefg afhbaslkf ga jf ashjf ";

            Items.Add(item);*/
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Items.RemoveAt(0);
        }
    }
}
