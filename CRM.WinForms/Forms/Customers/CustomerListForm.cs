using CRM.Application.Interfaces;

namespace CRM.WinForms.Forms.Customers
{
    public partial class CustomerListForm : Form
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerEditFormFactory _editFormFactory;

        public CustomerListForm(
            ICustomerService customerService,
            ICustomerEditFormFactory editFormFactory)
        {
            InitializeComponent();

            _customerService = customerService;
            _editFormFactory = editFormFactory;
        }

        private async Task LoadCustomersAsync()
        {
            try
            {
                var customers = await _customerService.GetAllAsync();

                dgvCustomers.DataSource = customers;
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

        private async void CustomerListForm_Load(object sender, EventArgs e)
        {
            await LoadCustomersAsync();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = txtSearch.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(search))
                {
                    await LoadCustomersAsync();
                    return;
                }

                var customers = await _customerService.SearchAsync(search);

                dgvCustomers.DataSource = customers;
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

        private async void btnNew_Click(object sender, EventArgs e)
        {
            using var form = _editFormFactory.Create();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                await LoadCustomersAsync();
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.Rows.Count > 0)
            {
                var customerId =
                    (int)dgvCustomers.CurrentRow.Cells["Id"].Value;

                using var form = _editFormFactory.Create(customerId);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await LoadCustomersAsync();
                }
            }
        }

        private void dgvCustomers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow is null)
                return;

            var customerId =
                (int)dgvCustomers.CurrentRow.Cells["Id"].Value;

            var confirm = MessageBox.Show(
                "آيا از حذف مشتری  مورد نظر  اطمینان دارید",
                "تایید",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                await _customerService.DeleteAsync(customerId);

                await LoadCustomersAsync();
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
}
