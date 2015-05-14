using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EngineMain
{
    public class Dice : Random
    {
        #region Fields
        private int _sides;
        static List<Dice> _savedDies = new List<Dice>();
        private int _lastRoll = -1;
        #endregion

        #region Properties

        /// <summary>
        /// The number of sides the die has
        /// </summary>
        public int Sides
        {
            get { return _sides; }
            set { _sides = value; }
        }

        /// <summary>
        /// Returns the value of the last roll
        /// </summary>
        public int LastRoll
        {
            get { return _lastRoll; }
            set { _lastRoll = value; }
        }

        #endregion

        #region StaticRolls
        public static Dice GetD2()
        {
            Dice d2 = _savedDies.FirstOrDefault(x => x.Sides == 2);
            if (d2 == null)
            {
                d2 = new Dice(2);
                _savedDies.Add(d2);
            }
            return d2;
        }

        public static Dice GetD3()
        {
            Dice d3 = _savedDies.FirstOrDefault(x => x.Sides == 3);
            if (d3 == null)
            {
                d3 = new Dice(3);
                _savedDies.Add(d3);
            }
            return d3;
        }
        public static Dice GetD4()
        {
            Dice d4 = _savedDies.FirstOrDefault(x => x.Sides == 4);
            if (d4 == null)
            {
                d4 = new Dice(4);
                _savedDies.Add(d4);
            }
            return d4;
        }
        public static Dice GetD6()
        {
            Dice d6 = _savedDies.FirstOrDefault(x => x.Sides == 6);
            if (d6 == null)
            {
                d6 = new Dice(6);
                _savedDies.Add(d6);
            }
            return d6;
        }
        public static Dice GetD8()
        {
            Dice d8 = _savedDies.FirstOrDefault(x => x.Sides == 8);
            if (d8 == null)
            {
                d8 = new Dice(8);
                _savedDies.Add(d8);
            }
            return d8;
        }
        public static Dice GetD10()
        {
            Dice d10 = _savedDies.FirstOrDefault(x => x.Sides == 10);
            if (d10 == null)
            {
                d10 = new Dice(10);
                _savedDies.Add(d10);
            }
            return d10;
        }
        public static Dice GetD12()
        {
            Dice d12 = _savedDies.FirstOrDefault(x => x.Sides == 12);
            if (d12 == null)
            {
                d12 = new Dice(12);
                _savedDies.Add(d12);
            }
            return d12;
        }
        public static Dice GetD20()
        {
            Dice d20 = _savedDies.FirstOrDefault(x => x.Sides == 20);
            if (d20 == null)
            {
                d20 = new Dice(20);
                _savedDies.Add(d20);
            }
            return d20;
        }
        #endregion

        public Dice(int sides) 
            : base()
        {
            _sides = sides;
        }

        /// <summary>
        /// Rolls the die and saves the value in LastRoll
        /// </summary>
        /// <returns>Int value between 1 and [Sides]</returns>
        public int Roll()
        {
            _lastRoll = (base.Next()%_sides) + 1;
            return _lastRoll;
        }

        public override string ToString()
        {
            return String.Format("{0} Sided die", _sides);
        }
    }
}
