using ElenStore.Data;
using Plugin.FirebasePushNotification;
using System;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElenStore
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "notes2.db";
        public static NoteAsyncRepository database;
        public static NoteAsyncRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteAsyncRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        /*
        public const string DATABASE_NAME = "notes.db";
        public static NoteRepository database;
        public static NoteRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        */
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            CrossFirebasePushNotification.Current.OnTokenRefresh += Current_OnTokenRefresh;
        }

        private void Current_OnTokenRefresh(object source, FirebasePushNotificationTokenEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"Token: {e.Token}");
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
