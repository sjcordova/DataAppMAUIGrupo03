using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAppMAUIGrupo03.Models
{
    public class EstudianteUDLA
    {
        public EstudianteUDLA()
        {
            Id = 0;
            Nombre = "";
            Carrera = "";
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
    }
}
