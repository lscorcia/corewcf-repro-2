using CoreWCF;

namespace corewcf_repro_1.ServiceA
{
    public class ServiceA : IServiceA
    {
        public string Echo(string text)
        {
            System.Console.WriteLine($"Received {text} from client!");
            return text;
        }
    }
}
