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
            new MultaViewMenuItem { Id = 0, Title = "Inicio", TargetType=null },
            new MultaViewMenuItem { Id = 1, Title = "Consulta rapida", TargetType=typeof(Consulta) },
            new MultaViewMenuItem { Id = 2, Title = "Puntos de control", TargetType=typeof(Mapa) },
            new MultaViewMenuItem { Id = 3, Title = "Resumen de deudas", TargetType=typeof(Resumen) },
            new MultaViewMenuItem { Id = 4, Title = "Contacto", TargetType=typeof(Contacto) },
            new MultaViewMenuItem { Id = 5, Title = "Login", TargetType=typeof(Login) },
        });

        public static ObservableCollection<MultaViewMenuItem> menuLogin = new ObservableCollection<MultaViewMenuItem>(new[]
        {
            new MultaViewMenuItem { Id = 0, Title = "Inicio", TargetType=null },
            new MultaViewMenuItem { Id = 1, Title = "Consulta rapida", TargetType=typeof(Consulta) },
            new MultaViewMenuItem { Id = 2, Title = "Puntos de control", TargetType=typeof(Mapa) },
            new MultaViewMenuItem { Id = 3, Title = "Resumen de deudas", TargetType=typeof(Resumen) },
            new MultaViewMenuItem { Id = 4, Title = "Contacto", TargetType=typeof(Contacto) },
            new MultaViewMenuItem { Id = 5, Title = "Salir", TargetType=typeof(int) },
        });
    }
}
