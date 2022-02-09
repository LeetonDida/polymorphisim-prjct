	/**

// Class Book is derived from class Possession. Both
// classes have a print() function with no parameters. Both with two constructor, one
// with parameters and one without. Different instance/objects are created.

// EXERCISES:
// 1. Read the program to see if you can understand it.  Try to predict 
//    what the output will be, then run it.
// 2. How can we make p2, p3 and p4 use the print method of Book wihtout changing the code
//    in the Main method?
// 3. Try to realise that the constructor with parmeters in Book can call the constructor
//    with parametes in Possession, test the implementation.


 */

using System;

namespace ConsoleApplication
{
    public class Polym01
    {
        public static void Main(string[] args)
        {
               Possession p1 = new Possession();
               Possession p2 = new Book();
			   Possession p3 = new Book("Title1","Author1");
			   Possession p4 = new Book("Title2","Author2");

			   Console.WriteLine("Printing p1");
			   p1.print();

			   Console.WriteLine("Printing p2");
			   p2.print();

			   Console.WriteLine("Printing p3");
			   p3.print();


			   Console.WriteLine("Printing p4");
			   p4.print();


 Console.ReadKey();


        }
        
		
    }

	public class Possession {
			private string type;
			private float value;

			public Possession(){
				type = "default";
				value = 5f;
			}

			public Possession(string _type){
				type = _type;
			}

			public virtual void print(){
				Console.WriteLine(type + " with value " + value);
			}
	}

	public class Book : Possession {
			private string title;
			private string author;

			public Book(){
				title = "default";
				author = "default";
			}

			public Book(string _title, string _author){
				title = _title;
				author = _author;
			}

			public override void print(){
				base.print();
				Console.WriteLine("Title:  " + title);
				Console.WriteLine("Author:  " + author);
			}
	}
}
