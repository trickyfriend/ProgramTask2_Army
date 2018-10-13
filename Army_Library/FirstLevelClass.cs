using System;
using System.Collections.Generic;
using System.Text;

namespace Army_Library
{
    public class FirstLevelClass
    {
        string typeOfTroops;
        public string TypeOfTroops
        {
            get { return typeOfTroops; }
            set { typeOfTroops = value; }
        }

        int strengthInPhousands;
        public int StrengthInPhousands
        {
            get { return strengthInPhousands; }
            set { strengthInPhousands = value; }
        }

        int armament;
        public int Armament
        {
            get { return armament; }
            set { armament = value; }
        }

        public FirstLevelClass() { }
        public FirstLevelClass(string typeOfTroops, int strength,  int armament)
        {
            this.TypeOfTroops = typeOfTroops;
            this.StrengthInPhousands = strength;
            this.Armament = armament;
        }

        public virtual double Q()
        {
            return 0.3 * StrengthInPhousands + 0.7 * armament;
        }

        public virtual string  Info()
        {
            return " Вид войск: " + TypeOfTroops + "\r\n Численность (тыс. чел.): " + StrengthInPhousands + "\r\n Вооружённость (в баллах): " + Armament + "\r\n Q: " + Q();
        }
    }
}
