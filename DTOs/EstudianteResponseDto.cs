using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraBiblioteca.DTOs
{
    public class EstudianteResponseDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Matricula { get; set; } = "";
        public string Programa { get; set; } = "";
        public string Grado { get; set; } = "";
        public string Status { get; set; } = "";
        public string FotoUrl { get; set; } = "";
        public DateTime FechaCreacion { get; set; }
    }
}
