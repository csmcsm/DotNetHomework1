using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Square:Rectangle
    {
        float lon, width;
        public bool ifRight(){

            if (lon>0||width>0||
                lon ==width)
            {
                return true;
            }
            return false;
        }
        public float GetS(){
            if (ifRight()) {

                return lon * lon;
            
            
            
            
            }

            return -1;
        }

        public Square(float lon) {
            this.lon = lon;
            width = lon;
        
        }

        public Square() {
            lon = 0;
            width = 0;
        
        }
     
    }
}
