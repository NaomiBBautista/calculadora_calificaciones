using TDMPW_3P_EX.Views;
namespace TDMPW_3P_EX
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MateriaView();
        }
    }
}
