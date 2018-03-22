using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzON.Negocio.Modelo;
using PizzON.Negocio.Repositorio;


namespace PizzON.Negocio.API
{
    //INTERFAZ
    public interface IUsersAPI
    {
        Task NewUser(Usuarios user);
        Task EditUser(Usuarios user);
        Task DeleteUser(Usuarios user);
        Usuarios GetUser(String user);
        Task<List<Usuarios>> GetAllUsers();
        Task<List<Usuarios>> GetEmployes();
        Task<List<Usuarios>> GetBoss();
        bool Connect(String user, String pasw);
        bool UserExist(String user);
    }

    //CLASE
    public class UsersAPI : IUsersAPI
    {
        private readonly IRepositorioManager _repManager;

        public UsersAPI(IRepositorioManager repositorioManager)
        {
            _repManager = repositorioManager;
        }

        public async Task NewUser(Usuarios user)
        {
            if (user.ValidarUsuario())
            {
                _repManager.User.Add(user);
               await  _repManager.SaveChangesAsync();
            }           
        }

        public async Task EditUser(Usuarios user)
        {
            _repManager.User.Edit(user);
            await _repManager.SaveChangesAsync();
        }

        public async Task DeleteUser(Usuarios user)
        {
            _repManager.User.Delete(user);
            await _repManager.SaveChangesAsync();
        }

        public Usuarios GetUser(String user)
        {
            return _repManager.User.GetOne(user);
        }

        public Task<List<Usuarios>> GetAllUsers()
        {   return Task.Run(() =>
            {
                return _repManager.User.GetAll().ToList();
            });
        }

        public Task<List<Usuarios>> GetEmployes()
        {
            return Task.Run(() =>
            {
                return _repManager.User.GetAll(u => u.privilegio == "empleado").ToList();
            });
        }

        public Task<List<Usuarios>> GetBoss()
        {
            return Task.Run(() =>
            {
                return _repManager.User.GetAll(u => u.privilegio == "jefe").ToList();
            });
        }

        public bool Connect(String id, String pasw)
        {
                var user = _repManager.User.GetOne(id);
            //Si no exise el usuario user sera "null" y al ser una programacion de cortocircuito cuando encuentre un true OR... 
            //sabe que haya lo que haiga a continuacion siempre sera true entonces no salta la excepcion de NullPointerException al intentar acceder a la contraseña del user null. =)
            if (user == null || user.contrasena != pasw)
                return false;
            return true;              
            
        }

        public bool UserExist(String user)
        {
            return _repManager.User.GetOne(user) != null;
        }



    }
}
