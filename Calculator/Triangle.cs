using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    // 
    //        |\
    //        | \ hyp
    //   cat2 |  \ 
    //        |___\
    //         cat1  
    //
    public static class Triangle
    {
        /// <summary>
        /// Рассчитывает площадь прямоугольного треугольника по размерам сторон.
        /// Катеты располагаются по часовой стрелке относительно гипотенузы.
        /// В случае, если два или три аргумента заданы неверно ( <= 0 ), кидает ArgumentException.
        /// </summary>
        /// <param name="hyp">Длина гипотенузы.</param>
        /// <param name="cat1">Первый катет по часовой стрелке относительно гипотенузы.</param>
        /// <param name="cat2">Второй катет по часовой стрелке относительно гипотенузы.</param>
        public static float GetArea(float hyp, float cat1, float cat2)
        {
            var n = 0;
            if (hyp > 0)
            {
                ++n;
            }
            if (cat1 > 0)
            {
                ++n;
            }
            if (cat2 > 0)
            {
                ++n;
            }
            if (n < 2)
            {
                throw new ArgumentException("Недостаточно информации");
            }

            if (cat2 <= 0)
            {
                cat2 = (float)Math.Sqrt(hyp * hyp - cat1 * cat1);
            }
            else if (cat1 <= 0)
            {
                cat1 = (float)Math.Sqrt(hyp * hyp - cat2 * cat2);
            }

            return cat1 * cat2 * 0.5f;
        }
    }
}
