<<<<<<< Updated upstream
using system.io;

public class helloworld{
  
}
=======
using system.io;

class HelloWorld
{
    static void Main()
    {
        string path = "hello.txt";
        string content = "Hello, World!";
        
        // Write to the file
        File.WriteAllText(path, content);
        
        // Read from the file
        string readContent = File.ReadAllText(path);
        
        // Print the content to the console
        System.Console.WriteLine(readContent);
    }
}
>>>>>>> Stashed changes
