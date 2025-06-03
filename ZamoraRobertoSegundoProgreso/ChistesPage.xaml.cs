using ZamoraRobertoSegundoProgreso.Services;

namespace ZamoraRobertoSegundoProgreso
{
    public partial class ChistesPage : ContentPage
    {
        private readonly IChistesService _chistesService;

        public ChistesPage(IChistesService chistesService)
        {
            InitializeComponent();
            _chistesService = chistesService;
            CargarChiste();
        }

        private async void CargarChiste()
        {
            var chiste = await _chistesService.ObtenerChisteAleatorioAsync();
            ChisteLabel.Text = chiste.TextoCompleto;
        }

        private void OnNuevoChisteClicked(object sender, EventArgs e)
        {
            CargarChiste();
        }
    }
}