﻿using System;

//a custom attribute BugFix to be assigned to a class and its members
[AttributeUsage(AttributeTargets.Class |
AttributeTargets.Constructor |
AttributeTargets.Field |
AttributeTargets.Method |
AttributeTargets.Property,
AllowMultiple = true)]
public class FourAttr : Attribute
{
    private int bugNo;
    private string developer;
    private string lastReview;
    public string message;
    public FourAttr(int bg, string dev, string d)
    {
        this.bugNo = bg;
        this.developer = dev;
        this.lastReview = d;
    }
    public int BugNo
    {
        get
        {
            return bugNo;
        }
    }

    public string Developer
    {
        get
        {
            return developer;
        }
    }

    public string LastReview
    {
        get
        {
            return lastReview;
        }
    }

    public string Message
    {
        get
        {
            return message;
        }
        set
        {
            message = value;
        }
    }
}
