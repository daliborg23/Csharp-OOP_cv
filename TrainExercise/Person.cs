using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainExercise {
    public class Person {
		private string firstName;
		private string lastName;
		#region properties
		public string LastName {
			get { return lastName; }
			set { lastName = value; }
		}

		public string FirstName {
			get { return firstName; }
			set { firstName = value; }
		}
		#endregion
        public Person(string firstname, string lastname) {
			FirstName = firstname;
			LastName = lastname;
        }
        public override string ToString() {
			return $"{FirstName} {LastName}";
        }
    }
}
