using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;

        // I want, in my EmployeeCard, to be able to click on the button and that will trigger an event that my EmployeeOverview will then react to by showing the QuickViewPopup.
        // When will that trigger this event from the EmployeeCard? In the EmployeeCard's UI
        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

        // Inject an instance of the Navigation Manager 
        [Inject] 
        public NavigationManager NavigationManager { get; set; } = default!;

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Employee.LastName))
            {
                throw new Exception("Last name can't be empty");
            }
        }

        public void NavigateToDetails(Employee selectedEmployee)
        {
            // we can write code here

            NavigationManager.NavigateTo(($"/employeedetail/{selectedEmployee.EmployeeId}"));
        }
    }
}
