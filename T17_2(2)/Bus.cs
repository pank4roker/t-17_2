using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_2_2_
{
    /// <summary>
    /// Класс автобуса 
    /// </summary>
    internal class Bus
    {
        /// <summary>
        /// Поля класса
        /// </summary>
        string mark;
        int numberseats;
        double price;
        /// <summary>
        /// Свойства полей
        /// </summary>
        public string Mark { get => mark; set => mark = value; }
        public int Numberseats { get => numberseats; set => numberseats = value; }
        public double Price { get => price; set => price = value; }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Bus() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="mark"></param>
        /// <param name="numberseats"></param>
        /// <param name="price"></param>
        public Bus(string mark,int numberseats,double price)
        {
            this.mark = mark;
            this.numberseats = numberseats;
            this.price = price;
        }
        /// <summary>
        /// Метод вывода
        /// </summary>
        virtual public void Info()
        {
            Write($"Марка: {mark}\n Кол-во мест: {numberseats}\n Стоимость билета:{price}\nОбщая стоимость всех мест: {Cost()}\n");
        }
        /// <summary>
        /// Метод подсчета цены 
        /// </summary>
        /// <returns></returns>
        virtual public double Cost()
        {
            return numberseats * price;
        }
    }
}
