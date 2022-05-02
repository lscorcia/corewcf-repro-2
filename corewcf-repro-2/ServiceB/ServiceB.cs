namespace corewcf_repro_1.ServiceB
{
    public class ServiceB : IServiceB
    {
        public string Echo(string text)
        {
            System.Console.WriteLine($"Received {text} from client!");
            return text;
        }
    }
}
