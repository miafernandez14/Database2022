
using Database2022.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Xml.Serialization;
using Xamarin.Forms;

namespace Database2022.ViewModels
{
    internal class InsertViewModel : BaseViewModel
    {
        private string firstName;
        public String Firstame
        {
            get { return firstName; }
            set { SetValue(ref this.firstName, value); }
        }
        private string lastName;

        public String LastName
        {
            get { return lastName; }
            set { SetValue(ref this.lastName, value);}
        }
        private int personId;
        public int PersonId
        {
            get { return personId; }
            set { SetValue(ref this.personId, value); }
        }
        public ICommand InsertCommand { get; set; }

        public InsertViewModel() {

            PersonService service = new PersonService();

            InsertCommand = new Command(() =>
            {
                PersonService service = new PersonService();
                if (PersonId != 0)
                {
                    Console.WriteLine(PersonId);
                    Firstame = "";
                    LastName = "";
                    PersonId = 0;
                }
                else
                {
                    int newPersonId = service.Get().Count + 1;
                    service.Create(new Person { FirstName = Firstame,LastName = LastName, PersonId = newPersonId });
                    firstName = "";
                    lastName = "";
                }
                
            });
        }
    }
}
