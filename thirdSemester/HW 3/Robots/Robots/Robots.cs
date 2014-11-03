namespace Robots
{
    using System;

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
            zeroingArray(arrayOfVertex);

            bool[] arrayCriticalVertexs = new bool[matrixSize];
            zeroingArray(arrayOfVertex);

            for (int i = 0; i < matrixSize; ++i)
                for (int j = 0; j < robotsPosition.Length; ++j)
                    for (int u = 0; u < robotsPosition.Length; ++u)
                        if (u != j)
                        {
                            if (pathToVertex(adjacencyMatrix, robotsPosition[j], i, matrixSize)
                                && pathToVertex(adjacencyMatrix, robotsPosition[u], i, matrixSize))
                            {
                                arrayCriticalVertexs[i] = true;
                                j = 6;
                                break;
                            }
                        }

            for (int i = 0; i < robotsPosition.Length; ++i)
            {
                for (int j = 0; j < arrayCriticalVertexs.Length; ++j)
                {
                    if (arrayCriticalVertexs[j])
                        if (pathToVertex(adjacencyMatrix, robotsPosition[i], j, matrixSize))
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
        private bool pathToVertex(bool[,] adjacencyMatrix, int a, int b, int matrixSize)
        {
            Console.WriteLine(a);
            this.arrayOfVertex[a] = true;

            for (int i = 0; i < arrayOfVertex.Length; ++i)
            {
                if (arrayOfVertex[i] == false)
                    break;
                else if (i == arrayOfVertex.Length - 1)
                    return false;
            }

            for (int i = 0; i < matrixSize; ++i)
            {
                if (adjacencyMatrix[a, i] && adjacencyMatrix[i, b])
                {
                    zeroingArray(arrayOfVertex);
                    return true;
                }
                else if (adjacencyMatrix[a, i])
                {
                    for (int j = 0; j < matrixSize; ++j)
                    {
                        if (adjacencyMatrix[i, j] && !arrayOfVertex[j])
                        {
                            if (pathToVertex(adjacencyMatrix, j, b, matrixSize))
                            {
                                zeroingArray(arrayOfVertex);
                                return true;
                            }
                        }
                    }
                }
            }

            zeroingArray(arrayOfVertex);
            return false;
        }

        /// <summary>
        /// Zeroing all elements of the array.
        /// </summary>
        /// <param name="array"></param>
        private void zeroingArray(bool[] array)
        {
            for (int k = 0; k < array.Length; ++k)
                array[k] = false;
        }

        private bool[] arrayOfVertex;
    }
}
