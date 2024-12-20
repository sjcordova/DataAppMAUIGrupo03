using SQLite;
using System.Diagnostics.CodeAnalysis;


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

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Nombre { get; set; }
        [MaxLength(100), AllowNull]
        public string Carrera { get; set; }
    }
}
