using DataAppMAUIGrupo03.Interfaces;
using DataAppMAUIGrupo03.Models;
using DataAppMAUIGrupo03.Repositories;

namespace DataAppMAUIGrupo03.Views;

public partial class EstudiantesUDLAView : ContentPage
{
	public EstudianteUDLA estudiante;
	public List<EstudianteUDLA> estudiantes;
	public IEstudianteUDLARepository _repositorio;

	public EstudiantesUDLAView()
	{
		InitializeComponent();
	}

}