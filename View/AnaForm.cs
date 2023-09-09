using SqlGuiApplication.View;

namespace SqlGuiApplication
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            new KategorilerForm().Show();
        }
    }
}