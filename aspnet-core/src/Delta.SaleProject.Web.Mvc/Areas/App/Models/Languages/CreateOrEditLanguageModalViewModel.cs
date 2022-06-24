﻿using Abp.AutoMapper;
using Delta.SaleProject.Localization.Dto;

namespace Delta.SaleProject.Web.Areas.App.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}