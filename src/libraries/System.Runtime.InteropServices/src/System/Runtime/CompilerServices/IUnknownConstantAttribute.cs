// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter, Inherited = false)]
    public sealed partial class IUnknownConstantAttribute : CustomConstantAttribute
    {
        public IUnknownConstantAttribute() { }

        public override object Value => new UnknownWrapper(null);
    }
}
