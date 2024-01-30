namespace Squid.Core;

public class SquidServer
{
    public class Builder
    {
        private SquidServer server = new();
        /// <summary>
        /// New instance of a SquidServer Builder
        /// </summary>
        /// <returns>
        /// SquidServer.Builder
        /// </returns>
        public static Builder GetBuilder() => new Builder();


        /// <summary>
        /// Finalizes the Builder Setup
        /// </summary>
        /// <returns>
        /// SquidServer
        /// </returns>
        public SquidServer Finalize() => server;
    }


    /// <summary>
    /// Starts the SquidServer
    /// </summary>
    public void Start()
    {
        
    }
}