namespace TasksCalculation
{
    using System;
    using System.Threading.Tasks;

    internal class Program
    {
        public static void Main(string[] args)
        {
            TaskAsync();
            Console.ReadKey();
        }

        private static async void TaskAsync()
        {
            Task t1 = Task.Run(() => CircleArea(1.5));
            Task t2 = Task.Run(() => CircleArea(7.2));
            Task t3 = Task.Run(() => CircleArea(4.189));

            await Task.WhenAll(new[] { t1, t2, t3 });
        }

        private static double CircleArea(double radius)
        {
            var circleArea = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Radius {radius}, circle area {circleArea}");
            return circleArea;
        }
    }
}
