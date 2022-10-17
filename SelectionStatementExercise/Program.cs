namespace SelectionStatementExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
			var r = new Random();
			int favNumber = r.Next(1, 200);

			bool solved = false;
			while (!solved)
			{
				Console.WriteLine("Try to guess my favorite number!");
				var userInput = int.Parse(Console.ReadLine());

				if (userInput < favNumber)
				{
					Console.WriteLine("Too low!");
				}
				else if (userInput > favNumber)
				{
					Console.WriteLine("Too high!");
				}
				else solved = true;
			}
			Console.WriteLine("Nevermind");
		}
    }
}