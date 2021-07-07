using System;

[AttributeUsage(AttributeTargets.All)]
public class RemarkAttribute : Attribute
{
    private string pri_remark;

    public RemarkAttribute(string comment)
    {
        pri_remark = comment;
    }

    public string Remark
    {
        get { return pri_remark; }
    }

    //или создать свойство private string Remark {get; private set; }
}
