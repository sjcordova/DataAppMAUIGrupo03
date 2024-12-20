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
            try
            {
                int actualizar = _connection.Update(estudiante);
                return actualizar > 0;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try
            {
                int registros= _connection.Insert(estudiante);
                return registros > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public EstudianteUDLA DevuelveInfoEstudianteUDLA(int Id)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA();
            estudiante = _connection.Get<EstudianteUDLA>(Id);
            return estudiante;
        }

        public List<EstudianteUDLA> DevuelveListadoEstudiantesUDLA()
        {
            List<EstudianteUDLA> estudiantes = new List<EstudianteUDLA>();
            estudiantes = _connection.Table<EstudianteUDLA>().ToList();
            return estudiantes;
        }

        public bool EliminarEstudianteUDLA(int Id)
        {
            try
            {
                int registrosEliminados = _connection.Delete<EstudianteUDLA>(Id);
                return registrosEliminados > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
