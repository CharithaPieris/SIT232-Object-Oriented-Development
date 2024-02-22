// BSCP|CS|62|114   Charitha Pieris

using System;

class Employee
{
    private string employeeName;
    private double currentSalary;
    private double raiseSalary;

    public Employee(string employeeName, double currentSalary)
    {
        this.employeeName = employeeName;
        this.currentSalary = currentSalary;
        this.raiseSalary = currentSalary;
    }

    public string GetName()
    {
        return employeeName;
    }

    public double GetSalary()
    {
        return currentSalary;
    }

    public void SetName(string name)
    {
        employeeName = name;
    }

    public void SetSalary(double salary)
    {
        currentSalary = salary;
    }

    public void ApplyRaise()
    {
        raiseSalary = currentSalary * 10 / 100;
    }

    public double GetRaisedSalary()
    {
        return raiseSalary;
    }

    public double GetSalaryAfterTax()
    {
        return currentSalary - Tax();
    }

    public double Tax()
    {
        if (currentSalary <= 18200)
        {
            return 0;
        }
        else if (currentSalary <= 37000)
        {
            return 0.19 * (currentSalary - 18200);
        }
        else if (currentSalary <= 90000)
        {
            return 3572 + 0.325 * (currentSalary - 37000);
        }
        else if (currentSalary <= 180000)
        {
            return 20797 + 0.37 * (currentSalary - 90000);
        }
        else
        {
            return 54096 + 0.45 * (currentSalary - 180000);
        }
    }
}
