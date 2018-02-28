using PortalImo.Domain.Interfaces.Domain;
using PortalImo.UI.Web.ViewModels;
using System.Web.Mvc;
using System.Web.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PortalImo.UI.Web.Util;


namespace PortalImo.UI.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IServicoDeUsuarioDomain _servicoUsuarioDominio;

        public AccountController(IServicoDeUsuarioDomain servicoUsuarioDominio)
        {
            _servicoUsuarioDominio = servicoUsuarioDominio;
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login (LoginViewModel viewModel )
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var usuario = _servicoUsuarioDominio.LogaUsuario(viewModel.Email, viewModel.Password);
            if (usuario == null)
            {
                ModelState.AddModelError("", "Email ou senha incorretos");
                return View(viewModel);
            }
             SessionManager.UsuarioLogado = usuario;
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Logoff()
        {
            Session.Abandon();
            Session.RemoveAll();
            return RedirectToAction("Index", "Home");


        }

        [HttpGet]
        public ActionResult Register()
        {
            var viewModel = new RegisterViewModel();
            return View(viewModel);
        }
        
        [HttpPost]
        public ActionResult Register(RegisterViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var usuarioExistente = _servicoUsuarioDominio.RecuperaUsuarioPorEmail(viewModel.Email);
            if (usuarioExistente != null)
            {
                ModelState.AddModelError("", "Email está sendo utilizado");
                return View(viewModel);
            }

            _servicoUsuarioDominio.CadastrarUsuario(
                new Domain.Entities.Usuario()
                {
                    email = viewModel.Email,
                    datahora = DateTime.Now,
                    ativo = true,
                    master = false,
                    ultimoacesso = null,
                    senha = viewModel.Senha,
                    senhaKey = Functions.GetRandomString()
                });
            return RedirectToAction("Index", "Home");
        }


    }
}