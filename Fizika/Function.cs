using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Fizika
{
    public class Function
    {
        public static double Tin=7300;
        public static double Lead = 11300;
        public static double Iron = 7800;
        public static double Ice = 900;
        /// <summary>
        /// Этот метод проверяет коректность данных.
        /// </summary>
        /// <param name="a" >Первая сторона</param>
        /// <param name="b" >Вторая сторона</param>
        /// <param name="c" >Третья сторона</param>
        /// <returns истина если прошло проверку иначе ложь></returns>
        public static bool fields(string a, string b,string c) 
        {
            double l, w, h;
            if(double.TryParse(a,out l))
            {
                if(double.TryParse(b, out w))
                {
                    if(double.TryParse(c, out h)) 
                    { return true; }
                    else 
                    {  return false; }
                }
                else { return false; }
            }
            else
            {
          return false;
            }
        }
        /// <summary>
        /// Этот метод считает массу тела.
        /// </summary>
        /// <param name="a" >Первая сторона </param>
        /// <param name="b" >Вторая сторона </param>
        /// <param name="c" >Третья сторона </param>
        /// <param name="p" >Плотность </param>
        /// <returns Возвращает массу тела></returns>
        public static double Massa(string a, string b,string c, double p) 
        {
            if(fields(a, b, c))
            {
               var answ= Convert.ToDouble(a) * Convert.ToDouble(b) * Convert.ToDouble(c) * p;
                if (answ>0)
                {
                    return answ;
                }
                else { return 0; }
            }
            else
            {
                return 0;
            }
        }
    }
}
