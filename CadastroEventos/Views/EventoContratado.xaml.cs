namespace CadastroEventos.Views;

public partial class EventoContratado : ContentPage
{
	public EventoContratado()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}