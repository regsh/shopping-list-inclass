using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for AddItemControl.xaml
    /// </summary>
    public partial class AddItemControl : UserControl
    {
        public AddItemControl()
        {
            InitializeComponent();
            AddItemButton.Click += OnAddItemButtonClick;
        }

        protected void OnAddItemButtonClick(object sender, RoutedEventArgs e)
        {
            var item = ItemToAdd.Text;
            /*
            var data = (ShoppingListData)DataContext; //casting operator 1 (throws exception if cannot cast) wrap in try-catch block
            var data2 = DataContext as ShoppingListData;  //casting operator 2 (resolves to null if cannot cast) if silent failure is desired
            if(data2 != null)
            {
                //safe to work with data2
            }

            if(DataContext is ShoppingListData data3)
            {
                //evaluates to boolean, checks typeof; another way to check casting
                //if evaluates to true, sets data3
                //BUT data3 only exists inside this block
            }
            */
            if(DataContext is ShoppingListData data)
            {
                data.Add(ItemToAdd.Text);
                ItemToAdd.Text = "";
            }


        }
    }
}
