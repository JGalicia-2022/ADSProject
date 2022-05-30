using ADSProject.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProject.Controllers
{
    public class AsignacionGrupoController : Controller
    {

        private readonly IAsignacionGrupoRepository asignacionGrupoRepository;
        private readonly IEstudianteRepository estudianteRepository;
        private readonly IGrupoRepository grupoRepository;

        public AsignacionGrupoController(IAsignacionGrupoRepository asignacionGrupoRepository, IEstudianteRepository estudianteRepository,IGrupoRepository grupoRepository)
        {
            this.asignacionGrupoRepository = asignacionGrupoRepository;
            this.estudianteRepository = estudianteRepository;
            this.grupoRepository = grupoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
