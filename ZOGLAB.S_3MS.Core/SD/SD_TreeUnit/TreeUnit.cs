using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Abp.Collections.Extensions;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Extensions;

namespace ZOGLAB.S_3MS.SD
{
    /// <summary>
    /// Represents an organization unit (OU).
    /// </summary>
    public class TreeUnit : FullAuditedEntity<long>, IMayHaveTenant, ITreeUnit
    {
        /// <summary>
        /// Maximum length of the <see cref="DisplayName"/> property.
        /// </summary>
        public const int MaxDisplayNameLength = 128;

        /// <summary>
        /// Maximum depth of an UO hierarchy.
        /// </summary>
        public const int MaxDepth = 16;

        /// <summary>
        /// Length of a code unit between dots.
        /// </summary>
        public const int CodeUnitLength = 5;

        /// <summary>
        /// Maximum length of the <see cref="Code"/> property.
        /// </summary>
        public const int MaxCodeLength = MaxDepth * (CodeUnitLength + 1) - 1;

        /// <summary>
        /// TenantId of this entity.
        /// </summary>
        public virtual int? TenantId { get; set; }

        /// <summary>
        /// Parent <see cref="TreeUnit"/>.
        /// Null, if this OU is root.
        /// </summary>
        [ForeignKey("ParentId")]
        public virtual TreeUnit Parent { get; set; }

        /// <summary>
        /// Parent <see cref="TreeUnit"/> Id.
        /// Null, if this OU is root.
        /// </summary>
        public virtual long? ParentId { get; set; }

        /// <summary>
        /// Hierarchical Code of this organization unit.
        /// Example: "00001.00042.00005".
        /// This is a unique code for a Tenant.
        /// It's changeable if OU hierarch is changed.
        /// </summary>
        [Required]
        [StringLength(MaxCodeLength)]
        public virtual string Code { get; set; }

        /// <summary>
        /// Display name of this role.
        /// </summary>
        [Required]
        [StringLength(MaxDisplayNameLength)]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Children of this OU.
        /// </summary>
        public virtual ICollection<TreeUnit> Children { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeUnit"/> class.
        /// </summary>
        public TreeUnit()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreeUnit"/> class.
        /// </summary>
        /// <param name="tenantId">Tenant's Id or null for host.</param>
        /// <param name="displayName">Display name.</param>
        /// <param name="parentId">Parent's Id or null if OU is a root.</param>
        public TreeUnit(int? tenantId, string displayName, long? parentId = null)
        {
            TenantId = tenantId;
            DisplayName = displayName;
            ParentId = parentId;
        }

    }
}