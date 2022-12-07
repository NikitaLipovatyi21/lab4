using System.Diagnostics;

namespace lab_4_oop
{
    class A
    {
virtual internal void WriteDebug(string String,int Int, double Double)
        {
            Debug.WriteLine("String parameter:" + String);
            Debug.WriteLine("Int parameter:" + Int);
            Debug.WriteLine("Double parameter:" + Double);
        }

    }
}
