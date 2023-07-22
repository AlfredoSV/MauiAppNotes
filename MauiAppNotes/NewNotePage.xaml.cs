namespace MauiAppNotes;

public partial class NewNotePage : ContentPage
{
	int count = 0;

	public NewNotePage()
	{
		InitializeComponent();
	}

	private void SaveNote_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Alert","Click","Yes");
	}

   
}

