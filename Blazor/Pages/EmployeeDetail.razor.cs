﻿using BethanysPieShopHRM.Shared.Domain;
using Blazor.Models;
using Microsoft.AspNetCore.Components;

namespace Blazor.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; }

        public Employee? Employee { get; set; } = new Employee();

        protected override Task OnInitializedAsync()
        {
            Employee = MockDataService.Employees.FirstOrDefault(e => e.EmployeeId == int.Parse(EmployeeId));

            return base.OnInitializedAsync();   
        }
    }
}
