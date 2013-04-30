// Guids.cs
// MUST match guids.h
using System;

namespace 神棍工作室.NanQi_IDE
{
    static class GuidList
    {
        public const string guidNanQi_IDEPkgString = "cd2b02eb-220f-40df-b7b2-b5f28c4ce332";
        public const string guidNanQi_IDECmdSetString = "19dd1f59-76ce-4646-9677-e787d3d856f4";

        public static readonly Guid guidNanQi_IDECmdSet = new Guid(guidNanQi_IDECmdSetString);
    };
}