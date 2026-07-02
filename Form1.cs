    namespace Cinema
    {
        public partial class Form1 : Form
        {
            public MovieManeger movieManager = new MovieManeger();
            public string CurrentUser { get; private set; }

            public Form1()
                {
                InitializeComponent();
                LoadPage(new UC_UserAccount(this));
                }

            public void LoadPage(UserControl page)
            {
                panelContainer.Controls.Clear();
                page.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(page);
            }
            public void SetCurrentUser(string userName)
             {
                CurrentUser = userName;
                LoadPage(new UC_Movies(movieManager.Movies, this));
             }
    }
}
