using Forms.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Forms.Controllers
{
    public class FormController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;

        public FormController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {

            //Obtenemos el id del usuario para generar una URL personalizada 
            var user = await _userManager.GetUserAsync(User);
            Form formulario = new Form("pregunta1", "pregunta2", "pregunta3");

            string customURL = $"/form/{user.Id}";

            return RedirectToAction("CustomForm", new { url = customURL, userid = user.Id, formid = formulario.Id});
        }

        public IActionResult FormularioPersonalizado(string url, string userid, int formid) 
        {
            var respuesta = new RespuestasUsuario { IdForm = formid, IdUsuario = userid};

            ViewData["customURL"] = url;
            
            return View(respuesta);
        }

        [HttpPost]
        public IActionResult ProcesarFormulario(RespuestasUsuario modelo)
        {
            string userId = modelo.IdUsuario;
            int formId = modelo.IdForm;
            string r1 = modelo.respuesta1;
            string r2 = modelo.respuesta2;
            string r3 = modelo.respuesta3;

            //Aqui se realizarian las acciones de comprobacion de la respuestas y se enviaria el JSON para generar el Dashboard
            return RedirectToAction("GenerarDashboard");
        }
    }
}
