using System;
using Reflex.Scripts.Utilities;

namespace Reflex
{
    public class UnhandledRuntimeScriptingBackendException : Exception
    {
        internal UnhandledRuntimeScriptingBackendException(RuntimeScriptingBackend.Backend backend) : base(GenerateMessage(backend))
        {

        }

        private static string GenerateMessage(RuntimeScriptingBackend.Backend backend)
        {
            return $"{backend} scripting backend not handled.";
        }
    }
}