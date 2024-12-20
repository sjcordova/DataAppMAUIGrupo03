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
    public class EstudianteUDLAAPIsRepository : IEstudianteUDLARepository
    {
        public HttpClient _httpClient;
        public string endpoint = "https://freetestapi.com/api/v1/students";
        
        
        public EstudianteUDLAAPIsRepository()
        {
            _httpClient = new HttpClient();
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

        public List<EstudianteUDLA> DevuelveListadoEstudiantesUDLA()
        {
            List <EstudianteUDLA> estudiantesUDLA = new List<EstudianteUDLA>();
            using (_httpClient)
            {
                var response = _httpClient.GetAsync(endpoint).Result;
                string json_data = response.Content.ReadAsStringAsync().Result;

                List<EstudianteAPI> estudiantesAPI = new List<EstudianteAPI>();
                estudiantesAPI = JsonConvert.DeserializeObject<List<EstudianteAPI>>(json_data);

                estudiantesUDLA = estudiantesAPI.Select(item=> new EstudianteUDLA
                {
                    Id = item.id,
                    Nombre = item.name,
                    Carrera = "Carrera de test"
                }).ToList();
            }

            return estudiantesUDLA;
        }

        public bool EliminarEstudianteUDLA(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
