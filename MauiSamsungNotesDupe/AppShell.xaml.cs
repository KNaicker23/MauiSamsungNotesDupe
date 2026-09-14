namespace MauiSamsungNotesDupe
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

       

        private void ManageFoldersButton_Clicked(object sender, EventArgs e)
        {
            
        }

       

        private void SettingsButton_Clicked(object sender, EventArgs e)
        {

        }

        void RegisterRoutes()
        { 
            Routing.RegisterRoute("recyclebinpage",typeof(RecycleBinPage));


        }
    }
}
