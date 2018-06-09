using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Kiddo.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new KiddoContext(serviceProvider.GetRequiredService<DbContextOptions<KiddoContext>>()))
            {
                
                // Delete existing records in database
                
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Requisitador");

                // Seed database with records

                context.Requisitador.AddRange(
                    new Requisitador
                    {
                        Email = "email1@email.com",
                        Password = "12345",
                        Nome = "Requisitador 1",
                        Foto = "https://upload.wikimedia.org/wikipedia/commons/7/70/User_icon_BLACK-01.png",
                        Localizacao = "Braga, Portugal",
                        Contacto = "911111111",
                        Pagamento = "1234567890"
                    },

                    new Requisitador
                    {
                        Email = "email2@email.com",
                        Password = "12345",
                        Nome = "Requisitador 2",
                        Foto = "https://upload.wikimedia.org/wikipedia/commons/7/70/User_icon_BLACK-01.png",
                        Localizacao = "Braga, Portugal",
                        Contacto = "922222222",
                        Pagamento = "1234567890"
                    },

                    new Requisitador
                    {
                        Email = "email3@email.com",
                        Password = "12345",
                        Nome = "Requisitador 3",
                        Foto = "https://upload.wikimedia.org/wikipedia/commons/7/70/User_icon_BLACK-01.png",
                        Localizacao = "Braga, Portugal",
                        Contacto = "933333333",
                        Pagamento = "1234567890"
                    },

                    new Requisitador
                    {
                        Email = "email4@email.com",
                        Password = "12345",
                        Nome = "Requisitador 4",
                        Foto = "https://upload.wikimedia.org/wikipedia/commons/7/70/User_icon_BLACK-01.png",
                        Localizacao = "Braga, Portugal",
                        Contacto = "944444444",
                        Pagamento = "1234567890"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
