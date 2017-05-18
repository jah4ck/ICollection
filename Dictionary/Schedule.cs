using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    public class Schedule
    {
        public string namescript { get; set; }
        public string periode { get; set; }
        public int interval {get;set;}
        public DateTime dernierExec { get; set; }
        public Schedule(string _namescript, string _periode,int _interval,DateTime _dernierLancement)
        {
            namescript = _namescript;
            periode = _periode;
            interval = _interval;
            dernierExec = _dernierLancement;
        }
        public void SetDernierExec(DateTime date)
        {
            dernierExec = date;
        }
    }
}
