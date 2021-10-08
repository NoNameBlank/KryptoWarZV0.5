using System;
using System.Collections.Generic;
using System.Text;

namespace KryptoWarZV0._5
{
    class KryptoMoon
    {

        private int id;
        private string name;
        private int lebensPunkte;
        private string attacke1Name;
        private int attacke1Schaden;
        private string attacke2Name;
        private int attacke2Schaden;


        public KryptoMoon(int id, string name, int lebensPunkte, string attacke1Name, int attacke1Schaden, string attacke2Name, int attacke2Schaden)
        {
            this.id = id;
            this.name = name;
            this.lebensPunkte = lebensPunkte;
            this.attacke1Name = attacke1Name;
            this.attacke1Schaden = attacke1Schaden;
            this.attacke2Name = attacke2Name;
            this.attacke2Schaden = attacke2Schaden;



        }

        public string KryptoMoonName
        {
            get => name;
        }

        public int KryptoMoonLebensPunkte
        {
            get => lebensPunkte;
            set => lebensPunkte = value;
        }

        public int ID
        {
            get => id;
        }

        public string Attacke1Name
        {
            get => attacke1Name;
        }

        public int Attacke1Schaden
        {
            get => attacke1Schaden;
        }

        public string Attacke2Name
        {
            get => attacke2Name;
        }

        public int Attacke2Schaden
        {
            get => attacke2Schaden;
        }






    }
}
