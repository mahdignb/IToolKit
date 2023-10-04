using IToolKit.API.Attributes;
using IToolKit.API.Interfaces;
using IToolKit.Pages.Tools.EncodersDecoders;

namespace IToolKit.Pages.Tools.Converts.NumberBase
{
    [Order(1)]
    [Parent(ConvertsGroupToolProvider.InternalName)]
    internal sealed class NumberBaseToolProvider : IToolProvider
    {
        public string Header => "NumberBase";

        public string MenuDisplayName => "NumberBase";

        public string Description => throw new NotImplementedException();

        public string Route => "NumberBase";

        public Type Component => typeof(NumberBase);
    }
}
