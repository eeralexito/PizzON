using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzON.Negocio.Modelo;
using PizzON.Negocio.Repositorio;

namespace PizzON.Negocio.API
{
    public interface IEmployeesAPI
    {
        Task NewEmployee(Empleado emp);
        Task<List<Empleado>> getChefs();
        Task<List<Empleado>> getWaiters();
        Task<List<Empleado>> getDelivers();
        Task<List<Empleado>> getReceptionists();
        Task<List<Empleado>> getAllEmployees();

    }
    public class EmployeesAPI : IEmployeesAPI
    {
        private readonly IRepositorioManager _repManager;

        public EmployeesAPI(IRepositorioManager repositorioManager)
        {
            _repManager = repositorioManager;
        }
        
        public async Task NewEmployee(Empleado emp)
        {
            _repManager.Employee.Add(emp);
            await _repManager.SaveChangesAsync();
        }

        public Task<List<Empleado>> getChefs()
        {
            return Task.Run(() =>
            {
                return _repManager.Employee.GetAll(u => u.tipo_empleado == "Cocinero/a").ToList();
            });           
            
        }

        public Task<List<Empleado>> getWaiters()
        {
            return Task.Run(() =>
            {
                return _repManager.Employee.GetAll(u => u.tipo_empleado == "Camarero/a").ToList();
            });

        }

        public Task<List<Empleado>> getDelivers()
        {
            return Task.Run(() =>
            {
                return _repManager.Employee.GetAll(u => u.tipo_empleado == "Repartidor/a").ToList();
            });

        }

        public Task<List<Empleado>> getReceptionists()
        {
            return Task.Run(() =>
            {
                return _repManager.Employee.GetAll(u => u.tipo_empleado == "Recepcionista").ToList();
            });

        }

        public Task<List<Empleado>> getAllEmployees()
        {
            return Task.Run(() =>
            {
                return _repManager.Employee.GetAll().ToList();
            });

        }
    }
}
