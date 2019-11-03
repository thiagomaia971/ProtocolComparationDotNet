using System.Threading.Tasks;
using System.Xml.Linq;
using ProtocolComparationDotNet.Domain.InputModel;

namespace ProtocolComparationDotNet.Domain
{
    public interface ISampleService
    {
        string Ping(string s);
        ComplexModelResponse PingComplexModel(ComplexInputModel inputModel);
        void VoidMethod(out string s);
        Task<int> AsyncMethod();
        int? NullableMethod(bool? arg);
        void XmlMethod(XElement xml);
    }
}