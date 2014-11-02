namespace LAN
{
    using System;

    /// <summary>
    /// The class of model local network.
    /// </summary>
    public class Lan
    {
        public Lan(Computer[] computers)
        {
            this.computers = computers;
            this.random = new Random();
        }

        /// <summary>
        /// Make one move.
        /// </summary>
        public void makeMove()
        {
            int[] numbeSOfNewInfections = new int[this.computers.Length];
            int currentPosition = 0;

            // Пройдём по всем компьютерам и "попытаемся" заразить компы, соседствующие с заражёнными.
            for (int i = 0; i < this.computers.Length; ++i)
            {
                // Если кмопьютер заражён.
                if (computers[i].infected)
                {
                    // Пройдёмся по всем компьютерам контактирующим с ним.
                    for (int j = 0; j < computers[i].connectedComputers.Length; ++j)
                    {
                        // Если компьютер не заражён, то с определённой вероятностью будет заражён.
                        if (!computers[computers[i].connectedComputers[j]].infected)
                        {
                            if (random.NextDouble() < computers[computers[i].connectedComputers[j]].probabilityOfInfection)
                            {
                                numbeSOfNewInfections[currentPosition] = computers[i].connectedComputers[j];
                                ++currentPosition;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < currentPosition; ++i)
            {
                if (!computers[numbeSOfNewInfections[i]].infected)
                    computers[numbeSOfNewInfections[i]].infected = true;
            }
        }

        /// <summary>
        /// Test for miss surviving computers.
        /// </summary>
        /// <returns></returns>
        public bool allInfected()
        {
            for (int i = 0; i < computers.Length; ++i)
            {
                if (!computers[i].infected)
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Array computers in our local network.
        /// </summary>
        private Computer[] computers;
        private Random random;
    }
}
