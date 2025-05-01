﻿using Microsoft.AspNetCore.Mvc;
using Naitv1.Models;

namespace Naitv1.Helpers
{
    public class UsuarioLogueado
    {

        public static bool estaLogueado(ISession sesionActual)
        {
            string estaLogueadoString = sesionActual.GetString("estaLogueado") ?? "false";
            bool estaLogueado = estaLogueadoString == "true";

            return estaLogueado;
        }

        public static void loguearUsuario(ISession sesionActual, Usuario usuario)
        {
            sesionActual.SetString("estaLogueado", "true");

            sesionActual.SetInt32("idUsuario", usuario.Id);
            sesionActual.SetString("nombreUsuario", usuario.Nombre);
            sesionActual.SetString("emailUsuario", usuario.Email);
            sesionActual.SetString("anfitrion", usuario.Anfitrion);
        }

        public static Usuario Usuario(ISession sesionActual)
        {
            Usuario usuario = new Usuario();
            usuario.Id = sesionActual.GetInt32("idUsuario") ?? 0;
            usuario.Nombre = sesionActual.GetString("nombreUsuario") ?? "";
            usuario.Email = sesionActual.GetString("emailUsuario") ?? "";
            usuario.Anfitrion = sesionActual.GetString("anfitrion") ?? "";
            
            return usuario;
        }
    }
}
