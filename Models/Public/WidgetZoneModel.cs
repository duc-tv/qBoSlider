﻿using System.Collections.Generic;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.Widgets.qBoSlider.Models.Public
{
    /// <summary>
    /// Represents slider parameters and widgets for current widget zone
    /// </summary>
    public class WidgetZoneModel : BaseNopEntityModel
    {
        public int ArrowNavigation { get; set; }

        public int BulletNavigation { get; set; }

        public int AutoPlayInterval { get; set; }

        public int SlideDuration { get; set; }

        public int MinDragOffsetToSlide { get; set; }

        public int SlideSpacing { get; set; }

        public bool AutoPlay { get; set; }

        public IList<SlideModel> Slides { get; set; } = new List<SlideModel>();

        #region Nested classes

        /// <summary>
        /// Represents slide model
        /// </summary>
        public class SlideModel : BaseNopEntityModel
        {
            public string PictureUrl { get; set; }

            public string Hyperlink { get; set; }

            public string Description { get; set; }
        }

        #endregion
    }
}