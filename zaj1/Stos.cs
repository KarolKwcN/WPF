using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj1
{
    public class Stos
    {
        List<String> stosik { get; set; }

        public Stos()
        {
            this.stosik = new List<string>();
        }

        public void push (string item)
        {
            this.stosik.Add(item);
        }

        public void pop()
        {
            this.stosik.RemoveAt(stosik.Count -1);
        }

        public string top()
        {
            return this.stosik.Last();

        }

        public bool empty()
        {
            if(this.stosik.Count == 0)
            {

            }

            return false;
        }
    }
}
