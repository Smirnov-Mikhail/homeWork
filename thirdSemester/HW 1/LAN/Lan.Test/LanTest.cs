namespace Lan.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using LAN;

    [TestClass]
    public class LanTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Computer[] computers1 = new Computer[6];

            computers1[0].infected = true;
            computers1[0].connectedComputers = new int[] { 1, 5 };
            computers1[0].probabilityOfInfection = 0.5;

            computers1[1].infected = false;
            computers1[1].connectedComputers = new int[] { 0, 2, 4, 5 };
            computers1[1].probabilityOfInfection = 0.2;

            computers1[2].infected = false;
            computers1[2].connectedComputers = new int[] { 0, 3 };
            computers1[2].probabilityOfInfection = 0.6;

            computers1[3].infected = false;
            computers1[3].connectedComputers = new int[] { 4, 5 };
            computers1[3].probabilityOfInfection = 0.5;

            computers1[4].infected = false;
            computers1[4].connectedComputers = new int[] { 1 };
            computers1[4].probabilityOfInfection = 0.7;

            computers1[5].infected = true;
            computers1[5].connectedComputers = new int[] { 0, 3 };
            computers1[5].probabilityOfInfection = 0.9;

            lan1 = new Lan(computers1);
        }

        /// <summary>
        /// Beginning not all infected.
        /// </summary>
        [TestMethod]
        public void Start()
        {
            Assert.IsFalse(lan1.allInfected());   
        }

        /// <summary>
        /// The probability of infection is 100%.
        /// </summary>
        [TestMethod]
        public void FirstMove()
        {
            Computer[] computers2 = new Computer[2];

            computers2[0].infected = true;
            computers2[0].connectedComputers = new int[] { 1 };
            computers2[0].probabilityOfInfection = 0.5;

            computers2[1].infected = false;
            computers2[1].connectedComputers = new int[] { 0 };
            computers2[1].probabilityOfInfection = 1;

            Lan lan2 = new Lan(computers2);

            lan2.makeMove();
            Assert.IsTrue(lan2.allInfected());
        }

        /// <summary>
        /// The probability of infection is 0%.
        /// </summary>
        [TestMethod]
        public void CheckCorrectAtImpossibilityOfInfection()
        {
            Computer[] computers2 = new Computer[6];

            computers2[0].infected = true;
            computers2[0].connectedComputers = new int[] { 1, 5 };
            computers2[0].probabilityOfInfection = 0.5;

            computers2[1].infected = false;
            computers2[1].connectedComputers = new int[] { 0, 2, 4, 5 };
            computers2[1].probabilityOfInfection = 0.2;

            computers2[2].infected = false;
            computers2[2].connectedComputers = new int[] { 0, 3 };
            computers2[2].probabilityOfInfection = 0.6;

            computers2[3].infected = false;
            computers2[3].connectedComputers = new int[] { 4, 5 };
            computers2[3].probabilityOfInfection = 0.5;

            computers2[4].infected = false;
            computers2[4].connectedComputers = new int[] { 1 };
            computers2[4].probabilityOfInfection = 0;

            computers2[5].infected = true;
            computers2[5].connectedComputers = new int[] { 0, 3 };
            computers2[5].probabilityOfInfection = 0.9;

            Lan lan2 = new Lan(computers2);

            for (int i = 0; i < 1000; ++i)
                lan2.makeMove();
            Assert.IsFalse(lan2.allInfected());
        }

        /// <summary>
        /// Check that process has an end.
        /// </summary>
        [TestMethod]
        public void ManyMoves()
        {
            while (!lan1.allInfected())
                lan1.makeMove();
            Assert.IsTrue(lan1.allInfected());
        }

        Lan lan1;
    }
}
