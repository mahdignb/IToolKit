using IToolKit.API.Attributes;
using IToolKit.API.Interfaces;
using IToolKit.Pages.Tools.EncodersDecoders;
using IToolKit.Pages.Tools.EncodersDecoders.Base64TextEncoderDecoder;

namespace IToolKit.Pages.Tools.Converts
{
    [Order(1)]
    [Name(InternalName)]
    internal sealed class ConvertsGroupToolProvider : GroupToolProviderBase
    {
        internal const string InternalName = "Converts";

        public override string Header => InternalName;

        public override string Description => throw new NotImplementedException();

        public override string MenuDisplayName => InternalName;

        public override string Route => InternalName;
        public override Type Component => throw new NotImplementedException();
    }
}
