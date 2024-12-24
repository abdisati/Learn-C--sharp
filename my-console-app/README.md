# My Console App

This is a simple C# console application that displays "Hello World" in the console.

## Instructions

### Setting Up Your Environment
Make sure you have the .NET SDK installed on your machine. You can download it from the official .NET website.

### Creating the Project
You can create a new console application using the command line:
- Open your terminal or command prompt.
- Navigate to the directory where you want to create your project.
- Run the command: `dotnet new console -n my-console-app`.

### Building the Project
To build your project, navigate to the project directory and run:
- `dotnet build`.

### Running the Application
After building, you can run your application with:
- `dotnet run`.

### Understanding the Code
In `Program.cs`, you will see something like this:

```csharp
using System;

namespace my_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
```
- The `using System;` directive allows you to use classes from the System namespace, including `Console`.
- The `Main` method is where the program starts executing.

### Editing the Code
You can modify the message inside `Console.WriteLine` to display different text.

### Learning Resources
Consider looking at online tutorials or documentation to learn more about C# and .NET development.