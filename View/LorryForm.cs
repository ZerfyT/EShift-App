using System.ComponentModel;
using EShift_App.Data.Repositories;
using EShift_App.Model;

namespace EShift_App.View;

public partial class LorryForm : Form
{
    private readonly ILorryRepository _lorryRepository;
    private BindingList<Lorry> _lorriesBindingList;
    private Lorry? _selectedLorry;

    public LorryForm(ILorryRepository lorryRepository)
    {
        InitializeComponent();
        _lorryRepository = lorryRepository;
        _lorriesBindingList = new BindingList<Lorry>();
    }

    private async void LorryForm_Load(object sender, EventArgs e)
    {
        SetupDataGridView();
        await LoadLorriesAsync();
        SetFormState(FormState.Viewing);
    }

    private void SetupDataGridView()
    {
        dataGridViewLorries.DataSource = _lorriesBindingList;
        dataGridViewLorries.AutoGenerateColumns = false;

        dataGridViewLorries.Columns.Clear();
        dataGridViewLorries.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RegistrationNumber", HeaderText = "Registration Number", Width = 150 });
        dataGridViewLorries.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Model", HeaderText = "Model", Width = 150 });
        dataGridViewLorries.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Capacity", HeaderText = "Capacity (kg)", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

        dataGridViewLorries.SelectionChanged += DataGridViewLorries_SelectionChanged;
    }

    private async Task LoadLorriesAsync()
    {
        var lorries = await _lorryRepository.GetAllAsync();
        _lorriesBindingList.Clear();
        foreach (var lorry in lorries)
        {
            _lorriesBindingList.Add(lorry);
        }
    }

    private void DataGridViewLorries_SelectionChanged(object? sender, EventArgs e)
    {
        if (dataGridViewLorries.CurrentRow?.DataBoundItem is Lorry lorry)
        {
            _selectedLorry = lorry;
            DisplayLorryDetails();
            SetFormState(FormState.Viewing);
        }
    }

    private void DisplayLorryDetails()
    {
        if (_selectedLorry != null)
        {
            txtRegistrationNumber.Text = _selectedLorry.RegistrationNumber;
            txtModel.Text = _selectedLorry.Model;
            numCapacity.Value = (decimal)_selectedLorry.Capacity;
        }
    }

    private void ClearInputFields()
    {
        txtRegistrationNumber.Clear();
        txtModel.Clear();
        numCapacity.Value = 0;
        _selectedLorry = null;
        dataGridViewLorries.ClearSelection();
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        var lorries = await _lorryRepository.SearchAsync(txtSearch.Text);
        _lorriesBindingList.Clear();
        foreach (var lorry in lorries)
        {
            _lorriesBindingList.Add(lorry);
        }
    }

    private void btnAddNew_Click(object sender, EventArgs e)
    {
        SetFormState(FormState.Adding);
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInput()) return;

        int? lorryIdToIgnore = _selectedLorry?.LorryID;
        if (await _lorryRepository.RegistrationNumberExistsAsync(txtRegistrationNumber.Text, lorryIdToIgnore))
        {
            MessageBox.Show("A lorry with this registration number already exists.", "Duplicate Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (_selectedLorry == null)
        {
            var newLorry = new Lorry
            {
                RegistrationNumber = txtRegistrationNumber.Text,
                Model = txtModel.Text,
                Capacity = (float)numCapacity.Value
            };
            await _lorryRepository.AddAsync(newLorry);
            _lorriesBindingList.Add(newLorry);
        }
        else
        {
            _selectedLorry.RegistrationNumber = txtRegistrationNumber.Text;
            _selectedLorry.Model = txtModel.Text;
            _selectedLorry.Capacity = (float)numCapacity.Value;
            _lorryRepository.Update(_selectedLorry);
            _lorriesBindingList.ResetItem(_lorriesBindingList.IndexOf(_selectedLorry));
        }

        await _lorryRepository.SaveChangesAsync();
        MessageBox.Show("Lorry saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        SetFormState(FormState.Viewing);
    }

    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedLorry == null)
        {
            MessageBox.Show("Please select a lorry to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirmResult = MessageBox.Show($"Are you sure you want to delete lorry with registration '{_selectedLorry.RegistrationNumber}'?",
                                         "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirmResult == DialogResult.Yes)
        {
            _lorryRepository.Delete(_selectedLorry);
            await _lorryRepository.SaveChangesAsync();
            _lorriesBindingList.Remove(_selectedLorry);
            ClearInputFields();
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        if (_selectedLorry != null)
        {
            DisplayLorryDetails();
        }
        else
        {
            ClearInputFields();
        }
        SetFormState(FormState.Viewing);
    }

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtRegistrationNumber.Text))
        {
            MessageBox.Show("Registration Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        btnDelete.Enabled = (state == FormState.Viewing && _selectedLorry != null);

        if (state == FormState.Adding)
        {
            ClearInputFields();
            txtRegistrationNumber.Focus();
        }
    }
}