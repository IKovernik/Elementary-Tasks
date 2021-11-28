using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class StartNumber //вычисляет миниммальное число, квадрат которого больше или равен заданному
    {
        public int FirstNumberOfRange(int m) // m - параметр, который задает пользователь по условию задачи
                                              
        { 

        double start = Math.Sqrt(m); //извлекаем корень квадратный из m
        start = Math.Ceiling(start); // округляем в бОльшую сторону
        int startint = (int)start;  // convert from double into int
            return startint; 
          }  
    }

       
}
