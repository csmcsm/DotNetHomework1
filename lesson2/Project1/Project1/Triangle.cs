using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Triangle:IClass
    {
        float an1, an2, an3;
        float len1,
            len2,len3;
        public float GetS() {
            if (ifRight()) {
                float p = len1 + len2 + len3;
                p *= 0.5f;
                float s = p * (p - len1) *
                    (p - len2) * (p - len3);
                s =(float
                    )
                    Math.Sqrt(s);
                return s;
            
            }

            return -1;
        
        }
        public bool  ifRight() {
            ChangePos();
            if (an1>0||an2>0||an3>0||
                an1 + an2 + an3 != 180
                ||len3 + len2 < len1){
                return false;
            }

            if (check(len1, len2, len3, an1) &&
                check(len2, len1, len3, an2) &&
                check(len3, len1, len2, an3))
            {
                return true;
            }
            return false;
        }

        bool check(float len1, float len2, float len3, float an) {
            float cos1 = (float)
                 Math.Cos(an1);
            float zhi1 = len2 * len2 + len3 * len3 - len1 * len1;
            zhi1 = zhi1 / (2 * len2 * len3);
            if (zhi1 == cos1) {
                return true;
            }
            return false;
        
        
        }
        public Triangle(float an1
            ,float an2,float an3,float len1,
            float len2,float len3){
                this.an1 = an1;
                this.an2 = an2;
                this.an3 = an3;
                this.len1 = len1;
                this.len2 = len2;
                this.len3 = len3;


        
        }
        public Triangle()
        {
            this.an1 = 0;
            this.an2 = 0;
            this.an3 = 0;
            this.len1 = 0;
            this.len2 = 0;
            this.len3 = 0;



        }
 
 
        void ChangePos() {
            float s;
            if (len1 < len2) {
                s = len1;
                len1 = len2;
                len2 = s;
            }
            if (len1 < len3) {

                s = len1;
                len1 = len3;
                len3 = s;
            }

            if (len2 < len3)
            {

                s = len2;
                len2 = len3;
                len3 = s;
            }
            if (an1<an2)
            {
                s = an1;
                an1 = an2;
                an2 = s;
            }
            if (an1 < an3)
            {

                s = an1;
                an1 = an3;
                an3 = s;
            }

            if (an2 < an3)
            {

                s = an2;
                an2 = an3;
                an3 = s;
            }
        
        
        }

    }

 



}
