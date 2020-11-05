using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Circlecs
    {
        double _r;

        public double _R
        {
            get
            {
                return _r;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Not valid input");
                else
                {
                    _r = value;
                }
            }
        }
        public Circlecs()
        {
            _r = 0;
        }
        public Circlecs(double _r)
        {
            this._r = _r;
        }
        public double S
        {
            get
            {
                return Math.PI * _r * _r;
            }
            
        }
        public override string ToString()
        {
            return $"Circle: radius= {_R}; S= {S}";
        }
    }
    
}
