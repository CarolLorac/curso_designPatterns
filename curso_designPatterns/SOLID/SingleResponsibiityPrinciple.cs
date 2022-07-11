using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_designPatterns.SOLID
{
    public class SingleResponsibiityPrinciple {}

    //Correct
    class Client
    {
        public void Create()
        { }

        public void Read()
        { }

        public void Update()
        { }

        public void Delete()
        { }
    }

    class Notify
    {
        public Notify(Client client)
        {
            Console.WriteLine("Notificando cliente!!");
        }
    }

    //Incorrect
    //Esta classe está incorreta, pois possui objetivos diferentes. O método notify está no lugar errado,
    //enquanto os outros métodos estão "administrando" o cliente, o notify vai mandar uma notificação

    class ClientIncorrect
    {
        public void CreateClient()
        { }

        public void ReadClient()
        { }

        public void UpdateClient()
        { }

        public void DeleteClient()
        { }

        public void NotifyClient()
        { }
    }
}
