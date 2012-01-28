﻿namespace Cassette.Stylesheets
{
    class StylesheetBundleManifest : BundleManifest
    {
        public string Media { get; set; }

        protected override Bundle CreateBundleCore()
        {
            return new StylesheetBundle(Path)
            {
                Media = Media
            };
        }
    }
}