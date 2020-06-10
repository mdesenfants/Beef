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
    /// Represents the Robot entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Robot : EntityBase, IGuidIdentifier, IETag, IChangeLog, IEquatable<Robot>
    {
        #region Privates

        private Guid _id;
        private string? _modelNo;
        private string? _serialNo;
        private string? _eyeColorSid;
        private string? _eyeColorText;
        private string? _powerSourceSid;
        private string? _powerSourceText;
        private string? _eTag;
        private ChangeLog? _changeLog;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="Robot"/> identifier.
        /// </summary>
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Identifier")]
        public Guid Id
        {
            get => _id;
            set => SetValue(ref _id, value, false, false, nameof(Id)); 
        }

        /// <summary>
        /// Gets or sets the Model number.
        /// </summary>
        [JsonProperty("modelNo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Model No")]
        public string? ModelNo
        {
            get => _modelNo;
            set => SetValue(ref _modelNo, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(ModelNo)); 
        }

        /// <summary>
        /// Gets or sets the Unique serial number.
        /// </summary>
        [JsonProperty("serialNo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Serial No")]
        public string? SerialNo
        {
            get => _serialNo;
            set => SetValue(ref _serialNo, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(SerialNo)); 
        }

        /// <summary>
        /// Gets or sets the <see cref="EyeColor"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonProperty("eyeColor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Eye Color")]
        public string? EyeColorSid
        {
            get => _eyeColorSid;
            set => SetValue(ref _eyeColorSid, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(EyeColor));
        }

        /// <summary>
        /// Gets the corresponding <see cref="EyeColor"/> text (read-only where selected).
        /// </summary>
        [JsonProperty("eyeColorText", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? EyeColorText { get => _eyeColorText ?? GetRefDataText(() => EyeColor); set => _eyeColorText = value; }

        /// <summary>
        /// Gets or sets the Eye Color (see <see cref="RefDataNamespace.EyeColor"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [Display(Name="Eye Color")]
        public RefDataNamespace.EyeColor? EyeColor
        {
            get => _eyeColorSid;
            set => SetValue(ref _eyeColorSid, value, false, false, nameof(EyeColor)); 
        }

        /// <summary>
        /// Gets or sets the <see cref="PowerSource"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonProperty("powerSource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Power Source")]
        public string? PowerSourceSid
        {
            get => _powerSourceSid;
            set => SetValue(ref _powerSourceSid, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(PowerSource));
        }

        /// <summary>
        /// Gets the corresponding <see cref="PowerSource"/> text (read-only where selected).
        /// </summary>
        [JsonProperty("powerSourceText", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? PowerSourceText { get => _powerSourceText ?? GetRefDataText(() => PowerSource); set => _powerSourceText = value; }

        /// <summary>
        /// Gets or sets the Power Source (see <see cref="RefDataNamespace.PowerSource"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [Display(Name="Power Source")]
        public RefDataNamespace.PowerSource? PowerSource
        {
            get => _powerSourceSid;
            set => SetValue(ref _powerSourceSid, value, false, false, nameof(PowerSource)); 
        }

        /// <summary>
        /// Gets or sets the ETag.
        /// </summary>
        [JsonProperty("etag", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="ETag")]
        public string? ETag
        {
            get => _eTag;
            set => SetValue(ref _eTag, value, false, StringTrim.UseDefault, StringTransform.UseDefault, nameof(ETag)); 
        }

        /// <summary>
        /// Gets or sets the Change Log (see <see cref="ChangeLog"/>).
        /// </summary>
        [JsonProperty("changeLog", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Change Log")]
        public ChangeLog? ChangeLog
        {
            get => _changeLog;
            set => SetValue(ref _changeLog, value, false, true, nameof(ChangeLog)); 
        }

        #endregion

        #region IChangeTracking
          
        /// <summary>
        /// Resets the entity state to unchanged by accepting the changes (resets <see cref="EntityBase.ChangeTracking"/>).
        /// </summary>
        /// <remarks>Ends and commits the entity changes (see <see cref="EntityBase.EndEdit"/>).</remarks>
        public override void AcceptChanges()
        {
            ChangeLog?.AcceptChanges();
            base.AcceptChanges();
        }

        /// <summary>
        /// Determines that until <see cref="AcceptChanges"/> is invoked property changes are to be logged (see <see cref="EntityBase.ChangeTracking"/>).
        /// </summary>
        public override void TrackChanges()
        {
            ChangeLog?.TrackChanges();
            base.TrackChanges();
        }

        #endregion

        #region UniqueKey
      
        /// <summary>
        /// Indicates whether the <see cref="Robot"/> has a <see cref="UniqueKey"/> value.
        /// </summary>
        public override bool HasUniqueKey => true;
        
        /// <summary>
        /// Gets the list of property names that represent the unique key.
        /// </summary>
        public override string[] UniqueKeyProperties => new string[] { nameof(Id) };
        
        /// <summary>
        /// Creates the <see cref="UniqueKey"/>.
        /// </summary>
        /// <returns>The <see cref="Beef.Entities.UniqueKey"/>.</returns>
        /// <param name="id">The <see cref="Id"/>.</param>
        public static UniqueKey CreateUniqueKey(Guid id) => new UniqueKey(id);
          
        /// <summary>
        /// Gets the <see cref="UniqueKey"/>.
        /// </summary>
        /// <remarks>
        /// The <b>UniqueKey</b> key consists of the following property(s): <see cref="Id"/>.
        /// </remarks>
        public override UniqueKey UniqueKey => new UniqueKey(Id);

        #endregion

        #region IEquatable

        /// <summary>
        /// Determines whether the specified object is equal to the current object by comparing the values of all the properties.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public override bool Equals(object? obj)
        {
            if (!(obj is Robot val))
                return false;

            return Equals(val);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Robot"/> is equal to the current <see cref="Robot"/> by comparing the values of all the properties.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public bool Equals(Robot? obj)
        {
            if (((object)obj!) == ((object)this))
                return true;
            else if (((object)obj!) == null)
                return false;

            return base.Equals((object)obj)
                && Equals(Id, obj.Id)
                && Equals(ModelNo, obj.ModelNo)
                && Equals(SerialNo, obj.SerialNo)
                && Equals(EyeColorSid, obj.EyeColorSid)
                && Equals(PowerSourceSid, obj.PowerSourceSid)
                && Equals(ETag, obj.ETag)
                && Equals(ChangeLog, obj.ChangeLog);
        }

        /// <summary>
        /// Compares two <see cref="Robot"/> types for equality.
        /// </summary>
        /// <param name="a"><see cref="Robot"/> A.</param>
        /// <param name="b"><see cref="Robot"/> B.</param>
        /// <returns><c>true</c> indicates equal; otherwise, <c>false</c> for not equal.</returns>
        public static bool operator == (Robot? a, Robot? b) => Equals(a, b);

        /// <summary>
        /// Compares two <see cref="Robot"/> types for non-equality.
        /// </summary>
        /// <param name="a"><see cref="Robot"/> A.</param>
        /// <param name="b"><see cref="Robot"/> B.</param>
        /// <returns><c>true</c> indicates not equal; otherwise, <c>false</c> for equal.</returns>
        public static bool operator != (Robot? a, Robot? b) => !Equals(a, b);

        /// <summary>
        /// Returns a hash code for the <see cref="Robot"/>.
        /// </summary>
        /// <returns>A hash code for the <see cref="Robot"/>.</returns>
        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(Id);
            hash.Add(ModelNo);
            hash.Add(SerialNo);
            hash.Add(EyeColorSid);
            hash.Add(PowerSourceSid);
            hash.Add(ETag);
            hash.Add(ChangeLog);
            return base.GetHashCode() ^ hash.ToHashCode();
        }
    
        #endregion
        
        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="Robot"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="Robot"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<Robot>(from);
            CopyFrom(fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="Robot"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="Robot"/> to copy from.</param>
        public void CopyFrom(Robot from)
        {
             if (from == null)
                 throw new ArgumentNullException(nameof(from));

            CopyFrom((EntityBase)from);
            Id = from.Id;
            ModelNo = from.ModelNo;
            SerialNo = from.SerialNo;
            EyeColorSid = from.EyeColorSid;
            PowerSourceSid = from.PowerSourceSid;
            ETag = from.ETag;
            ChangeLog = CopyOrClone(from.ChangeLog, ChangeLog);

            OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="Robot"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="Robot"/>.</returns>
        public override object Clone()
        {
            var clone = new Robot();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="Robot"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();
            Id = Cleaner.Clean(Id);
            ModelNo = Cleaner.Clean(ModelNo, StringTrim.UseDefault, StringTransform.UseDefault);
            SerialNo = Cleaner.Clean(SerialNo, StringTrim.UseDefault, StringTransform.UseDefault);
            EyeColorSid = Cleaner.Clean(EyeColorSid);
            PowerSourceSid = Cleaner.Clean(PowerSourceSid);
            ETag = Cleaner.Clean(ETag, StringTrim.UseDefault, StringTransform.UseDefault);
            ChangeLog = Cleaner.Clean(ChangeLog);

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
                return Cleaner.IsInitial(Id)
                    && Cleaner.IsInitial(ModelNo)
                    && Cleaner.IsInitial(SerialNo)
                    && Cleaner.IsInitial(EyeColorSid)
                    && Cleaner.IsInitial(PowerSourceSid)
                    && Cleaner.IsInitial(ETag)
                    && Cleaner.IsInitial(ChangeLog);
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(Robot from);

        #endregion
    } 

    /// <summary>
    /// Represents a <see cref="Robot"/> collection.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Tightly coupled; OK.")]
    public partial class RobotCollection : EntityBaseCollection<Robot>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotCollection"/> class.
        /// </summary>
        public RobotCollection(){ }

        /// <summary>
        /// Initializes a new instance of the <see cref="RobotCollection"/> class with an entity range.
        /// </summary>
        /// <param name="entities">The <see cref="Robot"/> entities.</param>
        public RobotCollection(IEnumerable<Robot> entities) => AddRange(entities);

        #endregion

        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="RobotCollection"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="RobotCollection"/>.</returns>
        public override object Clone()
        {
            var clone = new RobotCollection();
            foreach (Robot item in this)
            {
                clone.Add((Robot)item.Clone());
            }
                
            return clone;
        }
        
        #endregion

        #region Operator

        /// <summary>
        /// An implicit cast from a <see cref="RobotCollectionResult"/> to a <see cref="RobotCollection"/>.
        /// </summary>
        /// <param name="result">The <see cref="RobotCollectionResult"/>.</param>
        /// <returns>The corresponding <see cref="RobotCollection"/>.</returns>
        [SuppressMessage("Usage", "CA2225:Operator overloads have named alternates", Justification = "Improves useability")]
        public static implicit operator RobotCollection(RobotCollectionResult result) => result?.Result!;

        #endregion
    }

    /// <summary>
    /// Represents a <see cref="Robot"/> collection result.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Tightly coupled; OK.")]
    public class RobotCollectionResult : EntityCollectionResult<RobotCollection, Robot>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotCollectionResult"/> class.
        /// </summary>
        public RobotCollectionResult() { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotCollectionResult"/> class with default <see cref="PagingArgs"/>.
        /// </summary>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public RobotCollectionResult(PagingArgs? paging) : base(paging) { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotCollectionResult"/> class with a <paramref name="collection"/> of items to add.
        /// </summary>
        /// <param name="collection">A collection containing items to add.</param>
        /// <param name="paging">The <see cref="PagingArgs"/>.</param>
        public RobotCollectionResult(IEnumerable<Robot> collection, PagingArgs? paging = null) : base(paging) => Result.AddRange(collection);
        
        /// <summary>
        /// Creates a deep copy of the <see cref="RobotCollectionResult"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="RobotCollectionResult"/>.</returns>
        public override object Clone()
        {
            var clone = new RobotCollectionResult();
            clone.CopyFrom(this);
            return clone;
        }
    }
}

#pragma warning restore CA2227
#pragma warning restore IDE0005
#nullable restore