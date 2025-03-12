using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session6
{
    class SnackBag
    {
        string Name = "새우깡한봉지";
        int Price = 1500;
        int MaxWeight = 80;
        Random rand = new Random();
        List<SnackUnit> snackBag { get; set; } = new List<SnackUnit>();

        void AddSnackUnit(SnackUnit unit)
        {
            snackBag.Add(unit);
        }

        int TotalWeight(List<SnackUnit> snackBag)
        {
            int sum = 0;
            foreach (var unit in snackBag)
            {
                sum += unit.Weight;
            }

            return sum;
        }

        public void FillBag()
        {
            while (TotalWeight(snackBag) < MaxWeight)
            {
                AddSnackUnit(new SnackUnit());
            }
        }

        public SnackUnit GetRandomSnackUnit()
        {
            int index = rand.Next(snackBag.Count);
            SnackUnit pickedUnit = snackBag[index];
            snackBag.RemoveAt(index);
            return pickedUnit;
        }

        public override string ToString()
        {
            return $"봉지 이름 : {Name}, 가격:{Price}, 최대 무게 : {MaxWeight}\n +" +
                $"-> 현재 과자 개수 {snackBag.Count}, 현재 총 무게 : {TotalWeight(snackBag)}";
        }
        public SnackBag()
        {
            FillBag();
        }
    }
}
