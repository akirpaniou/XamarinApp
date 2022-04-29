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
        public const string DATABASE_NAME = "DBCourses.db";
        public static CourseDB database;
        public static CourseDB Database
        {
            get
            {
                if(database == null)
                {
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME);
                    if (!File.Exists(dbPath))
                    {
                        var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                        using (Stream stream = assembly.GetManifestResourceStream($"ElenStore.{DATABASE_NAME}"))
                        {
                            using (FileStream fs = new FileStream(dbPath, FileMode.OpenOrCreate))
                            {
                                stream.CopyTo(fs);
                                fs.Flush();
                            }
                        }
                    }
                    database = new CourseDB(dbPath);
                }
                return database;
            }
        }
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
