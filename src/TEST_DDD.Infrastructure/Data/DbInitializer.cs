using System.Linq;
using TEST_DDD.ApplicationCore.Entity;

namespace TEST_DDD.Infrastructure.Data
{
    public class DbInitializer
    {

        public static void DbInitialize(ClienteContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
                {
                    new Cliente
                    {
                        Nome = "Marcio Osvaldo Papke",
                        CPF = "05297261902"
                    },
                       new Cliente
                    {
                        Nome = "Talita Bianca Brunharo",
                        CPF = "31277565802"
                    }
                };

            context.AddRange(clientes);

            var contatos = new Contato[]
                {
                    new Contato
                    {
                        Nome = "Contato 1",
                        Telefone = "96358-6587",
                        Email  = "contato1@gmail.com",
                        Cliente = clientes[0]
                    },
                    new Contato
                    {
                        Nome = "Contato 2",
                        Telefone = "99865-65256",
                        Email  = "contato2@gmail.com",
                        Cliente = clientes[1]
                    }
                };

            context.AddRange(contatos);
            context.SaveChanges();
        }
    }
}
