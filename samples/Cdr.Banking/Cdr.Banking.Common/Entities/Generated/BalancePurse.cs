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
using RefDataNamespace = Cdr.Banking.Common.Entities;

namespace Cdr.Banking.Common.Entities
{
    /// <summary>
    /// Represents the Balance Purse entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class BalancePurse : EntityBase, IEquatable<BalancePurse>
    {
        #region Privates

        private decimal _amount;
        private string? _currency;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Amount.
        /// </summary>
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Amount")]
        public decimal Amount
        {
            get => _amount;
            set => SetValue(ref _amount, value, false, false, nameof(Amount)); 
        }

        /// <summary>
        /// Gets or sets the Currency.
        /// </summary>
        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Currency")]
        public string? Currency
        {
            get => _currency;
            set => SetValue(ref _currency, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(Currency)); 
        }

        #endregion

        #region IEquatable

        /// <summary>
        /// Determines whether the specified object is equal to the current object by comparing the values of all the properties.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public override bool Equals(object? obj)
        {
            if (!(obj is BalancePurse val))
                return false;

            return Equals(val);
        }

        /// <summary>
        /// Determines whether the specified <see cref="BalancePurse"/> is equal to the current <see cref="BalancePurse"/> by comparing the values of all the properties.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public bool Equals(BalancePurse? obj)
        {
            if (((object)obj!) == ((object)this))
                return true;
            else if (((object)obj!) == null)
                return false;

            return base.Equals((object)obj)
                && Equals(Amount, obj.Amount)
                && Equals(Currency, obj.Currency);
        }

        /// <summary>
        /// Compares two <see cref="BalancePurse"/> types for equality.
        /// </summary>
        /// <param name="a"><see cref="BalancePurse"/> A.</param>
        /// <param name="b"><see cref="BalancePurse"/> B.</param>
        /// <returns><c>true</c> indicates equal; otherwise, <c>false</c> for not equal.</returns>
        public static bool operator == (BalancePurse? a, BalancePurse? b) => Equals(a, b);

        /// <summary>
        /// Compares two <see cref="BalancePurse"/> types for non-equality.
        /// </summary>
        /// <param name="a"><see cref="BalancePurse"/> A.</param>
        /// <param name="b"><see cref="BalancePurse"/> B.</param>
        /// <returns><c>true</c> indicates not equal; otherwise, <c>false</c> for equal.</returns>
        public static bool operator != (BalancePurse? a, BalancePurse? b) => !Equals(a, b);

        /// <summary>
        /// Returns a hash code for the <see cref="BalancePurse"/>.
        /// </summary>
        /// <returns>A hash code for the <see cref="BalancePurse"/>.</returns>
        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(Amount);
            hash.Add(Currency);
            return base.GetHashCode() ^ hash.ToHashCode();
        }
    
        #endregion
        
        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="BalancePurse"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="BalancePurse"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<BalancePurse>(from);
            CopyFrom(fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="BalancePurse"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="BalancePurse"/> to copy from.</param>
        public void CopyFrom(BalancePurse from)
        {
             if (from == null)
                 throw new ArgumentNullException(nameof(from));

            CopyFrom((EntityBase)from);
            Amount = from.Amount;
            Currency = from.Currency;

            OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="BalancePurse"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="BalancePurse"/>.</returns>
        public override object Clone()
        {
            var clone = new BalancePurse();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="BalancePurse"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();
            Amount = Cleaner.Clean(Amount);
            Currency = Cleaner.Clean(Currency, StringTrim.UseDefault, StringTransform.UseDefault);

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
                return Cleaner.IsInitial(Amount)
                    && Cleaner.IsInitial(Currency);
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(BalancePurse from);

        #endregion
    } 

    /// <summary>
    /// Represents a <see cref="BalancePurse"/> collection.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Tightly coupled; OK.")]
    public partial class BalancePurseCollection : EntityBaseCollection<BalancePurse>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BalancePurseCollection"/> class.
        /// </summary>
        public BalancePurseCollection(){ }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalancePurseCollection"/> class with an entity range.
        /// </summary>
        /// <param name="entities">The <see cref="BalancePurse"/> entities.</param>
        public BalancePurseCollection(IEnumerable<BalancePurse> entities) => AddRange(entities);

        #endregion

        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="BalancePurseCollection"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="BalancePurseCollection"/>.</returns>
        public override object Clone()
        {
            var clone = new BalancePurseCollection();
            foreach (BalancePurse item in this)
            {
                clone.Add((BalancePurse)item.Clone());
            }
                
            return clone;
        }
        
        #endregion
    }
}

#pragma warning restore CA2227
#pragma warning restore IDE0005
#nullable restore