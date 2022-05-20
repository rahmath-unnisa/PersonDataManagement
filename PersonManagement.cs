using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class PersonManagement
    {
        List<Person> personlist = new List<Person>();
        public void AddDefaultData()
        {
            personlist.Add(new Person { SSN = 1, Name = "Asfiya", Address = "Belur", Age = 24 });
            personlist.Add(new Person { SSN = 2, Name = "Tanveer", Address = "Hassan", Age = 34 });
            personlist.Add(new Person { SSN = 3 ,Name = "Manha", Address = "Dubai", Age = 01 });
            personlist.Add(new Person { SSN = 4, Name = "Talha", Address = "Bangalore", Age = 16 });
            personlist.Add(new Person { SSN = 5, Name = "Mehwish", Address = "Delhi", Age = 22 });
            personlist.Add(new Person { SSN = 6, Name = "Mannan", Address = "Lucknow", Age = 56});
            personlist.Add(new Person { SSN = 7, Name = "Kainath", Address = "Hyderabad", Age = 67 });

            Display(personlist);
        }
      
        public void Display(IEnumerable<Person> list)
        {
            foreach (Person person in list) 
            {
                Console.WriteLine(person.SSN + " " + person.Name + " " + person.Address + " " + person.Age); ;
            }
        }
        public void GetTopRecords()
        {
            var Result = this.personlist.Where(x => x.Age < 60).Take(2);
            Display(Result);
        }
        public void GetRecords()
        {
            var result = this.personlist.Where(x => x.Age > 13 && x.Age < 18);
            Display(result);
        }

    }
}
