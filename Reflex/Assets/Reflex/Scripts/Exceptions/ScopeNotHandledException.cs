using System;

namespace Reflex
{
    public class ScopeNotHandledException : Exception
    {
        internal ScopeNotHandledException(BindingScope scope) : base(GenerateMessage(scope))
        {
        }

        private static string GenerateMessage(BindingScope scope)
        {
            return $"BindingScope '{scope}' not handled.";
        }
    }
}