using Rebus.Serialization;
using Rebus.Wire;

namespace Rebus.Config
{
    /// <summary>
    /// Configuration extensions for the Wire serializer
    /// </summary>
    public static class WireSerializerConfigurationExtensions
    {
        /// <summary>
        /// Configures Rebus to use the super-spiffy Wire serializer to serialize messages
        /// </summary>
        public static void UseWire(this StandardConfigurer<ISerializer> configurer)
        {
            configurer.Register(c => new WireSerializer(), 
                "Registered WireSerializer as the primary implementation of ISerializer");
        }
    }
}