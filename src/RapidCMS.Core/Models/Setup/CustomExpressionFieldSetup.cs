﻿using System;
using RapidCMS.Core.Abstractions.Metadata;
using RapidCMS.Core.Models.Config;

namespace RapidCMS.Core.Models.Setup
{
    internal class CustomExpressionFieldSetup : ExpressionFieldSetup
    {
        internal CustomExpressionFieldSetup(FieldConfig field, IExpressionMetadata expression, Type customFieldType) : base(field, expression)
        {
            CustomType = customFieldType ?? throw new ArgumentNullException(nameof(customFieldType));
        }

        internal Type CustomType { get; set; }
    }
}
