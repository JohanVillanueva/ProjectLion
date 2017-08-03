using ProjectLion.Models;
using ProjectLion.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLion.Variables
{
    public static class Globales
    {
        public static int ADMIN = 4;
        
        public static List<Multa> multas = new List<Multa>();

        public static Propietario propietario = null;

        public static ObservableCollection<MultaViewMenuItem> menuNoLogin = new ObservableCollection<MultaViewMenuItem>(new[]
        {
            new MultaViewMenuItem {imageUrl="home.png",  Id = 0, Title = "Inicio", TargetType=null },
            new MultaViewMenuItem {imageUrl="lupaicon.png",  Id = 1, Title = "Consulta rapida", TargetType=typeof(Consulta) },
            new MultaViewMenuItem {imageUrl="mapa.png",  Id = 2, Title = "Puntos de control", TargetType=typeof(Mapa) },
            new MultaViewMenuItem {imageUrl="deuda.png",  Id = 3, Title = "Resumen de deudas", TargetType=typeof(Resumen) },
            new MultaViewMenuItem {imageUrl="contacto.png",  Id = 4, Title = "Contacto", TargetType=typeof(Contacto) },

            new MultaViewMenuItem {imageUrl="login.png",  Id = 5, Title = "Iniciar Sesión", TargetType=typeof(Login) },
        });

        public static ObservableCollection<MultaViewMenuItem> menuLogin = new ObservableCollection<MultaViewMenuItem>(new[]
        {
            new MultaViewMenuItem {imageUrl="home.png" ,Id = 0, Title = "Inicio", TargetType=null },
            new MultaViewMenuItem {imageUrl="lupaicon.png",   Id = 1, Title = "Consulta rapida", TargetType=typeof(Consulta) },
            new MultaViewMenuItem {imageUrl="mapa.png",   Id = 2, Title = "Puntos de control", TargetType=typeof(Mapa) },
            new MultaViewMenuItem {imageUrl="deuda.png",  Id = 3, Title = "Resumen de deudas", TargetType=typeof(Resumen) },
            new MultaViewMenuItem {imageUrl="contacto.png", Id = 4, Title = "Contacto", TargetType=typeof(Contacto) },
            new MultaViewMenuItem {imageUrl="mapa.png",  Id = 5, Title = "Reportes", TargetType=typeof(MenuReportes) },
            new MultaViewMenuItem {imageUrl="logout.png", Id = 6, Title = "Cerrar Sesión", TargetType=typeof(int) }
        });
    }
}
