using System;
using System.Collections.Generic;
using System.Text;


namespace MyDemoProject
{
    class MyNumber:Ieven
    {

        private int _number;

        MyNumber(int number)
        {
            _number = number;
        }

        public bool IsEven()
        {
            return _number % 2 == 0;
        }
    }
}
