//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzON.Negocio.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingrediente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingrediente()
        {
            this.IngredientesProducto = new HashSet<IngredientesProducto>();
        }
    
        public int codigo { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IngredientesProducto> IngredientesProducto { get; set; }
    }
}
