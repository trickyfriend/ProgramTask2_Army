using System;
using System.Collections.Generic;
using System.Text;

namespace Army_Library
{
    public class SecondLevelClass : FirstLevelClass
    {
        int p;
        public int P
        {
            get { return p; }
            set { p = value; }
        }

        public SecondLevelClass() { } // из-за этого могут быть ошибки в выводе

        public SecondLevelClass(string typeOfTroops, int strength, int armament, int p) : base(typeOfTroops, strength, armament) // из-за этого могут быть ошибки в выводе
        {
            this.P = p;
        }

        public override double Q()
        {
            return base.Q() * (P + 1);
        }

        public override string Info()
        {
            return base.Info() + "\r\n Опыт: " + P;
        }
    }
}
