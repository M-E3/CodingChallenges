namespace MarsRover
{
    public class Rover
    {

        public enum Direction
        {
            N,
            S,
            E,
            W

        }

        int x;
        int y;
        public int X { get; set; }
        public int Y { get; set; }
       
        char[,] map;


        private Direction direction;
        public Rover(int y, int x, Direction direction, char[,] map)
        {
            X = x;
            Y = y;
            this.direction = direction;
            this.map = map;
            map[Y, X] = 'R';        //Rovers starting position

        }

        public void CommandList(string commands)
        {
            foreach (char command in commands)
            {
                switch (command)
                {

                    case 'M':                       
                            MoveFoward();                       
                        break;
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;


                }
            }
        }

        private int metersDriven;

        public void MoveFoward()
        {

            int newX = X; int newY = Y;
                switch (direction)
                {
                    case Direction.N:
                         newY--;
                        break;
                    case Direction.W:
                         newX--;
                        break;
                    case Direction.S:
                        newY++;
                        break;
                    case Direction.E:
                         newX++;
                        break;
                    default:
                        break;
                }
            if(IsClearOfObstruction(newX, newY))
            {
                map[Y, X] = '*';

                X = newX;
                Y = newY;

               map[Y, X] = 'R';
                Console.WriteLine("Rover moves foward");
                metersDriven++;
            }
            else
            {
                Console.WriteLine("There is an obstruction in the way");
            }
            }
            
                                                         
        
        

        public void TurnLeft()
        {

            switch (direction)
            {
                case Direction.N:
                    this.direction = Direction.W;
                    break;
                case Direction.W:
                    this.direction = Direction.S;
                    break;
                case Direction.S:
                    this.direction = Direction.E;
                    break;
                case Direction.E:
                    this.direction = Direction.N;
                    break;
                default:
                    break;

            }
        }
        public void TurnRight()
        {
            switch (direction)
            {
                case Direction.N:
                    this.direction = Direction.E;
                    break;
                case Direction.E:
                    this.direction = Direction.S;
                    break;
                case Direction.S:
                    this.direction = Direction.W;
                    break;
                case Direction.W:
                    this.direction = Direction.N;
                    break;
                default
                    :
                    break;
            }
        }

        


    public void MapTerrain()
        {
            for (int i = 0; i < map.GetLength(0) ; i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }

        }
     
        public bool IsClearOfObstruction(int x, int y)
        {
            if (x < 0 || x > map.GetLength(0)-1|| y < 0 || y > map.GetLength(1)-1)
            {
                return false;
            }
            else
            {
                
                return map[y,x]=='*';   
            }
        }
       
        public void DisplayDiagnostics()
        {

            Console.WriteLine($"Rover  has driven {metersDriven} meters. Rover  is at coordinants X: {X}, Y: {Y}, Facing: {direction} ");

           
        }


        
        public override string ToString()
        {
            return $"Rover  is at coordinants X: {X}, Y: {Y}, Facing: {direction}";
        }
    }
}