using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCS
{
	public class Program
	{
		static void Main (string[] args)
		{
            /**
			Console.WriteLine("Wonderful!!!");
			String x = "Hello";
			Console.WriteLine(x.Length);
			dynamic dobj;
			dobj = "dynamic string";
			Console.WriteLine(dobj);
			Console.WriteLine(dobj.Length);
			dobj = new int[] {10,20,23};
			Console.WriteLine(dobj);
			Console.WriteLine(dobj.Length);
			Console.WriteLine(dobj[1]);
			Console.ReadKey();

            **/
            //MessageBox.Show(caption: "I'm the Title of this dialogue box", text:"Press any key to continue!");
            //foo(body: "Press any key to continue!", title: "I'm the Title of this dialogue box");
            /*
             * greet("Hello", "Sam");
            greet("Elf");
            greet(body: "Jack");
            greet();
            greet(body: "Tom", title:"Harry");
            */
            string str = "abcd";
            Console.WriteLine(StringTest(str));
            Console.WriteLine(StringTest(@"abcdt/e"));
            Console.ReadKey();
        }

        static void foo (string title, string body)
        {
            MessageBox.Show(body, title);
            return;
        }

       static void greet(string title = "Hello", string body = "everyone!")
        {
            Console.WriteLine(title + " " + body);
        
        }

        static void greet(string body)
        {
            greet("Hello", body);
        }

        public static string StringTest(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

    }
    
}
