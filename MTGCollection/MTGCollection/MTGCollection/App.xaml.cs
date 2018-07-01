using System;
using Xamarin.Forms;
using MTGCollection.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace MTGCollection
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();


			MainPage = new NavigationPage(new MainPage());
            
            Button button = new Button
            {
                Text = "Carddeta!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new CardDetailPage());
            };

            Content = button;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
