using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDMPW_3P_EX.ViewModels;

namespace TDMPW_3P_EX.Models
{
    internal partial class Semestre : ObservableObject
    {
        [ObservableProperty]
        private string nombre;

        [ObservableProperty]
        private string estado;

        [ObservableProperty]
        private double valorP1;

        [ObservableProperty]
        private double valorP2;

        [ObservableProperty]
        private double valorP3;

        [ObservableProperty]
        private double calificacionP1;

        [ObservableProperty]
        private double calificacionP2;
    }
}
