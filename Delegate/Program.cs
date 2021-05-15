using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory1 = new Factory("Краснодарская ТЭС", 2000.25m, 3700, 156187);
            Factory factory2 = new Factory("Краснодарская ГЭС", 1564m, 3915, 1564);

            Console.WriteLine("Выберите один из 3-х критериев сортировки предприятий данного региона:" +
                "\n1)З/п\n2)Количество рабочих\n3)Величина выбросов в атмосферу\n");

            int result = Convert.ToInt32(Console.ReadLine());

            switch (result)
            {
                case 1:
                    Console.WriteLine(Factory.SortCompareSalary(factory1, factory2));
                    break;
                case 2:
                    Console.WriteLine(Factory.SortCompareNumberWorkers(factory1, factory2));
                    break;
                case 3:
                    Console.WriteLine(Factory.SortCompareAmountEmissions(factory1, factory2));
                    break;
                default:
                    Console.WriteLine("Такого критерия сортировки нет!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
