using System;
using System.Collections.Generic;
using System.Text;

namespace MiPrimeraBiblioteca.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Matricula { get; set; } = "";
        public string Programa { get; set; } = "";
        public string Grado { get; set; } = "";
        public string Status { get; set; } = "Activo";
        public string FotoUrl { get; set; } = "";
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
