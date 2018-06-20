using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMapperConfiguration.Configure();
            //InitMaper();
            //test1();
            //test2();
            test3();
        }

        static void test1()
        {
            var source = new Source { id = 1, name = "source" };
            var target = AutoMapperHelper.MapTo<Target>(source);
            Console.WriteLine(target.id);
            Console.WriteLine(target.name);
            Console.ReadLine();
        }
        static void test2()
        {
            var source1 = new Source { id = 1, name = "source1" };
            var source2 = new Source { id = 2, name = "source2" };
            var source3 = new Source { id = 3, name = "source3" };
            var listSource = new List<Source> { source1, source2, source3 };
            var listTarget = AutoMapperHelper.MapToList<Target>(listSource);
            foreach (var target  in listTarget)
            {
                Console.WriteLine(target.ToString());
            }
            Console.ReadLine();
        }

        static void test3()
        {
            var source1 = new Source { id = 1, name = "source1" };
            var target2 = Mapper.Map<Target2>(source1);
            Console.WriteLine(target2.ToString());
            Console.ReadLine();
        }


    }
}
