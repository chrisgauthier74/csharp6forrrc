using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class interface IMachine
    {
        bool start();
        bool stop();
    }


    class interfaces1 : IMachine
    {
        static void Main(string[] args)
        {
        }

        public bool start()
        {
            throw new NotImplementedException();
        }

        public bool stop()
        {
            throw new NotImplementedException();
        }
    }
}
