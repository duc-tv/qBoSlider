﻿using FluentValidation;
using Nop.Plugin.Widgets.qBoSlider.Models.Admin.Slides;
using Nop.Services.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Plugin.Widgets.qBoSlider.Validators
{
    /// <summary>
    /// Represents slide model validator
    /// </summary>
    public class SlideModelValidator : BaseNopValidator<SlideModel>
    {
        public SlideModelValidator(ILocalizationService localizationService)
        {
            RuleFor(x => x.PictureId).NotEqual(0).WithMessage(localizationService.GetResource("Nop.Plugin.Baroque.Widgets.qBoSlider.Admin.Slide.PictureId.IsRequired"));
            RuleFor(x => x.EndDateUtc).Must((model, endDate) =>
            {
                if (endDate.HasValue && model.StartDateUtc.HasValue && model.StartDateUtc.Value > endDate.Value)
                    return false;

                return true;
            }).WithMessage(localizationService.GetResource("Nop.Plugin.Baroque.Widgets.qBoSlider.Admin.Slide.EndDateMustBeLaterThanStartDate"));
        }
    }
}
