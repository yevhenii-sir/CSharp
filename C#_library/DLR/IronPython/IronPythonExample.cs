using IronPython.Hosting; //2.7.11 vers
using Microsoft.Scripting.Hosting;

namespace LearnCSharpOther
{
    static class Program
    {
        static void Main(string[] args)
        {
            ScriptEngine engine = Python.CreateEngine();
            engine.Execute("print 'hello, world'");
        }
    }
}
