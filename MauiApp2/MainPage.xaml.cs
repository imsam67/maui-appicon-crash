using System.Diagnostics;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		try
		{
			var result = await MediaPicker.PickPhotoAsync();
			if (result == null)
				return;

			var fileName = result.FileName;
			Debug.WriteLine("File picked: " + fileName);
		}
		catch(Exception ex)
		{
			// Log error
			Debug.WriteLine("Error: " + ex.Message);
		}
	}
}

