namespace LAN
{
    using System;

    class Program
    {
        static void Main()
        {
            Random ran = new Random();
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    a[i, j] = ran.Next(1, 100);
        }
    }
}
