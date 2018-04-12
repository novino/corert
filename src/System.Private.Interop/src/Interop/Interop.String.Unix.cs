// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices
{
    public partial class ExternalInterop
    {

        public static unsafe uint SysStringLen(void* pBSTR)
        {
            throw new PlatformNotSupportedException();
        }

        public static unsafe uint SysStringLen(IntPtr pBSTR)
        {
            throw new PlatformNotSupportedException();
        }

        public static unsafe IntPtr SysAllocString(IntPtr pStrIn)
        {
            throw new PlatformNotSupportedException();
        }

        public static unsafe char* SysAllocStringLen(char* pStrIn, uint len)
        {
            string srcString = new string(pStrIn, 0, checked((int)len));
            return Marshal.StringToBSTR(srcString);
        }

        public static unsafe void SysFreeString(IntPtr pBstr)
        {
            throw new PlatformNotSupportedException();
        }
    }
}
