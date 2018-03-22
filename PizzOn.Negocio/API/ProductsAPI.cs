using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzON.Negocio.Modelo;
using PizzON.Negocio.Repositorio;

namespace PizzON.Negocio.API
{
    public interface IProductsAPI
    {
        Task NewProduct(Producto product);
        Task EditProduct(Producto producto);
        Task DeleteProduct(Producto product);

        Task<List<Producto>> GetPizzas();
        Task<List<Producto>> GetSandwichs();
        Task<List<Producto>> GetSalad();
        Task<List<Producto>> GetAppetizer();
        Task<List<Producto>> GetSoda();
        Task<List<Producto>> GetDessert();
        Task<List<Producto>> GetAllProducts();

        int CountCategories();
        List<String> GetCategories();

    }
    public class ProductsAPI : IProductsAPI
    {
        private readonly IRepositorioManager _repManager;

        public ProductsAPI(IRepositorioManager repositorioManager)
        {
            _repManager = repositorioManager;
        }

        public async Task NewProduct(Producto product)
        {
            _repManager.Prouct.Add(product);
            await _repManager.SaveChangesAsync();
        }
        

        public Task EditProduct(Producto producto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(Producto product)
        {
            throw new NotImplementedException();
        }

        public Task<List<Producto>> GetPizzas()
        {
            return Task.Run(() =>
            {
                return _repManager.Prouct.GetAll(p => p.categoria == "PIZZA").ToList();
            });
        }

        public Task<List<Producto>> GetSandwichs()
        {
            return Task.Run(() =>
            {
                return _repManager.Prouct.GetAll(p => p.categoria == "BOCATA").ToList();
            });
        }

        public Task<List<Producto>> GetSalad()
        {
            return Task.Run(() =>
            {
                return _repManager.Prouct.GetAll(p => p.categoria == "ENSALADA").ToList();
            });
        }

        public Task<List<Producto>> GetAppetizer()
        {
            return Task.Run(() =>
            {
                return _repManager.Prouct.GetAll(p => p.categoria == "ENTRANTE").ToList();
            });
        }

        public Task<List<Producto>> GetSoda()
        {
            return Task.Run(() =>
            {
                return _repManager.Prouct.GetAll(p => p.categoria == "REFRESCO").ToList();
            });
        }

        public Task<List<Producto>> GetDessert()
        {
            return Task.Run(() =>
            {
                return _repManager.Prouct.GetAll(p => p.categoria == "POSTRE").ToList();
            });
        }
        public Task<List<Producto>> GetAllProducts()
        {
            return Task.Run(() =>
            {
                return _repManager.Prouct.GetAll().ToList();
            });
        }

        public int CountCategories()
        {
            var list = _repManager.Prouct.GetAll();
            return list.GroupBy(p => p.categoria).Count();
            
        }

        public List<String> GetCategories()
        {
            List<String> auxList = new List<String>();
            var list = _repManager.Prouct.GetAll().GroupBy(p => p.categoria).ToList();
            //Console.WriteLine("Tipo de la lista"+list.GetType());
            //foreach(var p in list)
            //{
            //    Console.WriteLine(p.ToString());
            //}
            foreach (var p in list)
            {
                auxList.Add(p.Key);
            }
            return auxList;
        }
    }
}
