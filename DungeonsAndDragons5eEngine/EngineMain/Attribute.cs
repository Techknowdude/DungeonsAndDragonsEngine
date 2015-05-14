using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineMain
{
    public class Attribute
    {
        #region Fields

        private string _name;
        private int _value;
        private const int Step = 2;
        private const int MedianMod = 5;

        #endregion

        #region Properties
        /// <summary>
        /// The value of the attribute. AKA the score.
        /// </summary>
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        /// <summary>
        /// The modifier of the attibute. This measures the affectiveness of the attribute
        /// </summary>
        public int Modifier { get { return Value/Step - MedianMod;} }

        /// <summary>
        /// Description of the attribute
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        /// <summary>
        /// Creates a new attribute
        /// </summary>
        /// <param name="value">The score of the attribute</param>
        /// <param name="name">The name</param>
        public static Attribute CreateAttribute(int value, string name)
        {
            return new Attribute(value,name);
        }

        /// <summary>
        /// Creates a new attribute
        /// </summary>
        /// <param name="value">The score of the attribute</param>
        /// <param name="name">The name</param>
        private Attribute(int value, string name)
        {
            _value = value;
            _name = name;
        }

        public override string ToString()
        {
            return String.Format("Attribute {0}: Value: {1} ({2})",Name,Value,Modifier);
        }
    }
}
