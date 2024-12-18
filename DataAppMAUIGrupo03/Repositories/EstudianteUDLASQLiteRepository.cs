using DataAppMAUIGrupo03.Interfaces;
using DataAppMAUIGrupo03.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAppMAUIGrupo03.Repositories
{
    public class EstudianteUDLASQLiteRepository : IEstudianteUDLARepository
    {
        private readonly string _dbPath = Path.Combine(FileSystem.AppDataDirectory, "EstudiantesUDLA.db3");
        private SQLiteConnection _connection;

        public EstudianteUDLASQLiteRepository()
        {
            Init();
        }

        public void Init()
        {
            _connection = new SQLiteConnection(_dbPath);
            _connection.CreateTable<EstudianteUDLA>();
        }

        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public EstudianteUDLA DevuelveInfoEstudianteUDLA(int Id)
        {
            throw new NotImplementedException();
        }

        public List<EstudianteUDLA> DevuelveListadoEstudianteUDLA()
        {
            throw new NotImplementedException();
        }

        public bool EliminarEstudianteUDLA(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
