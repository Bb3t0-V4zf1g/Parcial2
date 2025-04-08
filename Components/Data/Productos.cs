using System.ComponentModel.DataAnnotations;

namespace Parcial2.Components.Data
{
    public class Productos
    {
        [Required(ErrorMessage = "El inventario es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El inventario debe ser mayor a 0.")]
        public int Inventario { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un departamento.")]
        public string? Departamento { get; set; }
    }

}
