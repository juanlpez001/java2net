using System;
using System.Text;

namespace stringBuilder_04
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hola Juan!");
            sb.Replace("Juan", "Pablo");

            Console.WriteLine(sb);

        }
    }
}
