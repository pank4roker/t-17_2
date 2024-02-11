using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_2_2_
{
    /// <summary>
    /// Класс наследуемый от класса автобус
    /// </summary>
    class Touristbus:Bus
    {
        /// <summary>
        /// Поле класса
        /// </summary>
        double costoftour;
        /// <summary>
        /// Свойства полей
        /// </summary>
        public double Costoftour { get => costoftour; set => costoftour = value; }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Touristbus() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="mark"></param>
        /// <param name="numberseats"></param>
        /// <param name="price"></param>
        /// <param name="costoftour"></param>
        public Touristbus(string mark,int numberseats,double price, double costoftour):base(mark,numberseats,price)
        {
            this.costoftour = costoftour;
           
        }
        /// <summary>
        /// Модифицированный метод вывода
        /// </summary>
        public override void Info()
        {
            base.Info();
            Write($"Стоимость экскурсии: {costoftour}\nOбщая стоимоть с учетом цены за билеты: {Cost()}");
        }
        /// <summary>
        /// Модифицированный метод подсчета цены 
        /// </summary>
        /// <returns></returns>
        public override double Cost()
        {
            
            return base.Cost() + (Numberseats*costoftour);
        }
    }
}
