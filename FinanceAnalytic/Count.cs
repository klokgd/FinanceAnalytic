using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceAnalytic
{
    public class Count //класс счетов
    {
        public double Sum { get; set; }
        public string Name { get; set; }

        public Count(double sum, string name) //создание новых счетов
        {
            Sum = sum;
            Name = name;
        }
        public void PlusToSum(double value) //добавление суммы к счету
        {
            Sum += value;
        }
        public void MinusToSum(double value) //отнимание числа от суммы счета
        {
            Sum -= value;
        }
        public void RenameCount(string name) //Переименование счета
        {
            Name = name;
        }


    }

}
