using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMPW_3P_EX.Models
{
    internal partial class Materia : ObservableObject
    {
        public Materia()
        {
            Rubros = new List<Rubro>();
        }

        [ObservableProperty]
        private string nombre;
        
        [ObservableProperty]
        private string estado;

        [ObservableProperty]
        private double calMateria;

        [ObservableProperty]
        private List<Rubro> rubros;

        partial void OnRubrosChanged(List<Rubro> oldValue, List<Rubro> newValue)
        {
            if (oldValue != null)
            {
                foreach (var rubro in oldValue)
                {
                    rubro.PropertyChanged -= Rubro_PropertyChanged;
                }
            }

            if (newValue != null)
            {
                foreach (var rubro in newValue)
                {
                    rubro.PropertyChanged += Rubro_PropertyChanged;
                }
            }
        }

        private void Rubro_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Rubro.Valor) || e.PropertyName == nameof(Rubro.Calificacion))
            {
                RecalcularCalificacion();
            }
        }

        public void RecalcularCalificacion()
        {
            if (Rubros.Sum(r => r.Valor) != 100)
            {
                Estado = "Error: Valores"; 
            }
            else
            {
                if (Rubros.Any(r => r.Calificacion < 0 || r.Calificacion > 10))
                {
                    Estado = "Error: Calificación";
                }
                else
                {
                    Estado = "Todo correcto";
                    CalMateria = Rubros.Sum(r => (r.Valor / 100) * r.Calificacion);
                }
            }
        }
    }

    public partial class Rubro : ObservableObject
    {
        [ObservableProperty]
        private string nombre;

        [ObservableProperty]
        private double valor;

        [ObservableProperty]
        private double calificacion;
    }
}
