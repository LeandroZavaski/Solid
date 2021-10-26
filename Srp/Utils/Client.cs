using System;

namespace Srp.Utils
{
    public class Client
    {
        public void CreateCLient()
        {
            var msg = "Cliente Criado!";
            Console.WriteLine(msg);

            var notify = new Notify();
            notify.Notification(this);
        }

        public void ReadClient()
        {
            var msg = "Listando Cliente!";
            Console.WriteLine(msg);

            var notify = new Notify();
            notify.Notification(this);
        }

        public void UpdateClient()
        {
            var msg = "Atualizando Cliente!";
            Console.WriteLine(msg);

            var notify = new Notify();
            notify.Notification(this);
        }

        public void DeleteClient()
        {
            var msg = "Removendo Cliente!";
            Console.WriteLine(msg);

            var notify = new Notify();
            notify.Notification(this);
        }
    }
}
