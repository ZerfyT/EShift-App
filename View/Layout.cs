using Microsoft.Extensions.DependencyInjection;

namespace EShift_App.View
{
    public partial class Layout : Form
    {
        private int childFormNumber = 0;
        private readonly IServiceProvider _serviceProvider;

        public Layout(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerForm = _serviceProvider.GetRequiredService<CustomerForm>();
            customerForm.MdiParent = this;
            customerForm.Show();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var driverForm = _serviceProvider.GetRequiredService<DriverForm>();
            driverForm.MdiParent = this;
            driverForm.Show();
        }

        private void assistantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var assistantForm = _serviceProvider.GetRequiredService<AssistantForm>();
            assistantForm.MdiParent = this;
            assistantForm.Show();
        }

        // You can add similar methods for other menu items
        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Example for opening Jobs form
            // var jobsForm = _serviceProvider.GetRequiredService<JobsForm>();
            // jobsForm.MdiParent = this;
            // jobsForm.Show();
        }

        private void lorriersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lorryForm = _serviceProvider.GetRequiredService<LorryForm>();
            lorryForm.MdiParent = this;
            lorryForm.Show();
        }

        private void newJobToolStripButton_Click(object sender, EventArgs e)
        {
            var customerForm = _serviceProvider.GetRequiredService<CustomerDashboard>();
            customerForm.MdiParent = this;
            customerForm.Show();
        }

        // Default event handlers from the template
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Layout_Load(object sender, EventArgs e)
        {
            var adminDashboardForm = _serviceProvider.GetRequiredService<AdminDashboard>();
            adminDashboardForm.MdiParent = this;
            adminDashboardForm.Show();
        }
    }
}
