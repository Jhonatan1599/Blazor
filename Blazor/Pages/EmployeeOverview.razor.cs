using BethanysPieShopHRM.Shared.Domain;
using Blazor.Models;

namespace Blazor.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default!;

        private Employee? _selectedEmployee;

        private string Title = "Employee overview";

        // set up the component 
        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }

        // event handler
        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }

    }
}
