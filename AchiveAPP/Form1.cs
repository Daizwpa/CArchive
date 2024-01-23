using Archive_Core.DataAccess;
namespace AchiveAPP
{
    public partial class Form1 : Form
    {
        Connection connection = new Connection();
        public Form1()
        {
            InitializeComponent();
            connection.Database.EnsureCreated();
            connection.users.Add(new User());


            
        }
    }
}
