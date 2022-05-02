using System.Runtime.Serialization;
using CoreWCF;

namespace corewcf_repro_1.ServiceB
{
    [ServiceContract(Namespace = "http://my.company/ServiceB")]
    public interface IServiceB
    {
        [OperationContract]
        string Echo(string text);
    }
}
