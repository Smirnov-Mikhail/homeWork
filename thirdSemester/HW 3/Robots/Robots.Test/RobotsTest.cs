namespace Robots.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RobotsTest
    {
        [TestMethod]
        public void NoRobotsTest()
        {
            int matrixSize = 3;
            bool[,] adjacencyMatrix = new bool[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; ++i)
                for (int j = 0; j < matrixSize; ++j)
                    adjacencyMatrix[i, j] = false;

            adjacencyMatrix[0, 1] = true;
            adjacencyMatrix[0, 2] = true;

            adjacencyMatrix[1, 0] = true;
            adjacencyMatrix[1, 2] = true;

            adjacencyMatrix[2, 1] = true;
            adjacencyMatrix[2, 0] = true;

            Robots rob = new Robots();

            int[] robotPos = new int[0];

            Assert.IsTrue(rob.AllRobotsCanBeDestroyed(adjacencyMatrix, robotPos, matrixSize));
        }

        [TestMethod]
        public void OneRobotTest()
        {
            int matrixSize = 3;
            bool[,] adjacencyMatrix = new bool[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; ++i)
                for (int j = 0; j < matrixSize; ++j)
                    adjacencyMatrix[i, j] = false;

            adjacencyMatrix[0, 1] = true;
            adjacencyMatrix[0, 2] = true;

            adjacencyMatrix[1, 0] = true;
            adjacencyMatrix[1, 2] = true;

            adjacencyMatrix[2, 1] = true;
            adjacencyMatrix[2, 0] = true;

            Robots rob = new Robots();

            int[] robotPos = new int[1];
            robotPos[0] = 0;

            Assert.IsFalse(rob.AllRobotsCanBeDestroyed(adjacencyMatrix, robotPos, matrixSize));
        }

        [TestMethod]
        public void ManyRobotsTest()
        {
            int matrixSize = 6;
            bool[,] adjacencyMatrix = new bool[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; ++i)
                for (int j = 0; j < matrixSize; ++j)
                {
                    adjacencyMatrix[i, j] = false;
                }

            adjacencyMatrix[0, 0] = true;
            adjacencyMatrix[0, 1] = true;
            adjacencyMatrix[0, 2] = true;

            adjacencyMatrix[1, 1] = true;
            adjacencyMatrix[1, 0] = true;
            adjacencyMatrix[1, 2] = true;
            adjacencyMatrix[1, 4] = true;

            adjacencyMatrix[2, 0] = true;
            adjacencyMatrix[2, 1] = true;
            adjacencyMatrix[2, 2] = true;

            adjacencyMatrix[3, 3] = true;
            adjacencyMatrix[3, 4] = true;

            adjacencyMatrix[4, 1] = true;
            adjacencyMatrix[4, 3] = true;
            adjacencyMatrix[4, 4] = true;
            adjacencyMatrix[4, 5] = true;

            adjacencyMatrix[5, 4] = true;

            Robots rob = new Robots();

            int[] robotPos = new int[4];
            robotPos[0] = 0;
            robotPos[1] = 2;
            robotPos[2] = 3;
            robotPos[3] = 5;

            Assert.IsTrue(rob.AllRobotsCanBeDestroyed(adjacencyMatrix, robotPos, matrixSize));
        }
    }
}
