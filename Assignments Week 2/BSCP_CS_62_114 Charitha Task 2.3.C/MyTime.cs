// BSCP|CS|62|114   Charitha Pieris

using System;

class MyTime
{
    private int hour;
    private int minute;
    private int second;

   
    public MyTime()    // Default constructor to set the time to 00:00:00. 
    {
        hour = 0;
        minute = 0;
        second = 0;
    }

    public MyTime(int hour, int minute, int second)
    {
        SetTime(hour, minute, second);
    }

    public void SetTime(int hour, int minute, int second)
    {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
    }

    // Setting values 
    public void SetHour(int hour) // Gives the specified value to the instance variable hour.
    {

            this.hour = hour;
            Console.WriteLine("Invalid hour!");
    }

    public void SetMinute(int minute) // Gives the specified value to the instance variable minute.
    {
       
            this.minute = minute;
            Console.WriteLine("Invalid minute!");
    
    }

    public void SetSecond(int second) // Gives the specified value to the instance variable second.
    {
            this.second = second;
            Console.WriteLine("Invalid second!");
    }

    public int GetHour() // Gets the value of the instance variable hour.
    {
        return hour;
    }

    public int GetMinute() // Gets the value of the instance variable minute.
    {
        return minute;
    }

    public int GetSecond() // Gets the value of the instance variable second.
    {
        return second;
    }

    public override string ToString() // Returning time as String
    {
        return $"{hour:D2}:{minute:D2}:{second:D2}";
    }

    // Updating the variables
    public MyTime NextSecond()
    {
        second = (second + 1) % 60;
        if (second == 0)
        {
            minute = (minute + 1) % 60;
            if (minute == 0)
            {
                hour = (hour + 1) % 24;
            }
        }
        return this;
    }

    public MyTime NextMinute()
    {
        minute = (minute + 1) % 60;
        if (minute == 0)
        {
            hour = (hour + 1) % 24;
        }
        return this;
    }

    public MyTime NextHour()
    {
        hour = (hour + 1) % 24;
        return this;
    }

    public MyTime PreviousSecond()
    {
        second = (second - 1 + 60) % 60;
        if (second == 59)
        {
            minute = (minute - 1 + 60) % 60;
            if (minute == 59)
            {
                hour = (hour - 1 + 24) % 24;
            }
        }
        return this;
    }

    public MyTime PreviousMinute()
    {
        minute = (minute - 1 + 60) % 60;
        if (minute == 59)
        {
            hour = (hour - 1 + 24) % 24;
        }
        return this;
    }

    public MyTime PreviousHour()
    {
        hour = (hour - 1 + 24) % 24;
        return this;
    }

    private bool IsValidHour(int hour)
    {
        return hour >= 0 && hour <= 23;
    }

    private bool IsValidMinute(int minute)
    {
        return minute >= 0 && minute <= 59;
    }

    private bool IsValidSecond(int second)
    {
        return second >= 0 && second <= 59;
    }
}
