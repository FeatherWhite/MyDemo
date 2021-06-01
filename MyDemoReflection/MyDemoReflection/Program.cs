using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGetType();
            GetObjectInfo<string>();
            Console.ReadLine();
        }
        /// <summary>
        /// 各种对象GetType的使用
        /// </summary>
        static void UseGetType()
        {
            Type t1 = DateTime.Now.GetType();
            Type t2 = typeof(DateTime);
            Type t3 = typeof(DateTime[]);
            Type t4 = typeof(DateTime[,]);
            Type t5 = typeof(Dictionary<int, int>);
            Type t6 = typeof(Dictionary<,>);
            Type t7 = Assembly.GetExecutingAssembly().GetType("MyDemoReflection.Program");

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
        }
        /// <summary>
        /// 获取类型信息
        /// </summary>
        static void GetObjectInfo<T>()
        {
            Type myType = typeof(T);
            string name = myType.Name;
            Type baseType = myType.BaseType;
            Assembly assem = myType.Assembly;
            bool isPublic = myType.IsPublic;
            Console.WriteLine("myType is :{0}",name);
            Console.WriteLine("baseType is :{0}",baseType);
            Console.WriteLine("assembly is :{0}",assem);
            Console.WriteLine("is public?:{0}",isPublic);
        }
    }
}
