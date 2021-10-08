using System;
using System.Collections.Generic;
using System.Text;

namespace KryptoWarZV0._5
{
    class Trainer
    {
        //Eigenschaften der Klasse oder auch Attribute genannt
        private string trainerName;
        private bool startTrainer = false;


        private KryptoMoon kryptoMoon;


        //Kontstrukter(eig. eine Funktion, besondere die FUnktion wird bei nur bei new aufgerufen also bei erzuegen von Objekten)der Klasse      (string trainerName)--> übergabe Parameter bei jeder Funktion
        public Trainer(string trainerName)
        {
            this.trainerName = trainerName;

        }

        public string TrainerName
        {
            get => trainerName;
            set => trainerName = value;
        }

        public KryptoMoon KryptoMoon
        {
            get => kryptoMoon;
            set => kryptoMoon = value;
        }
        public bool StartTrainer
        {
            get => startTrainer;
            set => startTrainer = value;
        }
    }
}
