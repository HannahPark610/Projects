using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoImages
{
   class EmbeddedImages : IMarkupExtension
        {
            public string ResourceId { get; set; }
            public object ProvideValue(IServiceProvider)
            {
                if (string.IsNullOrWhiteSpace(ResourceId))
                    return null;
                return ImageSource.FromResource("DemoImages.Images.batdroid.png");
            }
        }
    }

