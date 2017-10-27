using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Student_Class_exercise.Business;

namespace Student_Class_exercise {
    public static class Factory {
        /// <summary>
        /// Decides which class to instantiate.
        /// </summary>
        public static Spy GetASpy(int id) {
            switch (id) {
                case 1:
                    return new Double01();
                case 2:
                    return new Double02();
                case 3:
                    return new Double03(); ;
                case 4:
                    return new Double04();
                case 5:
                    return new Double05();
                case 6:
                    return new Double06();
                case 7:
                    return new Double07();


                default:
                    return new Double01();
                }
            }
        }


    }
