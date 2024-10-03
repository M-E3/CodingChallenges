using VowelsConsonants;

namespace VowlesConsonantsTest
{
    public class UnitTest1
    {
        [Fact]
        public void CountInstancesTest()
        {
            VowlesConsonants vowlesConsonants = new VowlesConsonants();

            vowlesConsonants.CountInstances("Hello World");

            
        }
    }
}