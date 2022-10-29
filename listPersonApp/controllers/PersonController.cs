using appListaPerson.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appListaPerson.controllers
{
    class PersonController
    {

        List<Person> listPerson = new();

        public void AddPerson(Person person)
        {
            if (person != null)
            {
                listPerson.Add(person);
            }
        }

        public int DeletePerson(int id)
        {
            int index = listPerson.FindIndex(x => x.Id == id);

            if (index < 0) return 0;

            listPerson.RemoveAt(index);

            return 1;
        }

        public void UpdatePerson(int id, Person person)
        {
            int index = listPerson.FindIndex(x => x.Id == id);
           
            Person p = listPerson.Find(x => x.Id == id);

            DeletePerson(p.Id);

            p.Id = person.Id;
            p.Name = person.Name;
            p.Age = person.Age;

            listPerson.Insert(index, p);

        }

        public string ShowList()
        {
            string text = "lista \n";
            foreach (Person person in listPerson)
            {
                text += "id: " + person.Id + "\n";
                text += "Nombre: " + person.Name + "\n";
                text += "Edad: " + person.Age + "\n";
            }

            return text;
        }
    }

}

