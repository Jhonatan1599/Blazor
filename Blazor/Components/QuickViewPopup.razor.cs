using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace Blazor.Components
{   
    //This component shows the details of an employee
    public partial class QuickViewPopup
    {
        [Parameter]
        public Employee? Employee { get; set; }

        private Employee? _employee;

        //There is a method that will be raised automatically when a value of a parameter is set or changed.So when an EmployeeCard raises an event to the EmployeeOverview that will change the value of the parameter on the QuickViewPopup, and I'm reacting to that inside of my QuickViewPopup by specifying here that this field here should be set to the value of the parameter. 
        protected override void OnParametersSet()
        {
            _employee = Employee;
        }

        public void Close()
        {
            _employee = null;
        }
    }
}
