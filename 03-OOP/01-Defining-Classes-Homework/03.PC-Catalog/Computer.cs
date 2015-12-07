using System;

namespace _03.PC_Catalog
{
    class Computer : IComparable<Computer>
    {
        private string computerName;
        private decimal computerPrice;
        private Component processor;
        private Component ram;
        private Component graphicsCard;


        public string Name
        {
            get { return this.computerName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null");
                }
                this.computerName = value;
            }
        }

        public decimal Price
        {
            get { return this.computerPrice; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                this.computerPrice = value;
            }
        }

        public Computer(string computerName)
        {
            this.Name = computerName;
        }

        public Computer(string computerName, Component processor, Component ram, Component graphicsCard)
            : this(computerName)
        {
            this.processor = processor;
            this.ram = ram;
            this.graphicsCard = graphicsCard;
        }

        public string DisplayData()
        {
            this.computerPrice = this.processor.ComponentPrice + this.ram.ComponentPrice + this.graphicsCard.ComponentPrice;
            return string.Format("{0}:\n - Processor: {1}; \n - RAM: {2}; \n - Graphics Card: {3}; \n -- Total price: {4}.",
                this.Name,
                this.processor.ComponentName,
                this.ram.ComponentName,
                this.graphicsCard.ComponentName,
                this.computerPrice);

        }

        public override string ToString()
        {
            this.computerPrice = this.processor.ComponentPrice + this.ram.ComponentPrice + this.graphicsCard.ComponentPrice;
            return string.Format("{0}:\n - Processor: {1}; \n - RAM: {2}; \n - Graphics Card: {3}; \n -- Total price: {4}.\n-----------------------\n",
                this.Name,
                this.processor.ComponentName,
                this.ram.ComponentName,
                this.graphicsCard.ComponentName,
                this.computerPrice);
        }

        public int CompareTo(Computer other)
        {
            return other.computerPrice.CompareTo(this.Price);
        }
    }
}
