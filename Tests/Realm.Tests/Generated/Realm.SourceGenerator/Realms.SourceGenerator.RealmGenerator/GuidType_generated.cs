﻿// <auto-generated />
using Realms;
using Realms.Schema;
using Realms.Tests.Database;
using Realms.Tests.Database.Generated;
using Realms.Weaving;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Realms.Tests.Database
{
    [Generated]
    [Woven(typeof(GuidTypeObjectHelper))]
    public partial class GuidType : IRealmObject, INotifyPropertyChanged, IReflectableType
    {
        public static ObjectSchema RealmSchema = new ObjectSchema.Builder("GuidType", ObjectSchema.ObjectType.RealmObject)
        {
            Property.Primitive("_id", RealmValueType.Guid, isPrimaryKey: true, isIndexed: false, isNullable: false, managedName: "Id"),
            Property.Primitive("RegularProperty", RealmValueType.Guid, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "RegularProperty"),
            Property.PrimitiveList("GuidList", RealmValueType.Guid, areElementsNullable: false, managedName: "GuidList"),
            Property.PrimitiveSet("GuidSet", RealmValueType.Guid, areElementsNullable: false, managedName: "GuidSet"),
            Property.PrimitiveDictionary("GuidDict", RealmValueType.Guid, areElementsNullable: false, managedName: "GuidDict"),
            Property.Primitive("OptionalProperty", RealmValueType.Guid, isPrimaryKey: false, isIndexed: false, isNullable: true, managedName: "OptionalProperty"),
            Property.PrimitiveList("OptionalList", RealmValueType.Guid, areElementsNullable: true, managedName: "OptionalList"),
            Property.PrimitiveSet("OptionalSet", RealmValueType.Guid, areElementsNullable: true, managedName: "OptionalSet"),
            Property.PrimitiveDictionary("OptionalDict", RealmValueType.Guid, areElementsNullable: true, managedName: "OptionalDict"),
            Property.Object("LinkProperty", "GuidType", managedName: "LinkProperty"),
            Property.RealmValue("MixedProperty", managedName: "MixedProperty"),
            Property.RealmValueList("MixedList", managedName: "MixedList"),
            Property.RealmValueSet("MixedSet", managedName: "MixedSet"),
            Property.RealmValueDictionary("MixedDict", managedName: "MixedDict"),
            Property.Object("EmbeddedProperty", "EmbeddedGuidType", managedName: "EmbeddedProperty"),
        }.Build();

        #region IRealmObject implementation

        private IGuidTypeAccessor _accessor;

        IRealmAccessor IRealmObjectBase.Accessor => Accessor;

        internal IGuidTypeAccessor Accessor => _accessor ?? (_accessor = new GuidTypeUnmanagedAccessor(typeof(GuidType)));

        [IgnoreDataMember, XmlIgnore]
        public bool IsManaged => Accessor.IsManaged;

        [IgnoreDataMember, XmlIgnore]
        public bool IsValid => Accessor.IsValid;

        [IgnoreDataMember, XmlIgnore]
        public bool IsFrozen => Accessor.IsFrozen;

        [IgnoreDataMember, XmlIgnore]
        public Realm Realm => Accessor.Realm;

        [IgnoreDataMember, XmlIgnore]
        public ObjectSchema ObjectSchema => Accessor.ObjectSchema;

        [IgnoreDataMember, XmlIgnore]
        public DynamicObjectApi DynamicApi => Accessor.DynamicApi;

        [IgnoreDataMember, XmlIgnore]
        public int BacklinksCount => Accessor.BacklinksCount;

        public void SetManagedAccessor(IRealmAccessor managedAccessor, IRealmObjectHelper helper = null, bool update = false, bool skipDefaults = false)
        {
            var newAccessor = (IGuidTypeAccessor)managedAccessor;
            var oldAccessor = (IGuidTypeAccessor)_accessor;
            _accessor = newAccessor;

            if (helper != null)
            {
                if (!skipDefaults)
                {
                    newAccessor.GuidList.Clear();
                    newAccessor.GuidSet.Clear();
                    newAccessor.GuidDict.Clear();
                    newAccessor.OptionalList.Clear();
                    newAccessor.OptionalSet.Clear();
                    newAccessor.OptionalDict.Clear();
                    newAccessor.MixedList.Clear();
                    newAccessor.MixedSet.Clear();
                    newAccessor.MixedDict.Clear();
                }

                newAccessor.Id = oldAccessor.Id;
                newAccessor.RegularProperty = oldAccessor.RegularProperty;
                Realms.CollectionExtensions.PopulateCollection(oldAccessor.GuidList, newAccessor.GuidList, update, skipDefaults);
                Realms.CollectionExtensions.PopulateCollection(oldAccessor.GuidSet, newAccessor.GuidSet, update, skipDefaults);
                Realms.CollectionExtensions.PopulateCollection(oldAccessor.GuidDict, newAccessor.GuidDict, update, skipDefaults);
                newAccessor.OptionalProperty = oldAccessor.OptionalProperty;
                Realms.CollectionExtensions.PopulateCollection(oldAccessor.OptionalList, newAccessor.OptionalList, update, skipDefaults);
                Realms.CollectionExtensions.PopulateCollection(oldAccessor.OptionalSet, newAccessor.OptionalSet, update, skipDefaults);
                Realms.CollectionExtensions.PopulateCollection(oldAccessor.OptionalDict, newAccessor.OptionalDict, update, skipDefaults);
                if(oldAccessor.LinkProperty != null)
                {
                    newAccessor.Realm.Add(oldAccessor.LinkProperty, update);
                }
                newAccessor.LinkProperty = oldAccessor.LinkProperty;
                newAccessor.MixedProperty = oldAccessor.MixedProperty;
                Realms.CollectionExtensions.PopulateCollection(oldAccessor.MixedList, newAccessor.MixedList, update, skipDefaults);
                Realms.CollectionExtensions.PopulateCollection(oldAccessor.MixedSet, newAccessor.MixedSet, update, skipDefaults);
                Realms.CollectionExtensions.PopulateCollection(oldAccessor.MixedDict, newAccessor.MixedDict, update, skipDefaults);
                newAccessor.EmbeddedProperty = oldAccessor.EmbeddedProperty;
            }

            if (_propertyChanged != null)
            {
                SubscribeForNotifications();
            }

            OnManaged();
        }

        #endregion

        /// <summary>
        /// Called when the object has been managed by a Realm.
        /// </summary>
        /// <remarks>
        /// This method will be called either when a managed object is materialized or when an unmanaged object has been
        /// added to the Realm. It can be useful for providing some initialization logic as when the constructor is invoked,
        /// it is not yet clear whether the object is managed or not.
        /// </remarks>
        partial void OnManaged();

        private event PropertyChangedEventHandler _propertyChanged;

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                if (_propertyChanged == null)
                {
                    SubscribeForNotifications();
                }

                _propertyChanged += value;
            }

            remove
            {
                _propertyChanged -= value;

                if (_propertyChanged == null)
                {
                    UnsubscribeFromNotifications();
                }
            }
        }

        /// <summary>
        /// Called when a property has changed on this class.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <remarks>
        /// For this method to be called, you need to have first subscribed to <see cref="PropertyChanged"/>.
        /// This can be used to react to changes to the current object, e.g. raising <see cref="PropertyChanged"/> for computed properties.
        /// </remarks>
        /// <example>
        /// <code>
        /// class MyClass : IRealmObject
        /// {
        ///     public int StatusCodeRaw { get; set; }
        ///     public StatusCodeEnum StatusCode => (StatusCodeEnum)StatusCodeRaw;
        ///     partial void OnPropertyChanged(string propertyName)
        ///     {
        ///         if (propertyName == nameof(StatusCodeRaw))
        ///         {
        ///             RaisePropertyChanged(nameof(StatusCode));
        ///         }
        ///     }
        /// }
        /// </code>
        /// Here, we have a computed property that depends on a persisted one. In order to notify any <see cref="PropertyChanged"/>
        /// subscribers that <c>StatusCode</c> has changed, we implement <see cref="OnPropertyChanged"/> and
        /// raise <see cref="PropertyChanged"/> manually by calling <see cref="RaisePropertyChanged"/>.
        /// </example>
        partial void OnPropertyChanged(string propertyName);

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            _propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            OnPropertyChanged(propertyName);
        }

        private void SubscribeForNotifications()
        {
            Accessor.SubscribeForNotifications(RaisePropertyChanged);
        }

        private void UnsubscribeFromNotifications()
        {
            Accessor.UnsubscribeFromNotifications();
        }

        public static explicit operator GuidType(RealmValue val) => val.AsRealmObject<GuidType>();

        public static implicit operator RealmValue(GuidType val) => RealmValue.Object(val);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public TypeInfo GetTypeInfo() => Accessor.GetTypeInfo(this);

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is InvalidObject)
            {
                return !IsValid;
            }

            if (obj is not IRealmObjectBase iro)
            {
                return false;
            }

            return Accessor.Equals(iro.Accessor);
        }

        public override int GetHashCode() => IsManaged ? Accessor.GetHashCode() : base.GetHashCode();

        public override string ToString() => Accessor.ToString();

        [EditorBrowsable(EditorBrowsableState.Never)]
        private class GuidTypeObjectHelper : IRealmObjectHelper
        {
            public void CopyToRealm(IRealmObjectBase instance, bool update, bool skipDefaults)
            {
                throw new InvalidOperationException("This method should not be called for source generated classes.");
            }

            public ManagedAccessor CreateAccessor() => new GuidTypeManagedAccessor();

            public IRealmObjectBase CreateInstance() => new GuidType();

            public bool TryGetPrimaryKeyValue(IRealmObjectBase instance, out object value)
            {
                value = ((IGuidTypeAccessor)instance.Accessor).Id;
                return true;
            }
        }
    }
}

