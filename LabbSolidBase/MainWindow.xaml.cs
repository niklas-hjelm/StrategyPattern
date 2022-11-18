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
using LabbSolidBase.Strategy;
using LabbSolidBase.Strategy.Interfaces;

namespace LabbSolidBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IContext _sortingContext;
        public MainWindow()
        {
            _sortingContext = new StrategyContext(new BubbleSortStrategy());
            InitializeComponent();
        }

        private void SortBtn_OnClick(object sender, RoutedEventArgs e)
        {
            SortedList.Items.Clear();

            var arr = InputText.Text.Split(new char[]{',', ' ', ';'});

            var intArr = new int[arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                int.TryParse(arr[i], out intArr[i]);
            }

            //Executes the selected sorting algorithm
            _sortingContext.Execute(ref intArr);

            foreach (var item in intArr)
                SortedList.Items.Add(item);

        }

        private void SortingAlgorithm_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedMethod = ((ComboBoxItem)SortingAlgorithm.SelectedItem).Content.ToString();

            //Sets the desired sorting algorithm when the value in the combobox changes
            _sortingContext.SetStrategy(
                (selectedMethod) switch
                {
                    "Bubble Sort" => new BubbleSortStrategy(),
                    "Quick Sort" => new QuickSortStrategy(),
                    "Heap Sort" => new HeapSortStrategy(),
                    _ => throw new NotImplementedException()
                }
            );
        }
    }
}
