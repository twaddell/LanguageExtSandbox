using System;
using LanguageExt;

namespace LanguageExtSandbox
{
    public sealed class Failure : Record<Failure>
    {
        public readonly string Message;

        public Failure(string message)
        {
            Message = message;
        }
    }
}
