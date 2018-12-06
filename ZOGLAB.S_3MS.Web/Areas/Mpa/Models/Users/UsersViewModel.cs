﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Users
{
    public class UsersViewModel
    {
        public string FilterText { get; set; }

        public List<ComboboxItemDto> Permissions { get; set; }

        public List<ComboboxItemDto> Roles { get; set; }
    }
}