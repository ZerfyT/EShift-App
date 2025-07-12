using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;
using EShift_App.Data.Repositories;
using EShift_App.Model;

namespace EShift_App.View;

public partial class AssistantForm : Form
{
    private readonly IAssistantRepository _assistantRepository;
    private BindingList<Assistant> _assistantsBindingList;
    private Assistant? _selectedAssistant;

    public AssistantForm(IAssistantRepository assistantRepository)
    {
        InitializeComponent();
        _assistantRepository = assistantRepository;
        _assistantsBindingList = new BindingList<Assistant>();
    }

    private async void AssistantForm_Load(object sender, EventArgs e)
    {
        SetupDataGridView();
        await LoadAssistantsAsync();
        SetFormState(FormState.Viewing);
    }

    private void SetupDataGridView()
    {
        dataGridViewAssistants.DataSource = _assistantsBindingList;
        dataGridViewAssistants.AutoGenerateColumns = false;

        // Define columns for the Assistant model
        dataGridViewAssistants.Columns.Clear();
        dataGridViewAssistants.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FirstName", HeaderText = "First Name", Width = 120 });
        dataGridViewAssistants.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LastName", HeaderText = "Last Name", Width = 120 });
        dataGridViewAssistants.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "Phone Number", Width = 120 });
        dataGridViewAssistants.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HireDate", HeaderText = "Hire Date", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

        dataGridViewAssistants.SelectionChanged += DataGridViewAssistants_SelectionChanged;
    }

    private async Task LoadAssistantsAsync()
    {
        var assistants = await _assistantRepository.GetAllAsync();
        _assistantsBindingList.Clear();
        foreach (var assistant in assistants)
        {
            _assistantsBindingList.Add(assistant);
        }
    }

    private void DataGridViewAssistants_SelectionChanged(object? sender, EventArgs e)
    {
        if (dataGridViewAssistants.CurrentRow?.DataBoundItem is Assistant assistant)
        {
            _selectedAssistant = assistant;
            DisplayAssistantDetails();
            SetFormState(FormState.Viewing);
        }
    }

    private void DisplayAssistantDetails()
    {
        if (_selectedAssistant != null)
        {
            txtFirstName.Text = _selectedAssistant.FirstName;
            txtLastName.Text = _selectedAssistant.LastName;
            txtPhoneNumber.Text = _selectedAssistant.PhoneNumber;
            dtpHireDate.Value = _selectedAssistant.HireDate;
        }
    }

    private void ClearInputFields()
    {
        txtFirstName.Clear();
        txtLastName.Clear();
        txtPhoneNumber.Clear();
        dtpHireDate.Value = DateTime.Now;
        _selectedAssistant = null;
        dataGridViewAssistants.ClearSelection();
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        var assistants = await _assistantRepository.SearchAsync(txtSearch.Text);
        _assistantsBindingList.Clear();
        foreach (var assistant in assistants)
        {
            _assistantsBindingList.Add(assistant);
        }
    }

    private void btnAddNew_Click(object sender, EventArgs e)
    {
        SetFormState(FormState.Adding);
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;

        // ToDo: Implement a PhoneNumberExistsAsync method in IAssistantRepository for duplicate checks

        if (_selectedAssistant == null) // Add new assistant
        {
            var newAssistant = new Assistant
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                HireDate = dtpHireDate.Value
            };
            await _assistantRepository.AddAsync(newAssistant);
            _assistantsBindingList.Add(newAssistant);
        }
        else // Update existing assistant
        {
            _selectedAssistant.FirstName = txtFirstName.Text;
            _selectedAssistant.LastName = txtLastName.Text;
            _selectedAssistant.PhoneNumber = txtPhoneNumber.Text;
            _selectedAssistant.HireDate = dtpHireDate.Value;
            _assistantRepository.Update(_selectedAssistant);
            _assistantsBindingList.ResetItem(_assistantsBindingList.IndexOf(_selectedAssistant));
        }

        await _assistantRepository.SaveChangesAsync();
        MessageBox.Show("Assistant saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        SetFormState(FormState.Viewing);
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedAssistant == null)
        {
            MessageBox.Show("Please select an assistant to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmResult = MessageBox.Show($"Are you sure you want to delete {_selectedAssistant.FirstName} {_selectedAssistant.LastName}?",
                                         "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirmResult == DialogResult.Yes)
        {
            _assistantRepository.Delete(_selectedAssistant);
            await _assistantRepository.SaveChangesAsync();
            _assistantsBindingList.Remove(_selectedAssistant);
            ClearInputFields();
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        if (_selectedAssistant != null)
        {
            DisplayAssistantDetails();
        }
        else
        {
            ClearInputFields();
        }
        SetFormState(FormState.Viewing);
    }

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
        {
            MessageBox.Show("First Name and Phone Number are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        return true;
    }

    private void SetFormState(FormState state)
    {
        panelDetails.Enabled = (state == FormState.Adding || state == FormState.Editing);
        btnSave.Enabled = (state == FormState.Adding || state == FormState.Editing);
        btnCancel.Enabled = (state == FormState.Adding || state == FormState.Editing);
        btnAddNew.Enabled = (state == FormState.Viewing);
        btnDelete.Enabled = (state == FormState.Viewing && _selectedAssistant != null);

        if (state == FormState.Adding)
        {
            ClearInputFields();
            txtFirstName.Focus();
        }
    }
}

// This enum can be shared across forms, e.g., in its own file
// internal enum FormState { Viewing, Adding, Editing }