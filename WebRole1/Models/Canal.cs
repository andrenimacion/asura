//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebRole1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Canal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Canal()
        {
            this.Mensajes = new HashSet<Mensaje>();
        }
    
        public int Id_canal { get; set; }
        public string Nombre_canal { get; set; }
        public string Seg_canal { get; set; }
        public string token_canal { get; set; }
        public int Id_admin { get; set; }
        public int Id_user { get; set; }
    
        public virtual Administrador Administrador { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mensaje> Mensajes { get; set; }
    }
}
