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

namespace SteaamNews2
{
    /// <summary>
    /// Interakční logika pro NewsItem.xaml
    /// </summary>
    public partial class NewsItemVisual : UserControl
    {
        public string Title { get { return (string)TitleUC.Content; }set { TitleUC.Content = value; } }
        public string Date { get { return (string)DateUC.Content; } set { DateUC.Content = value; } }
        public string FeedLabel { get { return (string)FeedLabelUC.Content; } set { FeedLabelUC.Content = value; } }
        public string Autor { get { return (string)AutorUC.Content; } set { AutorUC.Content = value; } }
        public string NewsContent { get { return (string)ContentUC.Text; } set { ContentUC.Text = value; } }
        public NewsItemVisual()
        {
            InitializeComponent();
        }
    }
}
