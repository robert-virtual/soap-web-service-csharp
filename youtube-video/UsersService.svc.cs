using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using youtube_video.Models;

namespace youtube_video
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class UsersService : IUsersService
    {
        public List<User> users = new List<User>();
        public List<User> GetUsers()
        {
            //List<User> users2 = new List<User>();
            //var robert = new User() { Age = 23, Name = "Robert"};
            //var carlos = new User() { Age = 23, Name = "Carlos"};
            //users2.Add(robert);
            //users2.Add(carlos);

            // obtener users de base de datos

            // obtener users de otro servicio
            return users;
        }

        public BasicResponse<User> CreateUser(User user)
        {
            if (user == null)
            {
                return new BasicResponse<User>()
                {
                    Data = null,
                    Error = "No envio los argumentos necesarios"
                };
            }
            if (user.Name.Length == 0)
            {
                return new BasicResponse<User>()
                {
                    Data = null,
                    Error = "El argumento Name es invalido"
                };
            }
            if (user.Age <= 0)
            {
                return new BasicResponse<User>()
                {
                    Data = null,
                    Error = "El argumento Age es invalido"
                };
            }
            users.Add(user);

            return new BasicResponse<User>()
            {
                Data = user,
                Error = null
            };
        }
    }
}
