using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleListOfObjects
{
    class PersonCar
    {
        public enum MakeName
        {
            NONE,
            DODGE,
            FORD,
            CHEVY
        }

        private int _year;

        private string _model;

        private double _engine;

        private MakeName _make;

        private bool _isHardTop;

        public bool IsHardTop
        {
            get { return _isHardTop; }
            set { _isHardTop = value; }
        }

        public MakeName Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public double Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public PersonCar()
        {

        }
    }
}
