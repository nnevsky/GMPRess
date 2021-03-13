using GMPress.Data.Entities;
using System.ComponentModel;

namespace GMPress.Administration.ViewModels
{
    public class PersonInfoController : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _patronimic;

        public Person EditPerson
        {
            get => new Person
            {
                PersonID = PersonID,

                FirstName = FirstName,
                LastName = LastName,
                Patronimic = Patronimic
            };
            set
            {
                PersonID = value.PersonID;

                FirstName = value.FirstName;
                LastName = value.LastName;
                Patronimic = value.Patronimic;
            }
        }

        public int PersonID { get; set; }

        public string FirstName 
        { 
            get => _firstName;
            set
            {
                _firstName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
            }
        }
        public string Patronimic 
        { 
            get => _patronimic;
            set
            {
                _patronimic = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Patronimic)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}