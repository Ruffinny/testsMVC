using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_mvc_webapp.Models{
    public class Producto{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto {get; set;}
        [Display(Name = "Ingrese el Código del Producto")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} Se requiere")]
        public string ProductoCodigo  {get; set;}
        [Display(Name = "Ingrese el Tipo del Producto")]
        [StringLength(50)]
        [Required(ErrorMessage = "{0} Se requiere")]
        public string ProductoTipo { get; set; }
        [Display(Name = "Ingrese la Descripción del Producto")]
        [StringLength(150)]
        public string Descripcion { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        [StringLength(150)]
        [Required(ErrorMessage = "{0} Se requiere")]
        public decimal PrecioUnidad { get; set; }
        [Display(Name = "Ingrese la Cantidad del Producto")]
        [Required(ErrorMessage = "{0} Se requiere")]
        public int CantidadStock { get; set; }
    }
}