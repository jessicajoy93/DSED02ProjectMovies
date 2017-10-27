using System;

namespace Student_Class_exercise.Business {
    class Double07 : Spy {

        //constructor
        public Double07() {
            Weapon = "Thermo Nuclear Device";
            KillAbility = "Absolute Devastation";
            Gadgets = "invisibilty and invulnerability Protection";
            CharmLevel = 7;
            CodeName = "Bond James Bond";
            }
        
        public override string Home() {
            string home = "The Palace";
            return home;
            }
        public override double DaysSincelastSeen(DateTime contactdate) {
            // TimeSpan ts = DateTime.Now - contactdate;
            double age = 0000000;
            // age = Math.Round(age, 1);
            return age;
            }


        }
    }
    