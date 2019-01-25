using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhmLawCalc
{
    class Battery
    {
        #region FIELDS
        private string _brand;
        private double _mah;
        private double _amp;
        private string _size;
        private double _volt;

        #endregion

        #region PROPERTIES
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public double MAH
        {
            get { return _mah; }
            set { _mah = value; }
        }

        public double Amp
        {
            get { return _amp; }
            set { _amp = value; }
        }
        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public double Volt
        {
            get { return _volt; }
            set { _volt = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public Battery()
        {

        }
        #endregion

        #region METHODS

        #endregion

    }
}

