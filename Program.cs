using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
     
  
        string json = File.ReadAllText("commands.json");      // READ THE JSON FILE

            List<Command> commands = JsonSerializer.Deserialize<List<Command>>(json);   // CONVERT JSON TO OBJECTS

        foreach (var cmd in commands)    // PRINT COMMANDS ON SCREEN
        {
            cmd.Print();
        }
    }
}
