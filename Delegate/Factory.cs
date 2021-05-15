using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate string CompareItems(Factory obj1, Factory obj2);
    public class Factory
    {
        string name;
        decimal salary;
        int numberWorkers;
        double amountEmissions;

        public Factory(string name, decimal salary, int numberWorkers, double amountEmissions)
        {
            this.name = name;
            this.salary = salary;
            this.numberWorkers = numberWorkers;
            this.amountEmissions = amountEmissions;
        }

        static string CompareSalary(Factory factory1, Factory factory2)
        {
            if (factory1.salary < factory2.salary)
            {
                return factory2.name;
            }
            else if (factory1.salary > factory2.salary)
            {
                return factory1.name;
            }
            else
            {
                return "Они одинаковы";
            }
        }

        static string CompareNumberWorkers(Factory factory1, Factory factory2)
        {
            if (factory1.salary < factory2.salary)
            {
                return factory2.name;
            }
            else if (factory1.salary > factory2.salary)
            {
                return factory1.name;
            }
            else
            {
                return "Они одинаковы";
            }
        }

        static string CompareAmountEmissions(Factory factory1, Factory factory2)
        {
            if (factory1.salary < factory2.salary)
            {
                return factory2.name;
            }
            else if (factory1.salary > factory2.salary)
            {
                return factory1.name;
            }
            else
            {
                return "Они одинаковы";
            }
        }

        public static CompareItems SortCompareSalary
        {
            get { return (new CompareItems(CompareSalary)); }
        }
        public static CompareItems SortCompareNumberWorkers
        {
            get { return (new CompareItems(CompareNumberWorkers)); }
        }
        public static CompareItems SortCompareAmountEmissions
        {
            get { return (new CompareItems(CompareAmountEmissions)); }
        }
    }
}
