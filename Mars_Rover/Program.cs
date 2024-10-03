
using MarsRover;

char[,] map = { {'*', '0', '0', '0', '*' },
                {'*', '*', '*', '*', '*'},
                {'*', '*', '0', '*', '*'},
                {'*', '*', '*', '*', '*'},
                {'*', '*', '*', '*', '*'}};

Console.WriteLine("\nMARS Rover ");
Console.WriteLine($"__________________");
Console.WriteLine($"Press: W to move fowards\nPress: A to turn left\nPress: D to turn left" +
    $"\nPress:E for sytem info\nPress: C for constructing command list\nType 'exit' to close" +
    $"\n______________________\nCurrent position\n");

Rover rover = new Rover(0, 0, Rover.Direction.E, map);

 rover.MapTerrain(); //Show map
 Console.WriteLine(rover);






string input = string.Empty;

do
{
   
    input = Console.ReadLine();
    switch (input)
    {
        case "a":
            rover.TurnLeft();
            Console.WriteLine(rover);

            ; break;
        case "d":
            rover.TurnRight();
            Console.WriteLine(rover)

                ; break;

        case "w":
            rover.MoveFoward();
            Console.WriteLine(rover);
            rover.MapTerrain();
            break;
        case "e": 
            rover.DisplayDiagnostics();
            break;
        case "c":
            Console.WriteLine("'M' to move foward, 'L' to turn left and 'R' to turn right");
            string command = Console.ReadLine();
            rover.CommandList(command);
            Console.WriteLine(rover);
            rover.MapTerrain();
            break;
        default:
            rover.DisplayDiagnostics();
            break;
    }




} while (input != "exit");





Console.ReadLine();







