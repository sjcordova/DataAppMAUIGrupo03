using DataAppMAUIGrupo03.Interfaces;
using DataAppMAUIGrupo03.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAppMAUIGrupo03.Repositories
{
    public class EstudianteUDLAFilesRepository : IEstudianteUDLARepository
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "estudiantes.txt");

        public bool ActualizarEstudianteUDLA(EstudianteUDLA estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearEstudianteUDLA(EstudianteUDLA estudiante)
        {
            try
            {
                string estudiante_json = JsonConvert.SerializeObject(estudiante);
                File.WriteAllText(_fileName, estudiante_json);
                return true;
            }
            catch(Exception e)
            {
                throw;
            }


        }

        public EstudianteUDLA DevuelveInfoEstudianteUDLA(int Id)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA();
            if (File.Exists(_fileName))
            {
                string data = File.ReadAllText(_fileName);  
                estudiante = JsonConvert.DeserializeObject<EstudianteUDLA>(data);   
            }
            return estudiante;
        }

        public List<EstudianteUDLA> DevuelveListadoEstudiantesUDLA()
        {
            List<EstudianteUDLA> estudiantes = new List<EstudianteUDLA>();
            estudiantes.Add(DevuelveInfoEstudianteUDLA(1));
            estudiantes.Add(DevuelveInfoEstudianteUDLA(2));
            estudiantes.Add(DevuelveInfoEstudianteUDLA(3));

            return estudiantes;
        }

        public bool EliminarEstudianteUDLA(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
