using CRM.Application.DTOs.Customers;
using CRM.Application.Interfaces;
using CRM.Infrastructure.Services;
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
        private readonly int? _customerId;
        public CustomerEditForm(ICustomerService customerService, int? customerId = null)
        {
            InitializeComponent();
            _customerService = customerService;
            _customerId = customerId;
        }
        private string CheckIFnullValeu()
        {
            string messageForNUll = "";
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                messageForNUll = "  نام را وارد کنید/n";
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                messageForNUll += "  نام خانوادگی را وارد کنید/n";
            }
            if (string.IsNullOrWhiteSpace(txtMobile.Text))
            {
                messageForNUll += "  موبایل  را وارد کنید/n";
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                messageForNUll += "  تلفن  را وارد کنید/n";
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                messageForNUll += "  آدرس را وارد کنید/n";
            }

            return messageForNUll;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckIFnullValeu() == "")
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
                            IsActive = true
                        };

                        await _customerService.CreateAsync(dto);
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
                            IsActive = chkIsActive.Checked
                        };

                        await _customerService.UpdateAsync(dto);
                    }

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private async void CustomerEditForm_Load(object sender, EventArgs e)
        {
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
    }
}
