using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyHomeManager
{
	public class App : Application
	{
        public static IAuthenticator IAuthenticator { get; private set; }
	    public static void init(IAuthenticator iAuthenticator)
	    {
	        IAuthenticator = iAuthenticator;
	    }
		public App ()
		{
			// The root page of your application
			MainPage = new TodoList();
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

