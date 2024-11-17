using CadastroEventos.Models;

namespace CadastroEventos.Views;

public partial class CadastroEvento : ContentPage
{
	App PropriedadesApp;

    public CadastroEvento()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		dtpck_inicio.MinimumDate = DateTime.Now;
		dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_final.MinimumDate = dtpck_inicio.Date.AddDays(1);
		dtpck_final.MaximumDate = dtpck_inicio.Date.AddMonths(6);
	}   

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Evento ev = new Evento
			{
				NomeEvento = txt_nomeevento.Text,
				NumeroParticipantes = Convert.ToInt32(txt_nparticipantes.Text),
				ValorParticipante = Convert.ToInt32(txt_custoparticipante.Text),
				Local = txt_local.Text,
				DataInicio = dtpck_inicio.Date,
				DataFinal = dtpck_final.Date,
			};

			await Navigation.PushAsync(new EventoContratado()
			{
				BindingContext = ev
			});
		}
		catch (Exception ex) 
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
    }
    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {

        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_inicio = elemento.Date;

        dtpck_inicio.MinimumDate = data_selecionada_inicio.AddDays(1);
        dtpck_final.MinimumDate = data_selecionada_inicio.AddMonths(6);
    }
}