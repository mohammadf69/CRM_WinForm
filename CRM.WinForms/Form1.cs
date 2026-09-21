using CRM.WinForms.Forms.Customers;

namespace CRM.WinForms
{
    public partial class Form1 : Form
    {
        private readonly Func<CustomerListForm> _customerListFormFactory;

        public Form1(Func<CustomerListForm> customerListFormFactory)
        {
            InitializeComponent();

            _customerListFormFactory = customerListFormFactory;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void نمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = _customerListFormFactory();

            form.ShowDialog();
        }
    }
}
