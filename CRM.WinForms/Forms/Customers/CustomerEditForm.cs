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
        public CustomerEditForm(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
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
            if (CheckIFnullValeu != null)
            {
                var dto = new CreateCustomerDto
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    NationalCode = txtNationalCode.Text.Trim(),
                    Mobile = txtMobile.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                try
                {
                    await _customerService.CreateAsync(dto);

                    MessageBox.Show(
                        "اطلاعات مشتری با موفقیت ذخیره شد",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

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
            else
            {
                MessageBox.Show(CheckIFnullValeu()
                       ,
                       "لطفا اطلاعات را وارد نمایید",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