namespace Realms.Tests.Database.Generated
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal interface IGuidTypeAccessor : IRealmAccessor
    {
        Guid Id { get; set; }

        Guid RegularProperty { get; set; }

        IList<Guid> GuidList { get; }

        ISet<Guid> GuidSet { get; }

        IDictionary<string, Guid> GuidDict { get; }

        Guid? OptionalProperty { get; set; }

        IList<Guid?> OptionalList { get; }

        ISet<Guid?> OptionalSet { get; }

        IDictionary<string, Guid?> OptionalDict { get; }

        GuidType LinkProperty { get; set; }

        RealmValue MixedProperty { get; set; }

        IList<RealmValue> MixedList { get; }

        ISet<RealmValue> MixedSet { get; }

        IDictionary<string, RealmValue> MixedDict { get; }

        EmbeddedGuidType EmbeddedProperty { get; set; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class GuidTypeManagedAccessor : ManagedAccessor, IGuidTypeAccessor
    {
        public Guid Id
        {
            get => (Guid)GetValue("_id");
            set => SetValueUnique("_id", value);
        }

        public Guid RegularProperty
        {
            get => (Guid)GetValue("RegularProperty");
            set => SetValue("RegularProperty", value);
        }

        private IList<Guid> _guidList;
        public IList<Guid> GuidList
        {
            get
            {
                if (_guidList == null)
                {
                    _guidList = GetListValue<Guid>("GuidList");
                }

                return _guidList;
            }
        }

        private ISet<Guid> _guidSet;
        public ISet<Guid> GuidSet
        {
            get
            {
                if (_guidSet == null)
                {
                    _guidSet = GetSetValue<Guid>("GuidSet");
                }

                return _guidSet;
            }
        }

        private IDictionary<string, Guid> _guidDict;
        public IDictionary<string, Guid> GuidDict
        {
            get
            {
                if (_guidDict == null)
                {
                    _guidDict = GetDictionaryValue<Guid>("GuidDict");
                }

                return _guidDict;
            }
        }

        public Guid? OptionalProperty
        {
            get => (Guid?)GetValue("OptionalProperty");
            set => SetValue("OptionalProperty", value);
        }

        private IList<Guid?> _optionalList;
        public IList<Guid?> OptionalList
        {
            get
            {
                if (_optionalList == null)
                {
                    _optionalList = GetListValue<Guid?>("OptionalList");
                }

                return _optionalList;
            }
        }

        private ISet<Guid?> _optionalSet;
        public ISet<Guid?> OptionalSet
        {
            get
            {
                if (_optionalSet == null)
                {
                    _optionalSet = GetSetValue<Guid?>("OptionalSet");
                }

                return _optionalSet;
            }
        }

        private IDictionary<string, Guid?> _optionalDict;
        public IDictionary<string, Guid?> OptionalDict
        {
            get
            {
                if (_optionalDict == null)
                {
                    _optionalDict = GetDictionaryValue<Guid?>("OptionalDict");
                }

                return _optionalDict;
            }
        }

        public GuidType LinkProperty
        {
            get => (GuidType)GetValue("LinkProperty");
            set => SetValue("LinkProperty", value);
        }

        public RealmValue MixedProperty
        {
            get => (RealmValue)GetValue("MixedProperty");
            set => SetValue("MixedProperty", value);
        }

        private IList<RealmValue> _mixedList;
        public IList<RealmValue> MixedList
        {
            get
            {
                if (_mixedList == null)
                {
                    _mixedList = GetListValue<RealmValue>("MixedList");
                }

                return _mixedList;
            }
        }

        private ISet<RealmValue> _mixedSet;
        public ISet<RealmValue> MixedSet
        {
            get
            {
                if (_mixedSet == null)
                {
                    _mixedSet = GetSetValue<RealmValue>("MixedSet");
                }

                return _mixedSet;
            }
        }

        private IDictionary<string, RealmValue> _mixedDict;
        public IDictionary<string, RealmValue> MixedDict
        {
            get
            {
                if (_mixedDict == null)
                {
                    _mixedDict = GetDictionaryValue<RealmValue>("MixedDict");
                }

                return _mixedDict;
            }
        }

        public EmbeddedGuidType EmbeddedProperty
        {
            get => (EmbeddedGuidType)GetValue("EmbeddedProperty");
            set => SetValue("EmbeddedProperty", value);
        }
    }

    internal class GuidTypeUnmanagedAccessor : UnmanagedAccessor, IGuidTypeAccessor
    {
        private Guid _id;
        public Guid Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged("Id");
            }
        }

        private Guid _regularProperty;
        public Guid RegularProperty
        {
            get => _regularProperty;
            set
            {
                _regularProperty = value;
                RaisePropertyChanged("RegularProperty");
            }
        }

        public IList<Guid> GuidList { get; } = new List<Guid>();

        public ISet<Guid> GuidSet { get; } = new HashSet<Guid>(RealmSet<Guid>.Comparer);

        public IDictionary<string, Guid> GuidDict { get; } = new Dictionary<string, Guid>();

        private Guid? _optionalProperty;
        public Guid? OptionalProperty
        {
            get => _optionalProperty;
            set
            {
                _optionalProperty = value;
                RaisePropertyChanged("OptionalProperty");
            }
        }

        public IList<Guid?> OptionalList { get; } = new List<Guid?>();

        public ISet<Guid?> OptionalSet { get; } = new HashSet<Guid?>(RealmSet<Guid?>.Comparer);

        public IDictionary<string, Guid?> OptionalDict { get; } = new Dictionary<string, Guid?>();

        private GuidType _linkProperty;
        public GuidType LinkProperty
        {
            get => _linkProperty;
            set
            {
                _linkProperty = value;
                RaisePropertyChanged("LinkProperty");
            }
        }

        private RealmValue _mixedProperty;
        public RealmValue MixedProperty
        {
            get => _mixedProperty;
            set
            {
                _mixedProperty = value;
                RaisePropertyChanged("MixedProperty");
            }
        }

        public IList<RealmValue> MixedList { get; } = new List<RealmValue>();

        public ISet<RealmValue> MixedSet { get; } = new HashSet<RealmValue>(RealmSet<RealmValue>.Comparer);

        public IDictionary<string, RealmValue> MixedDict { get; } = new Dictionary<string, RealmValue>();

        private EmbeddedGuidType _embeddedProperty;
        public EmbeddedGuidType EmbeddedProperty
        {
            get => _embeddedProperty;
            set
            {
                _embeddedProperty = value;
                RaisePropertyChanged("EmbeddedProperty");
            }
        }

        public GuidTypeUnmanagedAccessor(Type objectType) : base(objectType)
        {
        }

        public override RealmValue GetValue(string propertyName)
        {
            return propertyName switch
            {
                "_id" => _id,
                "RegularProperty" => _regularProperty,
                "OptionalProperty" => _optionalProperty,
                "LinkProperty" => _linkProperty,
                "MixedProperty" => _mixedProperty,
                "EmbeddedProperty" => _embeddedProperty,
                _ => throw new MissingMemberException($"The object does not have a gettable Realm property with name {propertyName}"),
            };
        }

        public override void SetValue(string propertyName, RealmValue val)
        {
            switch (propertyName)
            {
                case "_id":
                    throw new InvalidOperationException("Cannot set the value of a primary key property with SetValue. You need to use SetValueUnique");
                case "RegularProperty":
                    RegularProperty = (Guid)val;
                    return;
                case "OptionalProperty":
                    OptionalProperty = (Guid?)val;
                    return;
                case "LinkProperty":
                    LinkProperty = (GuidType)val;
                    return;
                case "MixedProperty":
                    MixedProperty = (RealmValue)val;
                    return;
                case "EmbeddedProperty":
                    EmbeddedProperty = (EmbeddedGuidType)val;
                    return;
                default:
                    throw new MissingMemberException($"The object does not have a settable Realm property with name {propertyName}");
            }
        }

        public override void SetValueUnique(string propertyName, RealmValue val)
        {
            if (propertyName != "_id")
            {
                throw new InvalidOperationException($"Cannot set the value of non primary key property ({propertyName}) with SetValueUnique");
            }

            Id = (Guid)val;
        }

        public override IList<T> GetListValue<T>(string propertyName)
        {
            return propertyName switch
                        {
            "GuidList" => (IList<T>)GuidList,
            "OptionalList" => (IList<T>)OptionalList,
            "MixedList" => (IList<T>)MixedList,

                            _ => throw new MissingMemberException($"The object does not have a Realm list property with name {propertyName}"),
                        };
        }

        public override ISet<T> GetSetValue<T>(string propertyName)
        {
            return propertyName switch
                        {
            "GuidSet" => (ISet<T>)GuidSet,
            "OptionalSet" => (ISet<T>)OptionalSet,
            "MixedSet" => (ISet<T>)MixedSet,

                            _ => throw new MissingMemberException($"The object does not have a Realm set property with name {propertyName}"),
                        };
        }

        public override IDictionary<string, TValue> GetDictionaryValue<TValue>(string propertyName)
        {
            return propertyName switch
            {
                "GuidDict" => (IDictionary<string, TValue>)GuidDict,
                "OptionalDict" => (IDictionary<string, TValue>)OptionalDict,
                "MixedDict" => (IDictionary<string, TValue>)MixedDict,
                _ => throw new MissingMemberException($"The object does not have a Realm dictionary property with name {propertyName}"),
            };
        }
    }
}