
using System;
using System.Windows;
using System.Windows.Controls;

namespace NY_Pizza
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object label1PizzaDescription;
        private object labelPrice;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string customerName = "",
                    pizzaName = " Cheese Pizza ";
            double totalPrice = 9.99;
            Pizza myPizza = new Pizza(pizzaName, totalPrice);
            int controlNum = GetRadioButton();
            totalPrice = myPizza.GetPrice(controlNum);
            customerName = textBox.Text;

            //label
            labelOrder.Content = customerName;
            label1PizzaDescription.Content = myPizza.GetName();
            labelPrice.Content = totalPrice;


        }

        private int GetRadioButton()
        {
            int control = 0;

            if (rbPepperoni == true)
            {
                control = 1;
            }
            if (rbPineapple.IsChecked == true)
            {
                control = 3;
            }
            return control;
        }
    }

}
