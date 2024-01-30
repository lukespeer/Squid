using Squid.Core;

SquidServer squidServer = SquidServer.Builder.GetBuilder()
    .Finalize();

squidServer.Start();