﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using DimitriSauvageTools.Http.Extensions;

namespace DimitriSauvageTools.Http.Failing
{
    public class FailingStartupFilter : IStartupFilter
    {
        private readonly Action<FailingOptions> _options;
        public FailingStartupFilter(Action<FailingOptions> optionsAction)
        {
            _options = optionsAction;
        }

        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return app =>
            {
                app.UseFailingMiddleware(_options);
                next(app);
            };
        }
    }
}
