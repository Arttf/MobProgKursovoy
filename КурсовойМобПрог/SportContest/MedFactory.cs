using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportContest
{
    public class MedFactory
    {
        private static MedFactory _instance = null;
        public static MedFactory getInstance()
        {
            if (_instance == null)
                _instance = new MedFactory();
            return _instance;
        }
        public List<Doctor> doctors = new List<Doctor>();
        public MedFactory() {
            doctors.Add(new Therapist());
            doctors.Add(new Psychologist());
            doctors.Add(new Surgeon());
        }
        public int GetIndex(Type t) {
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].GetType().Name==t.Name ) return i;
            }
            return -1;
        }

        public Doctor GetDoctor(string n, string sn, byte a, byte ex,int i)
        {
            doctors[i].setParam(n, sn, a, ex);                     
            return (Doctor)doctors[i].Clone();//doctors[i].Clone(); new    
        }
    }
}
