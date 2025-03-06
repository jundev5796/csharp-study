using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_part4
{
    class MyResource
    {
        // destructor (소멸자)
        ~MyResource()
        {
            Console.WriteLine("삭제될때 호출");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // GC(Garbage Collector)에 의해 나중에 소멸자 호출
            // 가비지 컬렉션은 더이상 참조되지 않는 객체를 정리함
            MyResource r = new MyResource();
        }
    }
}
