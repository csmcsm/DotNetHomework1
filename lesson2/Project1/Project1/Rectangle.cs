using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Rectangle : IClass
    {

        float lon, width;
        public float GetS() {

            return this.Area;
        }

        public float Area
        {
            get
            {

                return lon * width;

            }


        }
        public
        bool ifRight()
        {
            if (lon > 0 && width > 0)
            {
                return true;

            }
            return false;

        }
        public Rectangle()
        {
            this.lon = 0;
            this.width = 0;

        }


        public Rectangle(float lon, float width)
        {
            this.lon = lon;
            this.width = width;

        }

    }
}
