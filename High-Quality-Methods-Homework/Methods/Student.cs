using System;
using System.Globalization;

namespace Methods
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string birthPlace;
        private DateTime birthDate;
        private string additionalInfo;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value != null)
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentNullException("The first name cannot be null!");
                }
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value != null)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentNullException("The last name cannot be null!");
                }
            }
        }
        public string BirthPlace
        {
            get
            {
                return this.birthPlace;
            }
            set
            {
                if (value != null)
                {
                    this.birthPlace = value;
                }
                else
                {
                    throw new ArgumentNullException("The birth place cannot be null!");
                }
            }
        }
        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }
            set
            {
                if (value != null)
                {
                    this.birthDate = value;
                }
                else
                {
                    throw new ArgumentNullException("The birth date cannot be null!");
                }
            }
        }
        public string AdditionalInfo
        {
            get
            {
                return this.additionalInfo;
            }
            set
            {
                this.additionalInfo = value;
            }
        }
        
        public Student(string firsName, string lastName, string birthPlace, string birthDate, string additionalInfo) 
        {
            this.FirstName = firsName;
            this.LastName = lastName;
            this.BirthPlace = birthPlace;
            this.BirthDate = DateTime.ParseExact(birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            this.AdditionalInfo = additionalInfo;
        }

        public Student(string firsName, string lastName, string birthPlace, string birthDate)
            : this(firsName, lastName, birthPlace, birthDate, null)
        { 
        }
    }
}
