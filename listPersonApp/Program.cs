using appListaPerson.controllers;
using appListaPerson.models;
using System;

namespace listPersonApp
{
    class Program
    {
        public static void Main(string[] args)
        {

            PersonController obj = new();
            int opcion = 0;

            do
            {
                Console.WriteLine("** menu principal **" +
                    "\n 1. Agregar persona" +
                    "\n 2. Mostrar la lista " +
                    "\n 3. Eliminar la lista " +
                    "\n 4. Actualizar la lista " +
                    "\n 5. Salir" +
                    "\n elige tu opcion :)");

                var data = Console.ReadLine();
                if (data != null)
                {
                    opcion = int.Parse(data);
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Escriba el id: ");
                        var inputId = Console.ReadLine();
                        Console.WriteLine("Escriba el nombre: ");
                        var inputName = Console.ReadLine();
                        Console.WriteLine("Escriba la edad: ");
                        var inputAge = Console.ReadLine();

                        if (inputId != null && inputName != null && inputAge != null)
                        {
                            obj.AddPerson(new Person(
                                int.Parse(inputId),
                                inputName.ToString(),
                                int.Parse(inputAge)
                                ));
                        }

                        break;

                    case 2:
                        Console.WriteLine(obj.ShowList());
                        break;

                    case 3:
                        Console.WriteLine("Escriba el id del la persona a eliminar");
                        var IdDelete = Console.ReadLine();
                        obj.DeletePerson(int.Parse(IdDelete));
                        break;
                    case 4:

                        Console.WriteLine("Escriba el id del la persona");
                        var IdSearch = Console.ReadLine();

                        Console.WriteLine("Escriba el id: ");
                        var Id = Console.ReadLine();
                        Console.WriteLine("Escriba el nombre: ");
                        var Name = Console.ReadLine();
                        Console.WriteLine("Escriba la edad: ");
                        var Age = Console.ReadLine();

                        if (Id != null && Name != null && Age != null)
                        {
                            obj.UpdatePerson(int.Parse(IdSearch), new Person(
                                int.Parse(Id),
                                Name,
                                int.Parse(Age)
                                ));
                        }
                        break;
                    case 5:
                        opcion = 5;
                        break;
                    default:
                        Console.WriteLine("elige una opcion del menu");
                        break;
                }

            } while (opcion != 5);
        }

    }
}

