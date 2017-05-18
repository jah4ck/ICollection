using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Schedule> ScriptScheduleListe = new List<Schedule>();
            ICollection<Schedule> ScriptScheduleCollection = ScriptScheduleListe;
            ScriptScheduleCollection.Add(new Schedule("titi", "HEURE", 1, DateTime.Now));
            ScriptScheduleCollection.Add(new Schedule("log", "MINUTE", 4, DateTime.Now));

            foreach (Schedule script in ScriptScheduleCollection)
            {
                Console.WriteLine(script.namescript+";"+script.dernierExec.ToString());
                
            }
            Thread.Sleep(2000);
            //string periode = from namescript in ScriptScheduleCollection where namescript = "titi" select namescript;
            ScriptScheduleCollection.Where(c => c.namescript == "titi").First().dernierExec=DateTime.Now;
            Console.WriteLine(ScriptScheduleCollection.Where(c => c.namescript == "titi").First().dernierExec.ToString());
            

        }
    }
}
