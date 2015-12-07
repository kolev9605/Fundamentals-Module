using System;

namespace GalacticGPS
{
    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }
        
        //Latitudes range from -90 to 90
        //Longitudes range from -180 to 180

        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("Latitude must be in range [-90 - 90]");
                }
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get { return this.longitude; }
            set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("Longitude must be in range [-90 - 90]");
                }
                this.longitude = value;
            }
        }

        public Planet Planet { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}",
                this.Latitude, this.Longitude, this.Planet);
        }
    }
}
