using MarsRover;

namespace TestMarsRover
{
    public class TestRover
    {

        [Fact]
        public void TestCommands()
        {
            //Arrange

            char[,] map = { {'*', '0', '0', '0', '*'},
                            {'*', '*', '*', '*', '*'},
                            {'*', '*', '0', '*', '*'},
                            {'*', '*', '*', '*', '*'},
                            {'*', '*', '*', '*', '*'} };

            Rover rover = new Rover(0, 0, Rover.Direction.N, map); //Top left of map (start of 2d array)

            //Act
            rover.CommandList("LLMLMM");



            //Assert
            Assert.Equal(2, rover.X);
            Assert.Equal(1, rover.Y);
            Assert.Equal(Rover.Direction.E, Rover.Direction.E);
            

        }
    }
}