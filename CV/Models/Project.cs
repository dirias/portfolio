using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Models
{
    public class Project
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        public string GitHubLink { get; set; }
        public string Logo { get; set; }
        ///public List<string> ImageLink { get; set; } = new List<string>();

        public List<Project> GetProjects()
        {
            List<string> y = new List<string>();
                y.AddRange(new string[] { "seven", "eight", "nine" });
            List<Project> x = new List<Project>()
            {
                new Project{ Name = "Sistema de lavado Lújan21", Description = "Desarrollado en Visual Basic para un parqueo público situado en San Pedro, CR. Programado en C# bajo una arquitectura de 3 capas conectado a una base de datos local desarrollada en SQL-Server.", GitHubLink = "", Logo = "/Pictures/logoLugan21.png"},
                new Project{ Name = "Shopping Car", Description = "Programado en ASP.NET con C#, bajo una arquitectura de 3 capas (ACCESO A DATOS, NEGOCIO Y UI) y conectada a una base de datos MS-SQLSERVER mediante Entity Framework.", GitHubLink = "", Logo = "/Pictures/ShoppingCarLogo.png" },
                new Project{ Name = "Sistema de gestión CNM", Description = "Software hecho para el Centro Nacional de la Música, programado en C# MVC5, conectado a una base de datos SQL-Server 2016 con el uso de ADO.Net Framework y Ajax para la inserción y peticiones a la base de datos", GitHubLink = "", Logo = "/Pictures/CNMLogo.png" }
            };

            return x;
        }
    }
}