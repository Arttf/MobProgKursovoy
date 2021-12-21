using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SportContest
{
    public abstract class Doctor : Man,ICloneable
    {
        string name = "Default";
        string suname = "Default";
        byte age, expWork = 0;
        bool inGame = false;        
        protected string direction = "";
        public Thread myThread;
        public abstract void ThreadStart();
        public virtual void setParam(string n, string sn, byte a,byte ex)
        {
            name = n;
            suname = sn;
            age = a;
            expWork = ex;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }       
        public string Suname
        {
            get
            {
                return suname;
            }
            set
            {
                suname = value;
            }
        }
        public byte Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Profession
        {
            get
            {
                return ToString();
            }
        }
        string Direction { get { return direction; }  }
        public byte ExpWork
        {
            get
            {
                return expWork;
            }
            set
            {
                expWork = value;
            }
        }      
            public object Clone()
        {
            return this.MemberwiseClone();
        }
        
    }
}
