using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace akbank_API_Deneme.Controllers;

public class Employee
{

    public string Name { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public double HourlySalary { get; set; }

}
[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    public EmployeeController()
    {
    }

    [HttpPost]
    public Employee Post([FromBody] Employee value)
    {

        if (value.DateOfBirth < DateTime.Now.AddYears(-30) && value.HourlySalary < 200)
        {
            throw new Exception("Minimum hourly salary is not valid.");
        }
        else if (value.DateOfBirth > DateTime.Now.AddYears(-30) && value.HourlySalary < 50)
        {
            throw new Exception("Minimum hourly salary is not valid.");
        }

        return null;
    }
}
