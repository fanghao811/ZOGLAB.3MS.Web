using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace ZOGLAB.S_3MS.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}