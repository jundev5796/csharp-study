using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_part3
{
    // 3. get/set type function
    // 4. property (shorter way of get/set)
    class Person
    {
        // most shortened version of property
        private int count = 100;
        public string Name { get; set; } //자동 구현 프로퍼티
        public int Count
        {
            get { return count; } //읽기만 가능
        }

        public float Balance { get; private set; } //외부 변경 불가

        public void AddBal()
        {
            Balance += 100;
        }

        //private string name;

        //public string Name
        //{
        //    get { return name; } // getter
        //    set { name = value; } // setter
        //}

        // get/set
        //private string name; // protected variable

        //// set value (setter)
        //public void SetName(string newName)
        //{
        //    name = newName;
        //}

        //// get value (getter)
        //public string GetName()
        //{
        //    return name;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            //C#에서 get/set 방식의 함수와 프로퍼티 비교
            //C#에서는 객체의 값을 읽고(get), 설정(set)하는
            //방식으로 함수(get/set 메서드) 또는
            //**프로퍼티(Property)**를 사용할 수 있습니다.
            //Person p = new Person();

            //p.Name = "Tom";

            //p.AddBal();

            //Console.WriteLine("Name: " + p.Name + "Count: " + p.Count + "Balance" + p.Balance);

            //p.SetName("Tom");

            //Console.WriteLine("Name: " + p.GetName());
        }
    }
}
