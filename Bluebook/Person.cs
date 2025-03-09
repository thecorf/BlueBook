using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluebook
{
    internal class Person
    {
		private int _age;

		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _class;

		public string Class
		{
			get { return _class; }
			set { _class = value; }
		}
		private string _birthdate;

		public string Birthdate
		{
			get { return _birthdate; }
			set { _birthdate = value; }
		}


		public override string ToString()
        {
            return $"age {Age}\nname {Name}\nclass {Class}\nbirthdate {Birthdate}";
        }

    }
}
