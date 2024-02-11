using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _17_2
{
    /// <summary>
    /// Наследуемый класс инжинера
    /// </summary>
    class Engineer:Employee
    {
        /// <summary>
        /// Поля класса
        /// </summary>
        private int projects;

        public int Projects { get => projects; set => projects = value; }
        /// <summary>
        /// Конструктор без параметра
        /// </summary>
        public Engineer() { }
        /// <summary>
        /// Конструтор с параметрами
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="minsalary"></param>
        /// <param name="coeff"></param>
        /// <param name="projects"></param>
        public Engineer(string surname, double minsalary, double coeff, int projects):base(surname,minsalary,coeff) 
        {
            this.projects = projects;
        }
        /// <summary>
        /// Модифицированный метод вывода иныформации
        /// </summary>
        public override void ShowInfo()
        {
            base.ShowInfo();
            WriteLine($"Проекты: {projects}\nУвеличенный доход:{Income()}");
        }
        /// <summary>
        /// Модифицированный метод вычисления зп
        /// </summary>
        /// <returns></returns>
        public override double Income()
        {
            if (projects > 10)
            {
                return base.Income() * (projects / 10);
            }
            else
            {
                return base.Income();
            }
            
        }


    }
}
