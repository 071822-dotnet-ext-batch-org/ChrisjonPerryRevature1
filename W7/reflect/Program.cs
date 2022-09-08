using System.Reflection;

namespace reflect{
class Program
{
    
    public string MyMood { get; set; } = "cheery";
    public int myPopSticks { get; set; } = 4;
    private static int a = 12, b = 20, c= 40;
    public Program(){}
    static void Main(string[] args)
    {
        #region access the properties and fields in a class
        //first use reflection to get  the data from local vars.
        Type progType= typeof(Program);
       // the type object representing program give you more internal meta data than a program object created programmatically
        //Program p = new Program();
     MemberInfo[] memberInfoArray = progType.GetMember("MyMood");
     
     foreach (MemberInfo mi in  memberInfoArray)
     {
        System.Console.WriteLine($"{mi.DeclaringType} declared {mi.Name} with a type of {mi.GetType}.....");
     }
     // only works for fields and not properties
     FieldInfo? fi = progType.GetField("a", BindingFlags.Public |BindingFlags.Instance | BindingFlags.NonPublic |BindingFlags.Static);
     if(fi !=null){
     fi?.SetValue(progType,2);
     System.Console.WriteLine($"{fi?.Name} is an {fi?.GetType()} and its value is {fi?.GetValue(null)}");
     }
     else System.Console.WriteLine("fi was null...");
    var gm =  progType.GetMembers();
    foreach (var item in gm)
    {
      System.Console.WriteLine($"{item.Name} is a type {item.GetType}");  
    }
    var gpm = progType.GetProperties();
    var x = progType.GetProperty("MyMood");
    //x.GetValue(progType);
    foreach (var item in gpm)
    {
        System.Console.WriteLine($"{item.Name} is a {item.GetType} and it's value is ");
    }
    }
    #endregion
    
    Assembly assemblyType = typeof(Program).Assembly;
    Console.WriteLine($"{assemblyType.Location}");


    
}
}
