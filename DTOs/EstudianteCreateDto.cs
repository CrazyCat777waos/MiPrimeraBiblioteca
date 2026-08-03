using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraBiblioteca.DTOs
{
    public class EstudianteCreateDto
    {
        public string Nombre { get; set; } = "";
        public string Matricula { get; set; } = "";
        public string Programa { get; set; } = "";
        public string Grado { get; set; } = "";
        public string Status { get; set; } = "Activo";
        public string FotoUrl { get; set; } = "";
    }
}
