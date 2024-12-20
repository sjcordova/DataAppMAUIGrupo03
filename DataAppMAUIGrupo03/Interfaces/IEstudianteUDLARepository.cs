using DataAppMAUIGrupo03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAppMAUIGrupo03.Interfaces
{
    public interface IEstudianteUDLARepository
    {
        List<EstudianteUDLA> DevuelveListadoEstudiantesUDLA();
        EstudianteUDLA DevuelveInfoEstudianteUDLA(int Id);
        Boolean CrearEstudianteUDLA(EstudianteUDLA estudiante);
        Boolean ActualizarEstudianteUDLA(EstudianteUDLA estudiante);
        Boolean EliminarEstudianteUDLA(int Id);
    }
}
