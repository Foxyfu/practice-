using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Toy
    {
        private int _price = 0;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Toy(int price) 
        {
            _price = price;
        }

        public override string ToString()
        {
            return $"price: {Price}";
        }
    }
    class Product : Toy
    {
        private int _yearManufacture = 0;

        public int YearManufacture
        {
            get { return _yearManufacture; }
            set { _yearManufacture = value; }
        }
        public Product(int price, int yearManufacture):base(price) 
        {
            _yearManufacture = yearManufacture;
        }

        public override string ToString()
        {
            return $"price: {Price}, yearManufacture: {YearManufacture} ";
        }
    }
    class Commodity : Toy
    {
        private int _weight = 0;

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public Commodity(int price, int weight) :base(price)
        {
            _weight = weight;
        }
        public override string ToString()
        {
            return $"price: {Price}, Weight: {Weight} ";
        }
    }

    class DairyProduct : Toy
    {
        private string _title = "";

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public DairyProduct(int price, string title) : base(price)
        {
            _title = title;
        }

        public override string ToString()
        {
            return $"price: {Price}, Title: {Title} ";
        }
    }
}
