using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDMPW_3P_EX.Models;

namespace TDMPW_3P_EX.ViewModels
{
    internal partial class SemestreViewModel : ObservableObject
    {
        [ObservableProperty]
        private Semestre semestre;

        [ObservableProperty]
        private string calificacionPara6;

        [ObservableProperty]
        private string calificacionPara10;

        [ObservableProperty]
        private string mensaje;

        public SemestreViewModel()
        {
            Semestre = new Semestre
            {
                ValorP1 = 0,
                ValorP2 = 0,
                ValorP3 = 0,
                CalificacionP1 = 0,
                CalificacionP2 = 0,
            };
            Semestre.PropertyChanged += Semestre_PropertyChanged;
        }

        private void Semestre_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Semestre.ValorP1) ||
                e.PropertyName == nameof(Semestre.ValorP2) ||
                e.PropertyName == nameof(Semestre.ValorP3) ||
                e.PropertyName == nameof(Semestre.CalificacionP1) ||
                e.PropertyName == nameof(Semestre.CalificacionP2))
            {
                CalP3();
            }
        }

        // Métodos Cambiar Nombres
        public void NomSemestreChange(string nuevoNombre)
        {
            Semestre.Nombre = nuevoNombre;
        }

        // Métodos Cambiar Valores
        public void VaP1Changed(double nuevoValor)
        {
            Semestre.ValorP1 = nuevoValor;
        }
        public void VaP2Changed(double nuevoValor)
        {
            Semestre.ValorP2 = nuevoValor;
        }
        public void VaP3Changed(double nuevoValor)
        {
            Semestre.ValorP3 = nuevoValor;
        }

        // Métodos Cambiar Calificaciones
        public void CalP1Changed(double nuevaCal)
        {
            Semestre.CalificacionP1 = nuevaCal;
        }
        public void CalP2Changed(double nuevaCal)
        {
            Semestre.CalificacionP2 = nuevaCal;
        }

        private void CalP3()
        {
            double valores = Semestre.ValorP1 + Semestre.ValorP2 + Semestre.ValorP3;
            if (valores != 100)
            {
                Semestre.Estado = "Error: Valores deben sumar 100";
                Mensaje = "Algo salio mal";
                CalificacionPara6 = "0";
                CalificacionPara10 = "0";
            }
            else
            {
                if (Semestre.CalificacionP1 < 0 || Semestre.CalificacionP1 > 10 || Semestre.CalificacionP2 < 0 || Semestre.CalificacionP2 > 10)
                {
                    Semestre.Estado = "Error: Calificaciones deben ser entre 0 y 10";
                    Mensaje = "Algo salio mal";
                }
                else
                {
                    Semestre.Estado = "Todo correcto";

                    double calParcial1 = (Semestre.ValorP1 / 100) * Semestre.CalificacionP1;
                    double calParcial2 = (Semestre.ValorP2 / 100) * Semestre.CalificacionP2;
                    double sumaParciales = calParcial1 + calParcial2;

                    double calificacionPara6 = (6 - sumaParciales) / (Semestre.ValorP3 / 100);
                    double calificacionPara10 = (10 - sumaParciales) / (Semestre.ValorP3 / 100);

                    CalificacionPara6 = calificacionPara6.ToString("F2");
                    CalificacionPara10 = calificacionPara10.ToString("F2");

                    if (calificacionPara10 <= 10)
                    {
                        Mensaje = "¡Vamos, puedes sacar 10!";
                    }
                    else if ( calificacionPara6 <= 10)
                    {
                        Mensaje = "¡Aún puedes sacar 6!";
                    }
                    else
                    {
                        Mensaje = "Nimodillo, a extra.";
                    }
                }
            }
        }
    }

}
