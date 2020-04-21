using System;

namespace SchoolPortal
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			var student = new Student ();

			Console.WriteLine (student.RegNumber);
		}
	}
}
