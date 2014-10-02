namespace LAN
{
    using System;

    public class LAN
    {
        public LAN(bool[,] cooperationMatrix, Computer[] computers)
        {
            this.cooperationMatrix = cooperationMatrix;
            this.computers = computers;
        }

        private void Move()
        {

        }



        private class Computer
        {
            public Computer(OperationSystems operationSys, bool infected)
            {
                this.operationSystem = operationSys;
                this.infected = infected;
            }

            public OperationSystems operationSystem;
            public bool infected;
            
        }

        private bool[,] cooperationMatrix;
        private Computer[] computers;

        private enum OperationSystems { Windows, Linux, DOS, SunOS, IOS };
    }
}
