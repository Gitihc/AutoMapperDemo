using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMapper
{
    class Target2
    {
        public string name { get; set; }

        public int age { get; set; }

        public string className { get; set; }
        public override string ToString()
        {
            return string.Format("name:{0},age:{1},className:{2};", name,age,className);
        }
    }
}
