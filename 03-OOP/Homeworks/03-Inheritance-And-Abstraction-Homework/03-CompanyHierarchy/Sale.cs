using System;

namespace _03_CompanyHierarchy
{
    public class Sale
    {
        //A sale holds product name, date and price.
        string productName;
        DateTime date = new DateTime();
        decimal price;

        public Sale(string productName, decimal price)
        {
            this.productName = productName;
            this.price = price;
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
