/**

// Class Book is derived from class Possession. The program shows the casting
// between base and sub classes.

// EXERCISES:
// 1. Read the program to see if you can understand it.  Try to predict 
//    what the outcome will be, then run it.
// 2. How can we fix it?
// 3. After the fix, whether the code at line 35, 36 and 37 would case any exception? Why?


 */

using System;

namespace ConsoleApplication1
{
    public class Polym02
    {
        public static void Main(string[] args)
        {
			try {
               Possession p1 = new Possession();
               Book b1 = new Book();
               Possession b2 = new Book();

			   Possession p = null;
			   Book b = null;
			   p = p1;
			   p = b1; 
			   p = b2;

			   b = (Book)p1;
			   b = b1;
			   b =(Book) b2;
			} catch(Exception e) {
				 Console.WriteLine(e);
			}



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
