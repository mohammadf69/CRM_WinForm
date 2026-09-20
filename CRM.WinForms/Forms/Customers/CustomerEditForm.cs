using CRM.Application.DTOs.Customers;
using CRM.Application.Interfaces;
using CRM.Infrastructure.Services;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.WinForms.Forms.Customers
{
    public partial class CustomerEditForm : Form
    {
        private readonly ICustomerService _customerService;
        private readonly ICompanyService _companyService;
        private readonly int? _customerId;
        ErrorProvider Provider;
        public CustomerEditForm(ICustomerService customerService, ICompanyService companyService, int? customerId = null)
        {
            InitializeComponent();
            _customerService = customerService;
            _customerId = customerId;
            _companyService = companyService;
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_customerId is null)
                {
                    var dto = new CreateCustomerDto
                    {
                        FirstName = txtFirstName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        NationalCode = txtNationalCode.Text.Trim(),
                        Mobile = txtMobile.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        IsActive = true,
                        CompanyId = cmbCompany.SelectedValue as int?
                    };



                    await _customerService.CreateAsync(dto);
                    MessageBox.Show(
                  "مشتری جدید ثبت شد",
                  "success",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                }
                else
                {
                    var dto = new UpdateCustomerDto
                    {
                        Id = _customerId.Value,
                        FirstName = txtFirstName.Text.Trim(),
                        LastName = txtLastName.Text.Trim(),
                        NationalCode = txtNationalCode.Text.Trim(),
                        Mobile = txtMobile.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        IsActive = chkIsActive.Checked,
                        CompanyId = cmbCompany.SelectedValue as int?
                    };

                    await _customerService.UpdateAsync(dto);
                    MessageBox.Show(
                                    "ویرایش مشتری با موفقیت انجام شد",
                                    "success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                DialogResult = DialogResult.OK;
            }
            catch (ValidationException ex)
            {
                Provider.Clear();

                foreach (var error in ex.Errors)
                {
                    switch (error.PropertyName)
                    {
                        case nameof(CreateCustomerDto.FirstName):
                        
                            Provider.SetError(
                                txtFirstName,
                                error.ErrorMessage);
                            break;

                        case nameof(CreateCustomerDto.LastName):
                       
                            Provider.SetError(
                                txtLastName,
                                error.ErrorMessage);
                            break;

                        case nameof(CreateCustomerDto.Mobile):
                        
                            Provider.SetError(
                                txtMobile,
                                error.ErrorMessage);
                            break;

                        case nameof(CreateCustomerDto.Email):
                        
                            Provider.SetError(
                                txtEmail,
                                error.ErrorMessage);
                            break;

                        case nameof(CreateCustomerDto.NationalCode):
                        
                            Provider.SetError(
                                txtNationalCode,
                                error.ErrorMessage);
                            break;
                    }
                }
            }


        }
        private void ClearValidationErrors()
        {
            Provider.Clear();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void CustomerEditForm_Load(object sender, EventArgs e)
        {
            await LoadCompaniesAsync();
            if (_customerId is null)
                return;

            var customer =
                await _customerService.GetByIdAsync(_customerId.Value);

            if (customer is null)
            {
                MessageBox.Show("Customer not found.");
                DialogResult = DialogResult.Cancel;
                return;
            }

            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtNationalCode.Text = customer.NationalCode;
            txtMobile.Text = customer.Mobile;
            txtPhone.Text = customer.Phone;
            txtEmail.Text = customer.Email;
            txtAddress.Text = customer.Address;
            chkIsActive.Checked = customer.IsActive;
        }
        private async Task LoadCompaniesAsync()
        {
            var companies = await _companyService.GetAllAsync();

            cmbCompany.DataSource = companies;

            cmbCompany.DisplayMember = "Name";
            cmbCompany.ValueMember = "Id";

            cmbCompany.SelectedIndex = -1;
        }
    }
}
