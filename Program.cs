namespace CsProfHomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<FloatWrapper>
        {
            new FloatWrapper(1.2f),
            new FloatWrapper(3.4f),
            new FloatWrapper(5.6f)
        };

            FloatWrapper maxNumberWrapper = numbers.GetMax(n => n.Value);

            if (maxNumberWrapper != null)
            {
                Console.WriteLine("Max number: " + maxNumberWrapper.Value);
            }
        }
    }
}