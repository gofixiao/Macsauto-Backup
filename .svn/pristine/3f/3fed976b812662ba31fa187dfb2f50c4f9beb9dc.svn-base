namespace Macsauto.Infrastructure.Helper.Extension
{
    using System;
    using System.Linq;
    using System.Reflection;

    public static class MethodExtension
	{
		public static bool IsDecoratedBy (this MethodInfo method, Type interceptor)
		{
		    var attributes = method.GetCustomAttributes (false);

		    return attributes.Any(attribute => attribute.GetType() == interceptor);
		}
	}
}