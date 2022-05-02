using System.Runtime.Serialization;
using CoreWCF;

namespace corewcf_repro_1.ServiceA
{
    [ServiceContract(Namespace="http://my.company/ServiceA")]
    public interface IServiceA
    {
        [OperationContract]
        string Echo(string text);
    }
}
