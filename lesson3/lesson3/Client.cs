using System;
using System.Collections.Generic;
using System.Text;

namespace lesson3
{
    [Serializable]
    public class Client
    {
        string name;
        int c_id;
        public Client(string name, int c_id)
        {
            this.name = name;
            this.c_id = c_id;
        }
        public string toString()
        {
            return  "客户名： "+name +
         " 客户id:  "+c_id +"/ n";
        }


    }


}
