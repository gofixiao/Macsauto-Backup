using System;

namespace Macsauto.Infrastructure.Crosscutting.AuthorizationRequired
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AuthorizationRequiredAttribute : Attribute
    {
    }
}