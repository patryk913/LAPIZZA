using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinForms.SQLite;
using XamarinForms.SQLite.SQLite;
using System.Diagnostics;
using Java.IO;

namespace LAPIZZA
{
    public partial class OrderPage : ContentPage
    {
        private SQLiteConnection _sqLiteConnection;

        public OrderPage()
        {
            InitializeComponent();

            _sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection();

            _sqLiteConnection.CreateTable<TodoItem>();

            picker.Items.Add("Itallian");
            picker.Items.Add("Thick pan");

            picker2.Items.Add("Pepperoni");
            picker2.Items.Add("Ham");
            picker2.Items.Add("Mushroom");
            picker2.Items.Add("Chillies");
            picker2.Items.Add("Toffu");
            picker2.Items.Add("Capsicum");
            picker2.Items.Add("Veg");
            picker2.Items.Add("Pumpkin");
            picker2.Items.Add("None");

            picker3.Items.Add("Pepperoni");
            picker3.Items.Add("Ham");
            picker3.Items.Add("Mushroom");
            picker3.Items.Add("Chillies");
            picker3.Items.Add("Toffu");
            picker3.Items.Add("Capsicum");
            picker3.Items.Add("Veg");
            picker3.Items.Add("Pumpkin");
            picker3.Items.Add("None");

            picker4.Items.Add("Pepperoni");
            picker4.Items.Add("Ham");
            picker4.Items.Add("Mushroom");
            picker4.Items.Add("Chillies");
            picker4.Items.Add("Toffu");
            picker4.Items.Add("Capsicum");
            picker4.Items.Add("Veg");
            picker4.Items.Add("Pumpkin");
            picker4.Items.Add("None");



            pickerT.Items.Add("Custome");
            pickerT.Items.Add("Pepperoni");
            pickerT.Items.Add("Hawaian");
            pickerT.Items.Add("Portobello");
            pickerT.Items.Add("Meat Feast");
            pickerT.Items.Add("Spicy Chicken");
            pickerT.Items.Add("Pumpkin");
            pickerT.Items.Add("Four Cheese");


           

        }

        public void PizzaBaseSelected(object sender, EventArgs e)
        {
            var PizzaBasei = picker.Items[picker.SelectedIndex];
        }
        public void PizzaStyleSelected(object sender, EventArgs e)
        {
            var PizzaNamei = pickerT.Items[pickerT.SelectedIndex];
        }

        public void PizzaTopping1Selected(object sender, EventArgs e)
        {
            var Topping1i = picker2.Items[picker2.SelectedIndex];
        }

        public void PizzaTopping2Selected(object sender, EventArgs e)
        {
            var Topping2i = picker3.Items[picker3.SelectedIndex];
        }

        public void PizzaTopping3Selected(object sender, EventArgs e)
        {
            var Topping3i = picker4.Items[picker4.SelectedIndex];
        }






        public void Button_OnClick(object sender, EventArgs e)
        {
           
          



            var PizzaBasei = picker.Items[picker.SelectedIndex];
            Debug.WriteLine("eeeeeeeeeeeeeeeeeee"+PizzaBasei);
            var PizzaNamei = pickerT.Items[pickerT.SelectedIndex];
            var Topping1i = picker2.Items[picker2.SelectedIndex];
            var Topping2i = picker3.Items[picker3.SelectedIndex];
            var Topping3i = picker4.Items[picker4.SelectedIndex];

            TodoItem item = new TodoItem();
            item.PizzaBase = PizzaBasei;
            item.PizzaName = PizzaNamei;
            item.Topping1 = Topping1i;
            item.Topping2 = Topping2i;
            item.Topping3 = Topping3i;

            _sqLiteConnection.Insert(item);
            
        }


    }



}




