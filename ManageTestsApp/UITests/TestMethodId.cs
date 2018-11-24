using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests
{
    public class TestMethodIdAttribute : Attribute
    {
        private int id;

        public TestMethodIdAttribute(int _id)
        {
            this.id = _id;
        }

        public virtual int Id
        {
            get { return id;}
        }

        public int getId()
        {
            return this.id;
        }
    }
}
