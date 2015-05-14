using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineMain
{
    public class Unit
    {
        #region Fields
        Attribute[] _attributes = new Attribute[6];
        private string _name;


        #endregion

        #region Properties
        public Attribute[] Attributes
        {
            get { return _attributes; }
            set { _attributes = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        
        public Unit(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            String attrString = _attributes.Aggregate(String.Empty, (current, attribute) => current + (attribute.ToString() + "\n"));

            return String.Format("{0}:\n{1}", Name, attrString);
        }
    }
}
