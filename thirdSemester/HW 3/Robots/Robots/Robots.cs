namespace Robots
{
    using System;
    using System.Linq;

    /// <summary>
    /// Class of robots network.
    /// </summary>
    public class Robots
    {
        public Robots()
        {

        }

        /// <summary>
        /// Function returns true if all robots can be destroyed, else false.
        /// </summary>
        /// <param name="adjacencyMatrix"></param>
        /// <param name="robotsPosition"> Start positions of robots. </param>
        /// <param name="matrixSize"></param>
        /// <returns></returns>
        public bool AllRobotsCanBeDestroyed(bool[,] adjacencyMatrix, int[] robotsPosition, int matrixSize)
        {
            arrayOfVertex = new bool[matrixSize];

            bool[] arrayCriticalVertexs = new bool[matrixSize];

            for (int i = 0; i < matrixSize; ++i)
                for (int j = 0; j < robotsPosition.Length; ++j)
                    for (int u = 0; u < robotsPosition.Length; ++u)
                        if (u != j)
                        {
                            if (PathToVertex(adjacencyMatrix, robotsPosition[j], i, matrixSize)
                                && PathToVertex(adjacencyMatrix, robotsPosition[u], i, matrixSize))
                            {
                                arrayCriticalVertexs[i] = true;
                                j = robotsPosition.Length;
                                break;
                            }
                        }

            for (int i = 0; i < robotsPosition.Length; ++i)
            {
                for (int j = 0; j < arrayCriticalVertexs.Length; ++j)
                {
                    if (arrayCriticalVertexs[j])
                        if (PathToVertex(adjacencyMatrix, robotsPosition[i], j, matrixSize))
                            break;

                    if (j == arrayCriticalVertexs.Length - 1)
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks the path between two vertices.
        /// </summary>
        /// <param name="adjacencyMatrix"></param>
        /// <param name="a"> First vertex. </param>
        /// <param name="b"> Second vertex. </param>
        /// <param name="matrixSize"></param>
        /// <returns></returns>
        private bool PathToVertex(bool[,] adjacencyMatrix, int a, int b, int matrixSize)
        {
            Console.WriteLine(a);
            this.arrayOfVertex[a] = true;

            for (int i = 0; i < arrayOfVertex.Length; ++i)
            {
                if (this.arrayOfVertex.All(x => x == true))
                    return false;
            }

            for (int i = 0; i < matrixSize; ++i)
            {
                if (adjacencyMatrix[a, i] && adjacencyMatrix[i, b])
                {
                    ZeroingArray(arrayOfVertex);
                    return true;
                }
                else if (adjacencyMatrix[a, i])
                {
                    for (int j = 0; j < matrixSize; ++j)
                    {
                        if (adjacencyMatrix[i, j] && !arrayOfVertex[j])
                        {
                            if (PathToVertex(adjacencyMatrix, j, b, matrixSize))
                            {
                                ZeroingArray(arrayOfVertex);
                                return true;
                            }
                        }
                    }
                }
            }

            ZeroingArray(arrayOfVertex);
            return false;
        }

        /// <summary>
        /// Zeroing all elements of the array.
        /// </summary>
        /// <param name="array"></param>
        private void ZeroingArray(bool[] array)
        {
            for (int k = 0; k < array.Length; ++k)
                array[k] = false;
        }

        private bool[] arrayOfVertex;
    }
}
