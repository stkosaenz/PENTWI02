﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Semantic_Bootstrap_2.Startup))]
namespace Semantic_Bootstrap_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
