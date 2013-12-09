﻿using System;
using ImagePixelEnumerator.Helpers;
using ImagePixelEnumerator.PathProviders;
using ImagePixelEnumerator.Quantizers;

namespace ImagePixelEnumerator.Ditherers
{
    public interface IColorDitherer : IPathProvider
    {
        /// <summary>
        /// Gets a value indicating whether this ditherer uses only actually process pixel.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this ditherer is inplace; otherwise, <c>false</c>.
        /// </value>
        Boolean IsInplace { get; }

        /// <summary>
        /// Prepares this instance.
        /// </summary>
        void Prepare(IColorQuantizer quantizer, Int32 colorCount, ImageBuffer sourceBuffer, ImageBuffer targetBuffer);

        /// <summary>
        /// Processes the specified buffer.
        /// </summary>
        Boolean ProcessPixel(Int32 passIndex, Pixel sourcePixel, Pixel targetPixel);

        /// <summary>
        /// Finishes this instance.
        /// </summary>
        void Finish();
    }
}
