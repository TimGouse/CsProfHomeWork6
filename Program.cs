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

            // Using DirectoryTraverser
            var traverser = new DirectoryTraverser();
            traverser.FileFound += (sender, e) =>
            {
                Console.WriteLine($"File found: {e.FileName}");

                 //Uncomment to test the cancellation functionality
                 //traverser.CancelTraversal();
            };
            traverser.TraverseDirectory("CsProfHomeWork6_test_files");
            Console.ReadLine();
        }
    }
}