using CustomAttribute;
using System;
using System.Reflection;

[FourAttr(12,"test","D")]
public class Class1
{
	[FourAttr(11,"ilu","0707")]
	public Class1()
	{
        Attribute[] attributes = Attribute.GetCustomAttributes(typeof(Class1));
        MethodBase method = MethodBase.GetCurrentMethod();
        var attr = method.GetCustomAttributes(false);
        Console.WriteLine("ok");
	}
}
