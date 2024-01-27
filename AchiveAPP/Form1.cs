using Archive_Core.DataAccess;
namespace AchiveAPP
{
    public partial class Form1 : Form
    {
        Connection connection = new Connection();
        bool x = false;
        public Form1()
        {
            InitializeComponent();
            connection.Database.EnsureCreated();
            if (x)
            {
                connection.users.Add(new User()
                {
                    Num_Telephone = "08030999490",
                    FName = "Ahmed",
                    
                    LName = "Bennadji",
                    Password = "123",
                    Username = "123"
                });
                connection.SaveChanges();

            }




        }



        private void button1_Click(object sender, EventArgs e)
        {
            string user = usernameBox.Text;
            string pass = passwordBox.Text;

            var resutl = connection.users.Where(s => s.Username == user && s.Password == pass);

            if (resutl.Count() == 0)
                MessageBox.Show("the password is incorrect");
            else if(resutl.Count()== 1)
            {
                var info = resutl.First();
                MessageBox.Show("Welcome Mr." + info.LName);
            }


            

        }
    }
}
