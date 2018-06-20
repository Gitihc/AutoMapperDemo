using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMapper
{
    class Target
    {
        public int id { get; set; }

        public string name { get; set; }

        public override string ToString()
        {
            return string.Format("id:{0},name:{1};", id, name);
        }
    }
}
