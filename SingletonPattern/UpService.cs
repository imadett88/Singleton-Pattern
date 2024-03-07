using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
   class UpService
    {
        private UpService(){}

        public int Id { get; private set; }

        private static UpService _instance;
        private static readonly object _lock = new object();

         public static UpService GetUpService(int id)
        {
            if(_instance == null)
            {
                lock (_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new UpService();
                        _instance.Id = id;
                    }
                }
            }
            return _instance;
        }
    }
}
