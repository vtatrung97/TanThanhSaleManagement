﻿using System;
using Abp.AutoMapper;
using Delta.SaleProject.Sessions.Dto;

namespace Delta.SaleProject.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}