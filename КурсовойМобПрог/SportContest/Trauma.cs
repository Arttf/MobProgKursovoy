using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportContest
{
    public class Trauma:ICloneable
    {
        public string name = "default";
        double condition = 1.0;
        Type needHelp = null;
        public int lechenie = 0;
        public Trauma(string n, double cond, Type t)
        { 
            name = n;
            condition = cond;
            needHelp = t;
        }
        public double Condition
        {
            get {
                return condition;
            }
        }
        public Type NeedHelp
        {
            get
            {
                return needHelp;
            }
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
