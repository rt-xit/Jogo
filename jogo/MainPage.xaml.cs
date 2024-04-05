namespace jogo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		Caranguejo= new Caranguejo();

		ImgCaranguejo.Source= Caranguejo.GetArquivo();		
	}

	void ButtonFome(object sender, EventArgs args)
	{
		Caranguejo.SetFome(Caranguejo.GetFome()+0.1);
	}
}

