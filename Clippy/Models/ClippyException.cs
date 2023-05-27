using System;

namespace Clippy
{
    internal class ClippyException : Exception
    {
        public ClippyException(string message) : base(message) { }
    }
}
