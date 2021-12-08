using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci2
{
    /// <summary>
    /// 
    ///  Вывести все числа Фибоначчи, которые удовлетворяют переданному в функцию ограничению:
    ///  находятся в указанном диапазоне, либо имеют указанную длину.
    ///  Пример: если указан диапазон[20;100] - полученный ряд Фибоначчи - 21, 34, 55, 89;
    ///  указана длина = 3, полученный ряд Фибоначчи - 144, 233, 377, 610, 987
    ///
    /// </summary>

    internal class Program
    {
        static void Main(string[] args)
        {
            
            new Controller().Run();
        }
    }
}
