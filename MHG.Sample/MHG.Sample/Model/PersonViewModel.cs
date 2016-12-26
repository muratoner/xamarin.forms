using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MHG.Sample.Annotations;
using Xamarin.Forms;

namespace MHG.Sample.Model {
    public class PersonViewModel : INotifyPropertyChanged
    {
        private List<Person> _persons;

        public List<Person> Persons
        {
            get { return _persons; }
            set
            {
                _persons = value;
                OnPropertyChanged();
            }
        }
        
        public Command Command
        {
            get
            {
                return new Command(() =>
                {
                    
                });
            }
        }

        public PersonViewModel()
        {
            var pers = new List<Person>();
            for (int i = 0; i < 10; i++)
                pers.Add(new Person(i, Faker.Name.First(), Faker.Name.Last(), Faker.RoboHash.Image()));
            Persons = pers;
        } 

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
