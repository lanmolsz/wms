﻿using System;


namespace Dddml.Wms.Specialization
{
    public interface IApplicationContext
    {
        object this[string name] { get; }

        ITypeConverter TypeConverter { get; }

        ITimestampService TimestampService { get; }
    }
}
