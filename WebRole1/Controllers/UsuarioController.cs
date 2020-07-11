using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebRole1.Models;

namespace WebRole1.Controllers
{   
    public class UsuarioController : Controller
    {
        // GET: Usuario
        //[HttpGet]
        public ActionResult Index(string message = "")
        {
            //Enviaremos un mensaje si el log fue exitoso o equivocado
            ViewBag.Message = message;

            //obtener el dato por medio de entity framwork sin protocolos HTTP
            Database_asura db = new Database_asura();

            //La variable listUsuario me debuelve todo las listas de la tabla Usuarios
            //var listUsuario = db.Usuarios.ToList();
            //---------------------------------------------------------------------------
            //var usuario con el metodo .FirstOrDefault me permite preguntar por medio de un arrow fucntion si el dato es el correcto
            //y filtrar la información por medio de lógica.
            var usuario = db.Usuarios.FirstOrDefault(e => e.Id_user == 1);

            //retorna el JSON
            //JsonrquestBehavior.AllowGet se utiliza más cuando nuestra base de datos sqlserver esta andiada a un servidor CLOUD
            return new JsonResult()
            {
                //parametro Data donde pasamos la variable a convertir a JSON
                Data = usuario,
               
                
                //El parámetro adicional JsonRequestBehavior.AllowGet lo colocamos por un tema de seguridad,
                //pasar por GET valores de JSON no es una práctica muy segura,
                //ya que muestra la información de todo nuestro request,
                //por ello ASP.NET nos fuerza a que declaremos esto para que estemos en conocimiento que
                //por nuestra voluntad estamos rompiendo con los estándares de seguridad.
               
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            
            if(email != "" && password != "")
            {
                Database_asura db = new Database_asura();
                var user =  db.Usuarios.FirstOrDefault(e => e.User_email == email && e.User_pass == password);
                if (user != null) {
                    //FormsAuthentications.SetAuthCookie(user.User_email, true);
                    return Index("No encontramos tus datos");
                } 
                else return RedirectToAction("Index","Profile");
            }
            else
            {
                return Index("Debes llenar todos los campos");
            }
            return View();
        }
    }
}