using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using PizzON.Negocio.API;
using PizzON.Negocio.Modelo;
using PizzON.Negocio.Repositorio;

namespace PizzON.Ninject
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            //API modulos
            Bind<IUsersAPI>().To<UsersAPI>();
            Bind<IEmployeesAPI>().To<EmployeesAPI>();
            Bind<IProductsAPI>().To<ProductsAPI>();
            Bind<IIngredientsAPI>().To<IngredientsAPI>();

            //Inyeccion al constructor del repositorio general
            Bind<IRepositorioManager>().ToMethod(
                c =>
                {
                    var context = new PizzonEntities();
                    return new RepositorioManager(
                        new Repositorio<Usuarios>(context),
                        new Repositorio<Empleado>(context),
                        new Repositorio<Cliente>(context),
                        new Repositorio<Direccion>(context),
                        new Repositorio<Telefono>(context),
                        new Repositorio<Empresa>(context),
                        new Repositorio<Producto>(context),
                        new Repositorio<Ingrediente>(context),
                        new Repositorio<Pedido>(context),
                        new Repositorio<DetallesPedido>(context),
                        new Repositorio<IngredientesProducto>(context)
                        );
                });
        }
    }
}
