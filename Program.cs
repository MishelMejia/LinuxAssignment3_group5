using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string json = File.ReadAllText("commands.json");
        List<Command> commands = JsonSerializer.Deserialize<List<Command>>(json);

        foreach (var cmd in commands)
        {
            cmd.Print();
        }
    }
}