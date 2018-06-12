//This is a single-line comment.
/*
    This is a 
    multiline comment.
*/
//Comments are ignored by the compiler, and are useful for developers to explain or document their code.

//This is a 'using' declaration.
//Used to turn some statement into smaller ones.
//Like: System.Console.WriteLine() into just Console.WriteLine().
using System; //Now expresions starting with the prefix "System." can be also used without this prefix.

//Namespace declaration.
//This declares a namespace called "CSharpIntro".
//Namespaces are groups of classes or other namespaces.
namespace CSharpIntro
{
    //Class declaration.
    //This declares a class named "Program".
    //You can see classes as groups of methods, classes and some other stuff that are really not important for now.
    class Program
    {
        //Method declaration.
        //A methos consists of a sequence of statements that should be executed when the method is invoked ("called").
        //This declares a method called "Main"
        //This is the entry point for almost every program written in C#.
        //It must have this exact signature (name and keywords as this order) and structure, or otherwise the program will not even compile!
        static void Main(string[] args)
        {
            //Method invocation.
            //This is a built-in method from the .NET that prints out content to the screen.
            //Here, we are calling a method named "WriteLine" that is contained in a class named "Console".
            Console.WriteLine("Hello World!");

            //Variable declaration
            //Here we are declaring a variable named 'n' of type 'int' (which can hold integer numers including negative and nonegative numbers).
            int m;
            //Multiple variables of the same type can also be declared in a single line like this:
            int n, o;

            //To assign a value to a variable, you can use the assignment operator =.
            //This is iften called an assignment expression.
            m = 10;
            n = 20;
            o = 30;
            //The right side of the = operator must always contain an expression
            //or a literal of type compatible with the variable's own type.
            //Literals are raw values written directly on code and its format determines its type. Examples:
            //10 is an int literal
            //10.0f is a float literal
            //10.0m is a decimal literal
            //"10" is a string lliteral

            //The right side of an assignment can be a literal, variable or expression:
            m = 10 + 1;
            n = m + 20;
            o = (m + n) * 30;
            //The expression is almost always resolved before the assignment takes place.

            //An assignment can also be done in the same statement as the variable declaration:
            int p = 10;
            int q = 20, r = 30;

            //Let's try it with the Console.ReadLine() method:
            //This method waits until the user types something and then press "Enter".
            string a = Console.ReadLine();

            //Strings don't support arithmetic operations because they are just text, not numbers.
            //However, they can be converted to numbers using the handy int.Parse() method!
            int x = int.Parse(a);

            //If string 's' is a number, this will be converted and assigned to 'x'!
            //But be careful: if 'a' doesn't contain any text that can be converted to a number, the program will chash!


            //let's assign to 'x' its own value plus 10:
            x = x + 10; //This expression is often shortcut as x += 10;

            //Now let's print it out!
            Console.WriteLine(x);

            //Wait until the user presses some key.
            Console.WriteLine("Press some key to continue...");
            Console.ReadKey();
        }
    }
}
