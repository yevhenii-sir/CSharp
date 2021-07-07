using System;

[AttributeUsage(AttributeTargets.All)]
public class RemarkAttribute : Attribute
{
    private string pri_remark;

    public string Supplement;

    public RemarkAttribute(string comment)
    {
        pri_remark = comment;
        Supplement = "Отсутствует";
    }

    public string Remark
    {
        get { return pri_remark; }
    }

    //или создать свойство private string Remark {get; private set; }
}
