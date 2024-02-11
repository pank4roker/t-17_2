using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _17_2
{
    /// <summary>
    /// Класс описывающий сотрудника
    /// </summary>
    class Employee
    {
        //Поля класса сотрудника
        private string surname;
        private double minsalary;
        private double coeff;
        /// <summary>
        /// Свойства полей
        /// </summary>
        public string Surname { get => surname; set => surname = value; }
        public double Minsalary { get => minsalary; set => minsalary = value; }
        public double Coeff { get => coeff; set => coeff = value; }
        /// <summary>
        /// Конструктор без параметров 
        /// </summary>
        public Employee() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="minsalary"></param>
        /// <param name="coeff"></param>
        public Employee(string surname,double minsalary,double coeff)
        {
            this.surname = surname;
            this.minsalary = minsalary;
            this.coeff = coeff;
        }
        /// <summary>
        /// Метод вывода
        /// </summary>
        virtual public void ShowInfo()
        {
            WriteLine($"Фамилия: {surname}\nЗарплата: {minsalary}\nПовышающий коэфф.: {coeff}\nДоход:{Income()}");
        }
        /// <summary>
        /// Метод вычисления дохода
        /// </summary>
        /// <returns></returns>
        virtual public double Income()
        {
            return coeff * minsalary;
        }
    }
}
