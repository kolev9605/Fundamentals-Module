using System;
public class Battery
{
    private string battery;
    private double batteryLife;


    public Battery(string type)
    {
        this.Type = type;
    }

    public Battery(string type, double life)
        : this(type)
    {
        this.BatteryLife = life;

    }

    public string Type
    {
        get { return this.battery; }
        set
        {
            if (value == string.Empty)
            {
                throw new FormatException("Battery model cannot be empty.");
            }
            this.battery = value;
        } 
    }

    public double BatteryLife 
    {
        get { return this.batteryLife; }
        set
        {
            if (value < 0)
            {
                throw new FormatException("Battery life cannot be negative.");
            }
            this.batteryLife = value;
        }
    }
    public override string ToString()
    {
        return string.Format("{0}, {1} hours", 
            this.Type == null ? "[Type not set]" : this.Type, 
            this.BatteryLife);
    }
}