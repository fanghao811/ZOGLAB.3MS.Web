﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using ZOGLAB.S_3MS.MultiTenancy.Dto;

namespace ZOGLAB.S_3MS.Web.Areas.Mpa.Models.Tenants
{
    public class EditTenantViewModel
    {
        public TenantEditDto Tenant { get; set; }

        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public EditTenantViewModel(TenantEditDto tenant, IReadOnlyList<ComboboxItemDto> editionItems)
        {
            Tenant = tenant;
            EditionItems = editionItems;
        }
    }
}