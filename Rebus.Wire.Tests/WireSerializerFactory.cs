using Rebus.Serialization;
using Rebus.Tests.Contracts.Serialization;

namespace Rebus.Wire.Tests
{
    public class WireSerializerFactory : ISerializerFactory
    {
        public ISerializer GetSerializer()
        {
            return new WireSerializer();
        }
    }
}