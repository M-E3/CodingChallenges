namespace VowelsConsonants
{
    public class VowlesConsonants
    {
        

        List<char> vowles = new List<char> {
            'a', 'e', 'i', 'o', 'u'};


        public void CountInstances(string input)
        {
            int vowelCounter = 0;
            int constCounter = 0;

                foreach (char c in input.ToLower().Replace(" ", ""))
                {

                if (char.IsLetter(c))
                {


                    if (vowles.Contains(c))
                    {

                        vowelCounter++;


                    }
                    else 
                    {
                        constCounter++;

                    }
                }
                

                }
                Console.WriteLine($"\nVowels: {vowelCounter}");

                



                Console.WriteLine($"\n Consanants:" + constCounter);
            }
        }


    }









