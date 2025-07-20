using System;
using System.Windows.Forms;
using EShift_App.Model;

namespace EShift_App.View
{
    public partial class LoadEditorForm : Form
    {
        private readonly Load? _loadToEdit;
        public Load EditedLoad { get; private set; }

        // Constructor can be called for "Add" (loadToEdit is null) or "Edit"
        public LoadEditorForm(Load? loadToEdit = null)
        {
            InitializeComponent();
            _loadToEdit = loadToEdit;
            EditedLoad = _loadToEdit ?? new Load();
        }

        private void LoadEditorForm_Load(object sender, EventArgs e)
        {
            if (_loadToEdit != null)
            {
                this.Text = "Edit Load";
                // Populate fields with existing data
                txtGoodsDescription.Text = _loadToEdit.GoodsDescription;
                numWeight.Value = _loadToEdit.Weight;
                numVolume.Value = _loadToEdit.Volume;
            }
            else
            {
                this.Text = "Add New Load";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGoodsDescription.Text))
            {
                MessageBox.Show("Goods Description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Populate the public property with the form's data
            EditedLoad.GoodsDescription = txtGoodsDescription.Text;
            EditedLoad.Weight = numWeight.Value;
            EditedLoad.Volume = numVolume.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
