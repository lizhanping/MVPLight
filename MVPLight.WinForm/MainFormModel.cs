using MVPLight.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace MVPLight.WinForm
{
    public class MainFormModel : ModelBase
    {
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
                OnPropertyChanged(nameof(Name));
            }
        }

        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
