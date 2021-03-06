﻿using Microsoft.Owin;

[assembly: OwinStartup(typeof(TestConcurrentAJAX.SignalR.Startup))]

namespace TestConcurrentAJAX.SignalR
{
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}
