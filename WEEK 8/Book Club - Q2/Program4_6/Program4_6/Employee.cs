using System;

namespace Program4_6
{
    class Employee
    {

		private string firstName;
		private string lastName;
		private string number;

		public Employee()
		{
		}

		public Employee(string firstName, string lastName, string number)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Number = number;
		}

		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				if (value.Length > 50)
				{
					throw new ArgumentException(
						"Maximum length of first name is 50 characters.");
				}
				firstName = value;
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				if (value.Length > 50)
				{
					throw new ArgumentException(
						"Maximum length of last name is 50 characters.");
				}
				lastName = value;
			}
		}

		public string Number
		{
			get
			{
				return number;
			}
			set
			{
				if (value.Length > 50)
				{
					throw new ArgumentException(
						"Maximum length of employee number is 50 characters.");
				}
				number = value;
			}
		}

		public virtual string GetDisplayText() => firstName + " " + lastName + " Employee #: " + number;

	}
}
}
