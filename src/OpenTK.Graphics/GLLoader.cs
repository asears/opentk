using System;

namespace OpenTK.Graphics
{
    public unsafe static class GLLoader
    {
        private static IBindingsContext? _bindingsContext;

        internal static IBindingsContext BindingsContext => _bindingsContext ??
                throw new Exception("Bindings not loaded, load with GLLoader.LoadBindings");

        public static void LoadBindings(IBindingsContext c) => _bindingsContext = c;
    }
}
