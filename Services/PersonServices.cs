using Microsoft.AspNetCore.Authentication.OAuth.Claims;

namespace Practica;

public static class personService
{
    static List<Person> ListPerson;

    static personService()
    {
        ListPerson = new List<Person>
        {
        new Person{id = 1,nombre = "Emanuel",apellido = "Ramirez",dni = 123546888, edad = 28},
        new Person{id = 2,nombre = "Daiana",apellido = "Rodriguez",dni = 564795520, edad = 26},
        new Person{id = 3,nombre = "Juan",apellido = "Gonzalez",dni = 45123157, edad = 30},
        new Person{id = 4,nombre = "Mateo",apellido = "Peña",dni = 987445555, edad = 3}
        };
    }

    public static List<Person> GetAll() => ListPerson;

    public static void Add(Person item)
    {
        ListPerson.Add(item);
    }
    public static Person? Get(int id) => ListPerson.FirstOrDefault(x => x.id == id);
    public static void delete(int id)
    {
        if (id == null)
        {
            return;
        }
        var borrar = ListPerson.FirstOrDefault(x => x.id == id);
        ListPerson.Remove(borrar);
    }

}

