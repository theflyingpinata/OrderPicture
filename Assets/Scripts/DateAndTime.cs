using System;
using System.Collections.Generic;
using System.Text;

[System.Serializable]
public class DateAndTime
{
    public int year;
    public int month;
    public int day;
    public int hour;
    public int minute;

    public DateAndTime(int year, int month, int day, int hour, int minute)
    {
        this.year = year;
        this.month = month;
        this.day = day;
        this.hour = hour;
        this.minute = minute;
    }

    public override string ToString()
    {
        return DateToString() + " " + TimeToString();
    }
    public string DateToString()
    {
        return string.Format("{0}/{1}/{2}", month, day, year);
    }

    public string TimeToString()
    {
        return string.Format("{0}:{1}", hour, minute);
    }

    public static bool operator <=(DateAndTime first, DateAndTime second)
    {
        if (first.year == second.year && first.month == second.month && first.day == second.day && first.hour == second.hour && first.minute == second.minute)
        {
            return true;
        }
        return first < second;
    }
    public static bool operator >=(DateAndTime first, DateAndTime second)
    {
        if (first.year == second.year && first.month == second.month && first.day == second.day && first.hour == second.hour && first.minute == second.minute)
        {
            return true;
        }
        return first > second;
    }
    public static bool operator <(DateAndTime first, DateAndTime second)
    {
        return first.year < second.year ? true : first.year > second.year ? false :
                first.month < second.month ? true : first.month > second.month ? false :
                first.day < second.day ? true : first.day > second.day ? false :
                first.hour < second.hour ? true : first.hour > second.hour ? false :
                first.minute < second.minute ? true : first.minute > second.minute ? false : false;
        /*
        if (first.year < second.year)
        {
            return true;
        }
        else if(first.year > second.year)
        {
            return false;
        }
        if(first.month < second.month)
        {
            return true;
        }
        else if (first.month > second.month)
        {
            return false;
        }
        if (first.day < second.day)
        {
            return true;
        }
        else if (first.day > second.day)
        {
            return false;
        }
        if (first.hour < second.hour)
        {
            return true;
        }
        else if (first.hour > second.hour)
        {
            return false;
        }
        if (first.minute < second.minute)
        {
            return true;
        }
        else if (first.minute > second.minute)
        {
            return false;
        }
        return false;
        */
    }
    public static bool operator >(DateAndTime first, DateAndTime second)
    {
        return first.year > second.year ? true : first.year < second.year ? false :
                first.month > second.month ? true : first.month < second.month ? false :
                first.day > second.day ? true : first.day < second.day ? false :
                first.hour > second.hour ? true : first.hour < second.hour ? false :
                first.minute > second.minute ? true : first.minute < second.minute ? false : false;
        /*
        if (first.year > second.year)
        {
            return true;
        }
        else if (first.year < second.year)
        {
            return false;
        }
        if (first.month > second.month)
        {
            return true;
        }
        else if (first.month < second.month)
        {
            return false;
        }
        if (first.day > second.day)
        {
            return true;
        }
        else if (first.day < second.day)
        {
            return false;
        }
        if (first.hour > second.hour)
        {
            return true;
        }
        else if (first.hour < second.hour)
        {
            return false;
        }
        if (first.minute > second.minute)
        {
            return true;
        }
        else if (first.minute < second.minute)
        {
            return false;
        }
        return false;
        */
    }
}

