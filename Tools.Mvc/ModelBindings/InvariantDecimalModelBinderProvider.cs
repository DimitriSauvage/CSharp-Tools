﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Tools.Mvc.ModelBindings.Binders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Mvc.ModelBindings
{
    public class InvariantDecimalModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            if (!context.Metadata.IsComplexType && (context.Metadata.ModelType == typeof(decimal) || context.Metadata.ModelType == typeof(decimal?)))
            {
                return new InvariantDecimalModelBinder(context.Metadata.ModelType);
            }

            return null;
        }
    }
}