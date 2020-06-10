/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable IDE0005 // Using directive is unnecessary; are required depending on code-gen options
#pragma warning disable CA2227 // Collection properties should be read only; ignored, as acceptable for a DTO.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Beef.RefData;
using Newtonsoft.Json;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Entities
{
    /// <summary>
    /// Represents the Eye Color entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EyeColor : ReferenceDataBaseGuid
    {
        #region Operator

        /// <summary>
        /// An implicit cast from an <b>Id</b> to a <see cref="EyeColor"/>.
        /// </summary>
        /// <param name="id">The <b>Id</b>.</param>
        /// <returns>The corresponding <see cref="EyeColor"/>.</returns>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "Improves useability")]
        public static implicit operator EyeColor(Guid id)
        {
            return ConvertFromId<EyeColor>(id);
        }

        /// <summary>
        /// An implicit cast from a <b>Code</b> to a <see cref="EyeColor"/>.
        /// </summary>
        /// <param name="code">The <b>Code</b>.</param>
        /// <returns>The corresponding <see cref="EyeColor"/>.</returns>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "Improves useability")]
        public static implicit operator EyeColor(string? code)
        {
            return ConvertFromCode<EyeColor>(code);
        }

        #endregion

        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="EyeColor"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="EyeColor"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<EyeColor>(from);
            CopyFrom(fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="EyeColor"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="EyeColor"/> to copy from.</param>
        public void CopyFrom(EyeColor from)
        {
             if (from == null)
                 throw new ArgumentNullException(nameof(from));

            CopyFrom((ReferenceDataBaseGuid)from);

            OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="EyeColor"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="EyeColor"/>.</returns>
        public override object Clone()
        {
            var clone = new EyeColor();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="EyeColor"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();

            OnAfterCleanUp();
        }
    
        /// <summary>
        /// Indicates whether considered initial; i.e. all properties have their initial value.
        /// </summary>
        /// <returns><c>true</c> indicates is initial; otherwise, <c>false</c>.</returns>
        public override bool IsInitial
        {
            get
            {
                if (!base.IsInitial)
                    return false;

                return true;
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(EyeColor from);

        #endregion
    } 

    /// <summary>
    /// Represents a <see cref="EyeColor"/> collection.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Tightly coupled; OK.")]
    public partial class EyeColorCollection : ReferenceDataCollectionBase<EyeColor>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EyeColorCollection"/> class.
        /// </summary>
        public EyeColorCollection(){ }

        /// <summary>
        /// Initializes a new instance of the <see cref="EyeColorCollection"/> class with an entity range.
        /// </summary>
        /// <param name="entities">The <see cref="EyeColor"/> entities.</param>
        public EyeColorCollection(IEnumerable<EyeColor> entities) => AddRange(entities);

        #endregion
    }
}

#pragma warning restore CA2227
#pragma warning restore IDE0005
#nullable restore