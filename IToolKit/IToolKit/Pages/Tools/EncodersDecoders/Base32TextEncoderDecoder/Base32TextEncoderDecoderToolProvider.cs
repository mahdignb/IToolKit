﻿using IToolKit.API.Interfaces;
using IToolKit.API.Tools.Attributes;

namespace IToolKit.Pages.Tools.EncodersDecoders.Base32TextEncoderDecoder
{
    [Order(2)]
    [Parent(EncodersDecodersGroupToolProvider.InternalName)]
    internal sealed class Base32TextEncoderDecoderToolProvider : IToolProvider
    {
        public string Header => "Base32 Text Encoder / Decoder";

        public string Description => throw new NotImplementedException();

        public string MenuDisplayName => "Base32";

        public string Route => "Base32";
    }
}
