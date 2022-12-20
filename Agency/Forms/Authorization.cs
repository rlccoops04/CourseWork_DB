using Agency.Models;

namespace Agency
{
    public partial class Authorization : Form
    {
        public AgencyDbContext _context { get; set; }
        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            UCAuthorization ucAuthorization = new();
            this.Controls.Add(ucAuthorization);
            ucAuthorization.Location = new Point(80, 10);
            ucAuthorization.Show();
        }
    }
}