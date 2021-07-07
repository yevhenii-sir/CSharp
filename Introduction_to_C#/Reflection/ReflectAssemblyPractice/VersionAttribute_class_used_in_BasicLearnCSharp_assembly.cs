using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)] //использование в классах и методах
public class VersionAttribute : Attribute
{
    public double Version { get; private set; }

    public string Comment { get; private set; }

    public VersionAttribute(double version, string comment)
    {
        Version = version;
        Comment = comment;
    }
}
