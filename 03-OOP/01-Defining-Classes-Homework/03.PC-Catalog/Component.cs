using System;

namespace _03.PC_Catalog
{
    class Component
    {
        private string componentName;
        private string componentDetails;
        private decimal componentPrice;

        public Component(string name, string details, decimal price) 
            : this (name, price)
        {
            this.ComponentDetails = details;
        }

        public Component(string name, decimal price)
        {
            this.ComponentName = name;
            this.ComponentPrice = price;
        }

        public string ComponentName
        {
            get { return this.componentName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null");
                }
                this.componentName = value;
            }
        }

        public string ComponentDetails
        {
            get { return this.componentDetails; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Details cannot be null");
                }
                this.componentDetails = value;
            }
        }

        public decimal ComponentPrice
        {
            get { return this.componentPrice; }
            set
            {
                if (this.componentPrice < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                this.componentPrice = value;
            }
        }

    }
}