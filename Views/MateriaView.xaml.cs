using TDMPW_3P_EX.Models;
using TDMPW_3P_EX.ViewModels;

namespace TDMPW_3P_EX.Views;

public partial class MateriaView : TabbedPage
{
	public MateriaView()
	{
		InitializeComponent();
    }

    // -------- MATERIA ---------
    // Métodos Cambiar Nombre
    private void nomMateriaChanged(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is MateriaViewModel viewModel)
        {
            viewModel.nomMateriaChange(e.NewTextValue);
        }
    }

    // Métodos Cambiar Nombres Rubros
    
    private void nomR1Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is MateriaViewModel viewModel)
        {
            viewModel.nomR1Changed(e.NewTextValue);
        }
    }
    private void nomR2Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is MateriaViewModel viewModel)
        {
            viewModel.nomR2Changed(e.NewTextValue);
        }
    }
    private void nomR3Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is MateriaViewModel viewModel)
        {
            viewModel.nomR3Changed(e.NewTextValue);
        }
    }

    // Métodos Cambiar Valor
    private void vaR1Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is MateriaViewModel viewModel)
        {
            double valor = double.Parse(e.NewTextValue);
            viewModel.vaR1Changed(valor);
        }
    }
    private void vaR2Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is MateriaViewModel viewModel)
        {
            double valor = double.Parse(e.NewTextValue);
            viewModel.vaR2Changed(valor);
        }
    }

    private void vaR3Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is MateriaViewModel viewModel)
        {
            double valor = double.Parse(e.NewTextValue);
            viewModel.vaR3Changed(valor);
        }
    }

    // Métodos Cambiar Calificación
    private void calR1Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is MateriaViewModel viewModel)
        {
            double cal = double.Parse(e.NewTextValue);
            viewModel.calR1Changed(cal);
        }
    }
    private void calR2Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is MateriaViewModel viewModel)
        {
            double cal = double.Parse(e.NewTextValue);
            viewModel.calR2Changed(cal);
        }
    }
    private void calR3Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is MateriaViewModel viewModel)
        {
            double cal = double.Parse(e.NewTextValue);
            viewModel.calR3Changed(cal);
        }
    }

    // -------- SEMESTRE ---------
    // Método Cambiar Nombre
    private void nomSemestreChanged(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is SemestreViewModel viewModel)
        {
            viewModel.NomSemestreChange(e.NewTextValue);
        }
    }

    // Métodos Cambiar Valor
    private void vaP1Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is SemestreViewModel viewModel)
        {
            if (double.TryParse(e.NewTextValue, out double valor))
            {
                viewModel.VaP1Changed(valor);
            }
        }
    }
    private void vaP2Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is SemestreViewModel viewModel)
        {
            if (double.TryParse(e.NewTextValue, out double valor))
            {
                viewModel.VaP2Changed(valor);
            }
        }
    }
    private void vaP3Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is SemestreViewModel viewModel)
        {
            if (double.TryParse(e.NewTextValue, out double valor))
            {
                viewModel.VaP3Changed(valor);
            }
        }
    }

    // Métodos cambiar Calificación
    private void calP1Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is SemestreViewModel viewModel)
        {
            if (double.TryParse(e.NewTextValue, out double cal))
            {
                viewModel.CalP1Changed(cal);
            }
        }
    }
    private void calP2Changed(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is SemestreViewModel viewModel)
        {
            if (double.TryParse(e.NewTextValue, out double cal))
            {
                viewModel.CalP2Changed(cal);
            }
        }
    }

}