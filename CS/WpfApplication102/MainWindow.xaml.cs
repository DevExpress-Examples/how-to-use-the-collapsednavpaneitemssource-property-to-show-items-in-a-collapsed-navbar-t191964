using DevExpress.Xpf.Core;
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

namespace WpfApplication102
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<Item> items = new ObservableCollection<Item>();
            for (int i = 1; i < 4; i++)
            {
                items.Add(new Item() { ID = i, Name = "Name" + i });
            }
            this.DataContext = items;
        }
    }

    public class Item
    {
        public int ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
    }
}
