using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SportContest
{
    class Surgeon:Doctor
    {
        public override void ThreadStart() { myThread = new Thread(new ParameterizedThreadStart(Pos)); }

        public override void setParam(string n, string sn, byte a, byte ex)
        {
            base.setParam(n, sn, a, ex);
            direction = "Хирургическое";           
        }
        public static void Treatis(Sportsman pazient, Doctor d, ListServMed lsm)
        {
            Console.WriteLine("лечу");
            if (pazient.trauma.NeedHelp == d.GetType())
            {
                int id = lsm.IdPazient(pazient);
                if (id == -1 || lsm.ServiceMeds[id].trauma.lechenie >= 100)
                {
                    id = lsm.Add(pazient, d, pazient.trauma);
                }
                for (int i = 0; i < 10; i++)
                {
                    if (Сompetition.wins != "") { return; }
                    lsm.ServiceMeds[id].trauma.lechenie += 10;
                    Thread.Sleep(100);
                }
            }
            else { return; }
            pazient.force = 1;
            pazient.trauma = null;
        }
        public async static void Pos(object obj)
        {
            if (Сompetition.wins != "") { return; }
            Console.WriteLine("ищу");
            (List<Sportsman> paz, Doctor d, ListServMed lsm) pazDoc = ((List<Sportsman>, Doctor, ListServMed))(obj);
            foreach (Sportsman item in pazDoc.paz)
            {
                if (item.trauma != null) { await Task.Run(() => Treatis(item, pazDoc.d, pazDoc.lsm)); }
            }
            Thread.Sleep(400);
            Pos(obj);
        }
        public override string ToString()
        {
            return "Хирург";
        }
   
    }
}
