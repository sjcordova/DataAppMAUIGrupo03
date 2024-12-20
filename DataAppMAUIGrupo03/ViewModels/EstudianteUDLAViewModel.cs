using DataAppMAUIGrupo03.Interfaces;
using DataAppMAUIGrupo03.Models;
using DataAppMAUIGrupo03.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataAppMAUIGrupo03.ViewModels
{
    public class EstudianteUDLAViewModel : INotifyPropertyChanged
    {
        private IEstudianteUDLARepository _repositorio;
        private EstudianteUDLA _estudiante;
        private string _resultado;
        private List<EstudianteUDLA> _estudiantes;
        public ICommand CommandBotonGuardar { get; set; }
        public EstudianteUDLA estudiante
        {
            get => _estudiante;
            set
            {
                if (_estudiante != value)
                {
                    
                    OnPropertyChanged();
                }
            }
        }
        public List<EstudianteUDLA> estudiantes
        {
            get => _estudiantes;
            set
            {
                if (_estudiantes != value)
                {
                    _estudiantes = value;
                    OnPropertyChanged();
                }
            }
        }
        public string resultado
        {
            get => _resultado;
            set
            {
                if (_resultado != value)
                {
                    _resultado = value;
                    OnPropertyChanged();
                }
            }
        }

        public EstudianteUDLAViewModel()
        {
            estudiante = new EstudianteUDLA();
            _repositorio = new EstudianteUDLASQLiteRepository();
            CommandBotonGuardar = new Command(GuardarEstudianteUDLA);
            estudiantes = _repositorio.DevuelveListadoEstudiantesUDLA();
        }

        public void GuardarEstudianteUDLA()
        {
            var crear=_repositorio.CrearEstudianteUDLA(estudiante);
            if (crear)
            {
                resultado = "Guardado correctamente";
                estudiantes = _repositorio.DevuelveListadoEstudiantesUDLA();
            }
            else
            {
                resultado = "Error al guardar";
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
