using ElenStore.Data;
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
