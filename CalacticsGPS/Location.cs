using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalacticsGPS
{
     struct Location
    {
        private const int LatitudeMin = -90;
        private const int LatitudeMax = 90;
        private const int LongitudeMin = -180;
        private const int LongitudeMax = 180;

        public double longitude;
        public double latitude;
        public double Latitude {
            get
            {
                return this.latitude;
            }
           private set
            {
                if (value < LatitudeMin || value > LatitudeMax)
                {
                    throw new ArgumentException("Latitude is wrong");
                }
                this.latitude = value;
            }
            
        }
        public double Longitude
        {
            get
            {
                return this.longitude;
            }
            private set
            {
                if (value < LongitudeMin || value > LongitudeMax)
                {
                    throw new ArgumentException("Longitude is wrong");
                }
                this.longitude = value;
            }
        }
        
        public Planet Planet{ get; set;}

        public Location(double latitude,double longitude,Planet planet):this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet=planet;

        }
        public override string ToString()
        {
            return String.Format("<{0}><{1}>-<{2}>",this.Latitude,this.Latitude,this.Planet);
        }

    }
}
