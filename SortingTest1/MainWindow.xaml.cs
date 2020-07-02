using System;
using System.Collections;
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

namespace SortingTest1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            sortedList.Add(int.Parse(keytxt.Text), Valuetxt.Text);
            ICollection collection = sortedList.Keys;
            string valueKey = "";
            foreach (int key in collection)
            {
                valueKey = valueKey + "\n" + key + " : " + sortedList[key].ToString();
            }
            MessageBox.Show("Count : " + collection.Count.ToString() + "\n"+"Data at below " + valueKey);
            //MessageBox.Show("Count = : " + collection.Count + valueKey + " ");
        }
    }
}
