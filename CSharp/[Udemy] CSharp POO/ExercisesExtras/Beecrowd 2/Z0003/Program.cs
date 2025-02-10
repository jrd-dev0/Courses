// 1067, 1071, 1072, 1073, 1074, 1075, 1079, 1080, 1094, 1096, 1097, 1116, 1132, 1133, 1142, 1143, 1144, 1151, 1153
// 1155, 1156, 1157
// 1099, 1101, 1145, 1149, 1150, 1158, 1160, 1165
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z0003
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, soma=0;

            a = int.Parse(Console.ReadLine());

            for (y = 0; y < a; y++ )
            {
                 x = int.Parse(Console.ReadLine());

                soma += x;
            }

            Console.WriteLine(soma);

            Console.ReadLine();
        }
    }
}
