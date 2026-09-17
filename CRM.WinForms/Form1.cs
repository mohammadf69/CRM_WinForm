using CRM.WinForms.Forms.Customers;
using Microsoft.Extensions.DependencyInjection;

namespace CRM.WinForms
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Form1( IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void نمایشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var form = _serviceProvider
               .GetRequiredService<CustomerListForm>();

            form.ShowDialog();
        }
    }
}
