using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzON.Negocio.Modelo;

namespace PizzON.Negocio.Repositorio
{
    public interface IRepositorioManager : IDisposable
    {
        void SaveChanges();
        Task SaveChangesAsync();

        IRepositorio<Usuarios> User { get; }
        IRepositorio<Empleado> Employee { get; }
        IRepositorio<Cliente> Client { get; }
        IRepositorio<Direccion> Address { get; }
        IRepositorio<Telefono> Phone { get; }
        IRepositorio<Empresa> Company { get; }
        IRepositorio<Producto> Prouct { get; }
        IRepositorio<Ingrediente> Ingredient { get; }
        IRepositorio<Pedido> Order { get; }
        IRepositorio<DetallesPedido> OrderDetails { get; }
        IRepositorio<IngredientesProducto> ProductIngredient { get; }

    }
        


    public class RepositorioManager : IRepositorioManager
    {
        //Contexto
        private PizzonEntities _context;
        //Entidades privadas
        private IRepositorio<Usuarios> _user;
        private IRepositorio<Empleado> _employee;
        private IRepositorio<Cliente> _client;
        private IRepositorio<Direccion> _address;
        private IRepositorio<Telefono> _phone;
        private IRepositorio<Empresa> _company;
        private IRepositorio<Producto> _product;
        private IRepositorio<Ingrediente> _ingredient;
        private IRepositorio<Pedido> _order;
        private IRepositorio<DetallesPedido> _orderDetails;
        private IRepositorio<IngredientesProducto> _productIngredient;



        //Cosntructor
        public RepositorioManager(
            IRepositorio<Usuarios> repositorioUser,
            IRepositorio<Empleado> repositorioEmployee,
            IRepositorio<Cliente> repositorioClient,
            IRepositorio<Direccion> repositorioAddress,
            IRepositorio<Telefono> repositorioPhone,
            IRepositorio<Empresa> repositorioCompany,
            IRepositorio<Producto> repositorioProduct,
            IRepositorio<Ingrediente> repositorioIngredient,
            IRepositorio<Pedido> repositorioOrder,
            IRepositorio<DetallesPedido> repositorioOrderDetails,
            IRepositorio<IngredientesProducto> repositorioProductIngredient)
        {
            _context = repositorioUser.ContextoDB<PizzonEntities>();

            _user = repositorioUser;
            _employee = repositorioEmployee;
            _client = repositorioClient;
            _address = repositorioAddress;
            _phone = repositorioPhone;
            _company = repositorioCompany;
            _product = repositorioProduct;
            _ingredient = repositorioIngredient;
            _order = repositorioOrder;
            _orderDetails = repositorioOrderDetails;
            _productIngredient = repositorioProductIngredient;


        }

        //Entidades
        public IRepositorio<Usuarios> User
        {
            get
            {
                return _user;
            }
        }

        public IRepositorio<Empleado> Employee
        {
            get
            {
                return _employee;
            }
        }

        public PizzonEntities Contexto
        {
            get
            {
                return _context;
            }
        }

        public IRepositorio<Cliente> Client
        {
            get
            {
                return _client;
            }
        }

        public IRepositorio<Direccion> Address
        {
            get
            {
                return _address;
            }
        }

        public IRepositorio<Telefono> Phone
        {
            get
            {
                return _phone;
            }
        }

        public IRepositorio<Empresa> Company
        {
            get
            {
                return _company;
            }
        }

        public IRepositorio<Producto> Prouct
        {
            get
            {
                return _product;
            }
        }

        public IRepositorio<Ingrediente> Ingredient
        {
            get
            {
                return _ingredient;
            }
        }

        public IRepositorio<Pedido> Order
        {
            get
            {
                return _order;
            }
        }

        public IRepositorio<DetallesPedido> OrderDetails
        {
            get
            {
                return _orderDetails;
            }
        }

        public IRepositorio<IngredientesProducto> ProductIngredient
        {
            get
            {
                return _productIngredient;
            }
        }



        //SAVE CHANGES
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
