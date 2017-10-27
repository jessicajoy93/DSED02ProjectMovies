
using System;

namespace Student_Class_exercise {
    //this is abstract because we never want to instantiate this class, its a base class
    public abstract class Spy {
        public String CodeName { get; set; }
        public Agency Agency { get; set; }
        public DateTime DateLastSeen { get; set; }
        public string Weapon { get; set; }
        public string KillAbility { get; set; }
        public string Gadgets { get; set; }
        public int CharmLevel { get; set; }
        
        //method
        public double yearsold(DateTime born) {
            TimeSpan ts = DateTime.Now - born;
            double age = ts.TotalDays / 365;
            age = Math.Round(age, 1);
            return age;
            }
        //this is virtual as you can override it in the derived classes
        public virtual double DaysSincelastSeen(DateTime contactdate) {
            TimeSpan ts = DateTime.Now - contactdate;
            double lastseen = ts.TotalDays;
            lastseen = Math.Round(lastseen, 1);
            return lastseen;
            }
        //this is virtual as you can override it in the derived classes
        public virtual string Home() {
            string home = "Park Lane";
            return home;

            }
        }
    }
