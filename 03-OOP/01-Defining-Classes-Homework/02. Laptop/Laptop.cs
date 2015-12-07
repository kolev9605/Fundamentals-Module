using System;
public class Laptop
{
    private string model, manufacturer, processor, ram, graphicsCard, hdd, screen;
    private decimal price;
    private Battery battery;

    public Laptop(string model, decimal price, string manufacturer = null, string processor = null, string ram=null, string graphicsCard= null,string hdd = null, string screen = null, Battery battery = null) 
        :this(model, price)
    {
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.RAM = ram;
        this.GraphicsCard = graphicsCard;
        this.HDD = hdd;
        this.Screen = screen;
        this.battery = battery;
    }

    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.Price = price;
    }


    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (value == string.Empty)
            {
                throw new FormatException("Model cannot be empty.");
            }
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (value == string.Empty)
            {
                throw new FormatException("Manufacturer cannot be empty.");
            }
            this.manufacturer = value;
        }
    }

    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (value == string.Empty)
            {
                throw new FormatException("Processor cannot be empty.");
            }
            this.processor = value;
        }
    }

    public string RAM
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (value == string.Empty)
            {
                throw new FormatException("RAM cannot be empty.");
            }
            this.ram = value;
        }
    }

    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (value == string.Empty)
            {
                throw new FormatException("Graphics Card cannot be empty.");
            }
            this.graphicsCard = value;
        }
    }

    public string HDD
    {
        get
        {
            return this.hdd;
        }
        set
        {
            if (value == string.Empty)
            {
                throw new FormatException("HDD cannot be empty.");
            }
            this.hdd = value;
        }
    }
        public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (value == string.Empty)
            {
                throw new FormatException("Screen cannot be empty.");
            }
            this.screen = value;
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new FormatException("Price cannot be negative");
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Model: {0}; \nPrice: {1}; \nManufacturer: {2}; \nProcessor: {3}; \nRAM: {4}; \nGraphics card: {5}; \nHDD: {6} \nScreen: {7}; \nBattery: {8};",
            this.Model == null ? "[model not set]" : this.Model,
            this.Price,
            this.Manufacturer == null ? "[manufacturer not set]" : this.Manufacturer,
            this.Processor == null ? "[processor not set]" : this.Processor,
            this.RAM == null ? "[RAM not set]" : this.RAM,
            this.GraphicsCard == null ? "[Graphics Card not set]" : this.GraphicsCard,
            this.HDD == null ? "[HDD not set]" : this.HDD,
            this.Screen == null ? "[Screen not set]" : this.Screen,
            this.battery);

    }
}