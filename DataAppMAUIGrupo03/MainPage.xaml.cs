using DataAppMAUIGrupo03.Models;
using DataAppMAUIGrupo03.Repositories;

namespace DataAppMAUIGrupo03
{
    public partial class MainPage : ContentPage
    {
        public EstudianteUDLA estudiante;
        EstudianteUDLAFilesRepository _repository;

        public MainPage()
        {
            InitializeComponent();
            _repository = new EstudianteUDLAFilesRepository();
            estudiante = _repository.DevuelveInfoEstudianteUDLA(1);

            BindingContext = estudiante;
        }


/* Cambio no fusionado mediante combinación del proyecto 'DataAppMAUIGrupo03 (net8.0-windows10.0.19041.0)'
Antes:
        private void BotonGuardarEstudiante_Clicked(object sender, EventArgs e)
        {
Después:
        private void BotonGuardarEstudiante_ClickedAsync(object sender, EventArgs e)
        {
*/
        private async Task BotonGuardarEstudiante_ClickedAsync(object sender, EventArgs e)
        {
            EstudianteUDLA estudiante= new EstudianteUDLA
            {
                Id = 10,
                Nombre = "Santiago José Córdova Paredes",
                Carrera = "Ingeniería en Sistemas"
            };

            bool crear_estudiante= _repository.CrearEstudianteUDLA(estudiante);


        }
    }

}
