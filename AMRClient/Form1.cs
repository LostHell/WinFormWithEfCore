using AMRServices.Services;

namespace AMRClient
{
    public partial class Form1 : Form
    {
        private IUserServices userService;

        public Form1(IUserServices userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        private async void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int age = int.Parse(textBoxAge.Text);

            var user = await this.userService.CreateNewUser(name, age);

            listViewUsers.Items.Add($"{user.Name} {age}");
        }
    }
}