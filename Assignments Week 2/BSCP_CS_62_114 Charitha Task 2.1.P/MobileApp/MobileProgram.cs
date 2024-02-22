// BSCP|CS|62|114   Charitha Pieris

using System;

namespace MobileProgram
{
  class MobileProgram
  {
    static void Main(string[] args)
    {
        // Mobile class with initial values
        Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6", "07712223344");

        // Display initial information about the mobile
        Console.WriteLine();
        Console.WriteLine("Account Type: " 
          + jimMobile.getAccType() + "\nmobile Number: "
          + jimMobile.getNumber() + "\nDevice: " 
          + jimMobile.getDevice() + "\nBalance: " 
          + jimMobile.getBalance());

        // Update mobile information using setter methods
        jimMobile.setAccType("Monthly");
        jimMobile.setNumber("0774003200");
        jimMobile.setDevice("Iphone 16");
        jimMobile.setBalance(80.50);
        
        // Display updated information about the mobile.
        Console.WriteLine();
        Console.WriteLine("Account Type: " 
          + jimMobile.getAccType() + "\nmobile Number: "
          + jimMobile.getNumber() + "\nDevice: " 
          + jimMobile.getDevice() + "\nBalance: " 
          + jimMobile.getBalance());

        // Update mobile information again using setter methods.
        jimMobile.setAccType("PAYG");
        jimMobile.setNumber("07713334466");
        jimMobile.setDevice("iPhone 6S");
        jimMobile.setBalance(15.50);

        Console.WriteLine();
        Console.WriteLine("Account Type: " 
          + jimMobile.getAccType() + "\nmobile Number: " 
          + jimMobile.getNumber() + "\nDevice: " 
          + jimMobile.getDevice() + "\nBalance: " 
          + jimMobile.getBalance());

        //adding credit, making a call, and sending a text
        Console.WriteLine();
        jimMobile.addCredit(10.0);
        jimMobile.makeCall(5);
        jimMobile.sendText(2);

        Console.ReadLine();
    }
  }
}