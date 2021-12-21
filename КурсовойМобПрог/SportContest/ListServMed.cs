using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportContest
{
    public class ListServMed
    {
        public List<ServiceMed> ServiceMeds = new List<ServiceMed>();
        public int IdPazient(Sportsman sp) {
            int i = 0;
            foreach (ServiceMed sm in ServiceMeds)
            {
                if (sm.pazient == sp) { return i; }
                i++;
            }
            return -1;
        }
        public int Add(Sportsman sp, Doctor d, Trauma t)
        {
            ServiceMeds.Add(new ServiceMed(sp, d, t));
            return ServiceMeds.Count-1;
        }
        
    }      
    public class ServiceMed
    {
            public Sportsman pazient;
            public Doctor med;
            public Trauma trauma;
            public ServiceMed(Sportsman sp, Doctor d, Trauma t)
            {
            pazient = sp;
            med = d;
            trauma = t;
            }
        public string NamePaz
        {
            get
            {
                return pazient.Name;
            }           
        }
        public string SunamePaz
        {
            get
            {
                return pazient.Suname;
            }
        }
        public string Trauma
        {
            get
            {
                return trauma.name;
            }
        }
       
        public string NameSunameDoctor
        {
            get
            {
                return med.Name+" "+med.Suname;
            }
        }
        public int LecheniePpozentov
        {
            get
            {
                return trauma.lechenie;
            }
        }
    }
    
}
