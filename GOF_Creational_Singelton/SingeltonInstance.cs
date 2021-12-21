using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Creational_Singleton
{
    public class SingletonInstance
    {
        private static SingletonInstance _instance;
        private SingletonInstance(){}

        public static SingletonInstance GetInstance()
        {
            if (_instance == null)
                _instance = new SingletonInstance();

                return _instance;
        }

    }
}
