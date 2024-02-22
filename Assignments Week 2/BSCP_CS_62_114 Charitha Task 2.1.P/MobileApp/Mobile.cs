// BSCP|CS|62|114   Charitha Pieris

using System;

class Mobile
{
   
    private String accType, device, number;
    private double balance;

 
    private const double CALL_COST = 0.245;
    private const double TEXT_COST = 0.078;

    public Mobile (String accType, String device, String number)
    {
        this.accType = accType;
        this.device = device;
        this.number = number;
        this.balance = 0.0;         // Initial balance is set to zero.
    }       

    
    public String getAccType()      // Getter method for retrieving the account type.
    {
        return this.accType;
    }

    public String getDevice()        // Getter method for retrieving the device.
    {
        return this.device;
    }

    public String getNumber()        // Getter method for retrieving the phone number
    {
        return this.number;
    }

    public String getBalance()      // Getter method for retrieving the balance formatted as currency. USD ($)
    {   
        return this.balance.ToString("C");
    }

    public void setAccType(String accType)  // Setter method for updating the account type.
    {
        this.accType = accType;
    }

    public void setDevice(String device)     // Setter method for updating the device.
    {
        this.device = device;
    }

    public void setNumber(String number)     // Setter method for updating the Phone number.
    {
        this.number = number;
    }
    
    public void setBalance(double balance)  // Setter method for updating the balance.
    {
        this.balance = balance;
    }


    public void addCredit(double amount)      // Method to add credit to the balance.
    {
        this.balance += amount;
        Console.WriteLine("Credit added successfully. New Balance: " + getBalance());
    }

    public void makeCall(int minutes)
    {
        double cost = minutes * CALL_COST;  // Adding cost to the given amount
        this.balance -= cost;
        Console.WriteLine("Call made. New Balance: " + getBalance());
    }

    public void sendText(int numtexts)
    {
        double cost = numtexts * TEXT_COST;
        this.balance -= cost;
        Console.WriteLine("Text sent. New Balance: " + getBalance());
    }

}





