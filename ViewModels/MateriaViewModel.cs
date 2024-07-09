using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDMPW_3P_EX.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TDMPW_3P_EX.ViewModels
{
    internal partial class MateriaViewModel : ObservableObject
    {
        [ObservableProperty]
        private Materia materia;

        public MateriaViewModel()
        {
            Materia = new Materia
            {
                Rubros = new List<Rubro>
                {
                    new Rubro { Nombre = "a", Valor = 0, Calificacion = 0 },
                    new Rubro { Nombre = "b", Valor = 0, Calificacion = 0 },
                    new Rubro { Nombre = "c", Valor = 0, Calificacion = 0 }
                }
            };
        }

        // Métodos Cambiar Nombres
        public void nomMateriaChange(string nuevoNombre)
        {
            Materia.Nombre = nuevoNombre;
        }

        public void nomR1Changed(string nuevoNombre)
        {
            Materia.Rubros[0].Nombre = nuevoNombre;
        }

        public void nomR2Changed(string nuevoNombre)
        {
            Materia.Rubros[1].Nombre = nuevoNombre;
        }

        public void nomR3Changed(string nuevoNombre)
        {
            Materia.Rubros[2].Nombre = nuevoNombre;
        }

        // Métodos Cambiar Valores
        public void vaR1Changed(double nuevoValor)
        {
            Materia.Rubros[0].Valor = nuevoValor;
        }
        public void vaR2Changed(double nuevoValor)
        {
            Materia.Rubros[1].Valor = nuevoValor;
        }
        public void vaR3Changed(double nuevoValor)
        {
            Materia.Rubros[2].Valor = nuevoValor;
        }

        // Métodos Cambiar Calificaciones
        public void calR1Changed(double nuevaCal)
        {
            Materia.Rubros[0].Calificacion = nuevaCal;
        }
        public void calR2Changed(double nuevaCal)
        {
            Materia.Rubros[1].Calificacion = nuevaCal;
        }
        public void calR3Changed(double nuevaCal)
        {
            Materia.Rubros[2].Calificacion = nuevaCal;
        }
    }
}
