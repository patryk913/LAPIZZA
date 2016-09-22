using SQLite;

namespace XamarinForms.SQLite
{
    public class TodoItem
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string PizzaBase { get; set; }

        public string PizzaName { get; set; }

        public string Topping1 { get; set; }

        public string Topping2 { get; set; }

        public string Topping3 { get; set; }

       public bool Done { get; set; }

        public override string ToString()
        {
            return string.Format(" PizzaBase : {0}, PizzaName : {1}, Topping1 : {2},  Topping2 : {3},  Topping3 : {4}", PizzaBase, PizzaName, Topping1, Topping2, Topping3);
        }
    }
}