using PPP.Database;
using PPP.Views;
using SQLite;
using Xamarin.Forms;

namespace PPP
{
    public partial class App : Application
    {
        private SQLiteConnection _dbConnProductCatalog;
        private SQLiteConnection _dbConnProductCatalogResources;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            _dbConnProductCatalog = GetProductCatalogDatabaseConnection();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private SQLiteConnection GetProductCatalogDatabaseConnection()
        {
            if (_dbConnProductCatalog == null)
            {
                return _dbConnProductCatalog = DependencyService.Get<ISqliteProductCatalog>().GetConnection();
            }

            return _dbConnProductCatalog;
        }
    }
}
