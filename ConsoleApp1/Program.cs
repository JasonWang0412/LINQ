using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

	class Person
	{
		internal string Name
		{
			get; set;
		}
		internal int Age
		{
			get; set;
		}
	}

	internal class Program
	{
		static void Main( string[] args )
		{
			List<Person> personList = new List<Person>() {
				new Person() { Name = "A", Age = 10 },
				new Person() { Name = "B", Age = 11 },
				new Person() { Name = "C", Age = 12 },
				new Person() { Name = "D", Age = 13 },
				new Person() { Name = "E", Age = 14 },
			};
			var Var = personList.Where( person => person.Age > 12 ).
				Select( adult => new { Foo = adult.Name + adult.Age.ToString() } );
			foreach( var data in Var ) {
				Console.WriteLine( data.Foo );
			}
			Console.ReadKey();
		}
	}
}
