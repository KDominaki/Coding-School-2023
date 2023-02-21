using Session30.EF.Repositories;
using Session30.Web.Server.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using Session30.Web.Shared;

namespace Session30.WF
{
    
    public partial class CustomersView : Form
    {
        private HttpClient _httpClient;
        private List<CustomerListDto> _customerList = new();
        public CustomersView()
        {
            
            InitializeComponent();
            
        }

        private async void CustomersView_Load(object sender, EventArgs e)
        {
            _httpClient = new HttpClient();

            await LoadItemsFromServer();
            GridData();
        }
        
        private async Task LoadItemsFromServer()
        {
            var _customerList = await _httpClient.GetFromJsonAsync<List<CustomerListDto>>("https://localhost:7117//customer");
        }

        public void GridData()
        {
            customersGridView.DataSource = _customerList;
        }
    }
}
