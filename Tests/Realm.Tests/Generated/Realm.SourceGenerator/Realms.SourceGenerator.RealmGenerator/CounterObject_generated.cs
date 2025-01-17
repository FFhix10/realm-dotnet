﻿// <auto-generated />
using Realms;
using Realms.Schema;
using Realms.Tests;
using Realms.Tests.Generated;
using Realms.Weaving;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Realms.Tests
{
    [Generated]
    [Woven(typeof(CounterObjectObjectHelper))]
    public partial class CounterObject : IRealmObject, INotifyPropertyChanged, IReflectableType
    {
        public static ObjectSchema RealmSchema = new ObjectSchema.Builder("CounterObject", ObjectSchema.ObjectType.RealmObject)
        {
            Property.Primitive("_id", RealmValueType.Int, isPrimaryKey: true, isIndexed: false, isNullable: false, managedName: "Id"),
            Property.Primitive("ByteProperty", RealmValueType.Int, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "ByteProperty"),
            Property.Primitive("Int16Property", RealmValueType.Int, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "Int16Property"),
            Property.Primitive("Int32Property", RealmValueType.Int, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "Int32Property"),
            Property.Primitive("Int64Property", RealmValueType.Int, isPrimaryKey: false, isIndexed: false, isNullable: false, managedName: "Int64Property"),
            Property.Primitive("NullableByteProperty", RealmValueType.Int, isPrimaryKey: false, isIndexed: false, isNullable: true, managedName: "NullableByteProperty"),
            Property.Primitive("NullableInt16Property", RealmValueType.Int, isPrimaryKey: false, isIndexed: false, isNullable: true, managedName: "NullableInt16Property"),
            Property.Primitive("NullableInt32Property", RealmValueType.Int, isPrimaryKey: false, isIndexed: false, isNullable: true, managedName: "NullableInt32Property"),
            Property.Primitive("NullableInt64Property", RealmValueType.Int, isPrimaryKey: false, isIndexed: false, isNullable: true, managedName: "NullableInt64Property"),
        }.Build();

        #region IRealmObject implementation

        private ICounterObjectAccessor _accessor;

        IRealmAccessor IRealmObjectBase.Accessor => Accessor;

        internal ICounterObjectAccessor Accessor => _accessor ?? (_accessor = new CounterObjectUnmanagedAccessor(typeof(CounterObject)));

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
            var newAccessor = (ICounterObjectAccessor)managedAccessor;
            var oldAccessor = (ICounterObjectAccessor)_accessor;
            _accessor = newAccessor;

            if (helper != null)
            {
                if(!skipDefaults || oldAccessor.Id != default(int))
                {
                    newAccessor.Id = oldAccessor.Id;
                }
                newAccessor.ByteProperty = oldAccessor.ByteProperty;
                newAccessor.Int16Property = oldAccessor.Int16Property;
                newAccessor.Int32Property = oldAccessor.Int32Property;
                newAccessor.Int64Property = oldAccessor.Int64Property;
                newAccessor.NullableByteProperty = oldAccessor.NullableByteProperty;
                newAccessor.NullableInt16Property = oldAccessor.NullableInt16Property;
                newAccessor.NullableInt32Property = oldAccessor.NullableInt32Property;
                newAccessor.NullableInt64Property = oldAccessor.NullableInt64Property;
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

        public static explicit operator CounterObject(RealmValue val) => val.AsRealmObject<CounterObject>();

        public static implicit operator RealmValue(CounterObject val) => RealmValue.Object(val);

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

        [EditorBrowsable(EditorBrowsableState.Never)]
        private class CounterObjectObjectHelper : IRealmObjectHelper
        {
            public void CopyToRealm(IRealmObjectBase instance, bool update, bool skipDefaults)
            {
                throw new InvalidOperationException("This method should not be called for source generated classes.");
            }

            public ManagedAccessor CreateAccessor() => new CounterObjectManagedAccessor();

            public IRealmObjectBase CreateInstance() => new CounterObject();

            public bool TryGetPrimaryKeyValue(IRealmObjectBase instance, out object value)
            {
                value = ((ICounterObjectAccessor)instance.Accessor).Id;
                return true;
            }
        }
    }
}

namespace Realms.Tests.Generated
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal interface ICounterObjectAccessor : IRealmAccessor
    {
        int Id { get; set; }

        RealmInteger<byte> ByteProperty { get; set; }

        RealmInteger<short> Int16Property { get; set; }

        RealmInteger<int> Int32Property { get; set; }

        RealmInteger<long> Int64Property { get; set; }

        RealmInteger<byte>? NullableByteProperty { get; set; }

        RealmInteger<short>? NullableInt16Property { get; set; }

        RealmInteger<int>? NullableInt32Property { get; set; }

        RealmInteger<long>? NullableInt64Property { get; set; }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class CounterObjectManagedAccessor : ManagedAccessor, ICounterObjectAccessor
    {
        public int Id
        {
            get => (int)GetValue("_id");
            set => SetValueUnique("_id", value);
        }

        public RealmInteger<byte> ByteProperty
        {
            get => (RealmInteger<byte>)GetValue("ByteProperty");
            set => SetValue("ByteProperty", value);
        }

        public RealmInteger<short> Int16Property
        {
            get => (RealmInteger<short>)GetValue("Int16Property");
            set => SetValue("Int16Property", value);
        }

        public RealmInteger<int> Int32Property
        {
            get => (RealmInteger<int>)GetValue("Int32Property");
            set => SetValue("Int32Property", value);
        }

        public RealmInteger<long> Int64Property
        {
            get => (RealmInteger<long>)GetValue("Int64Property");
            set => SetValue("Int64Property", value);
        }

        public RealmInteger<byte>? NullableByteProperty
        {
            get => (RealmInteger<byte>?)GetValue("NullableByteProperty");
            set => SetValue("NullableByteProperty", value);
        }

        public RealmInteger<short>? NullableInt16Property
        {
            get => (RealmInteger<short>?)GetValue("NullableInt16Property");
            set => SetValue("NullableInt16Property", value);
        }

        public RealmInteger<int>? NullableInt32Property
        {
            get => (RealmInteger<int>?)GetValue("NullableInt32Property");
            set => SetValue("NullableInt32Property", value);
        }

        public RealmInteger<long>? NullableInt64Property
        {
            get => (RealmInteger<long>?)GetValue("NullableInt64Property");
            set => SetValue("NullableInt64Property", value);
        }
    }

    internal class CounterObjectUnmanagedAccessor : UnmanagedAccessor, ICounterObjectAccessor
    {
        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged("Id");
            }
        }

        private RealmInteger<byte> _byteProperty;
        public RealmInteger<byte> ByteProperty
        {
            get => _byteProperty;
            set
            {
                _byteProperty = value;
                RaisePropertyChanged("ByteProperty");
            }
        }

        private RealmInteger<short> _int16Property;
        public RealmInteger<short> Int16Property
        {
            get => _int16Property;
            set
            {
                _int16Property = value;
                RaisePropertyChanged("Int16Property");
            }
        }

        private RealmInteger<int> _int32Property;
        public RealmInteger<int> Int32Property
        {
            get => _int32Property;
            set
            {
                _int32Property = value;
                RaisePropertyChanged("Int32Property");
            }
        }

        private RealmInteger<long> _int64Property;
        public RealmInteger<long> Int64Property
        {
            get => _int64Property;
            set
            {
                _int64Property = value;
                RaisePropertyChanged("Int64Property");
            }
        }

        private RealmInteger<byte>? _nullableByteProperty;
        public RealmInteger<byte>? NullableByteProperty
        {
            get => _nullableByteProperty;
            set
            {
                _nullableByteProperty = value;
                RaisePropertyChanged("NullableByteProperty");
            }
        }

        private RealmInteger<short>? _nullableInt16Property;
        public RealmInteger<short>? NullableInt16Property
        {
            get => _nullableInt16Property;
            set
            {
                _nullableInt16Property = value;
                RaisePropertyChanged("NullableInt16Property");
            }
        }

        private RealmInteger<int>? _nullableInt32Property;
        public RealmInteger<int>? NullableInt32Property
        {
            get => _nullableInt32Property;
            set
            {
                _nullableInt32Property = value;
                RaisePropertyChanged("NullableInt32Property");
            }
        }

        private RealmInteger<long>? _nullableInt64Property;
        public RealmInteger<long>? NullableInt64Property
        {
            get => _nullableInt64Property;
            set
            {
                _nullableInt64Property = value;
                RaisePropertyChanged("NullableInt64Property");
            }
        }

        public CounterObjectUnmanagedAccessor(Type objectType) : base(objectType)
        {
        }

        public override RealmValue GetValue(string propertyName)
        {
            return propertyName switch
            {
                "_id" => _id,
                "ByteProperty" => _byteProperty,
                "Int16Property" => _int16Property,
                "Int32Property" => _int32Property,
                "Int64Property" => _int64Property,
                "NullableByteProperty" => _nullableByteProperty,
                "NullableInt16Property" => _nullableInt16Property,
                "NullableInt32Property" => _nullableInt32Property,
                "NullableInt64Property" => _nullableInt64Property,
                _ => throw new MissingMemberException($"The object does not have a gettable Realm property with name {propertyName}"),
            };
        }

        public override void SetValue(string propertyName, RealmValue val)
        {
            switch (propertyName)
            {
                case "_id":
                    throw new InvalidOperationException("Cannot set the value of a primary key property with SetValue. You need to use SetValueUnique");
                case "ByteProperty":
                    ByteProperty = (RealmInteger<byte>)val;
                    return;
                case "Int16Property":
                    Int16Property = (RealmInteger<short>)val;
                    return;
                case "Int32Property":
                    Int32Property = (RealmInteger<int>)val;
                    return;
                case "Int64Property":
                    Int64Property = (RealmInteger<long>)val;
                    return;
                case "NullableByteProperty":
                    NullableByteProperty = (RealmInteger<byte>?)val;
                    return;
                case "NullableInt16Property":
                    NullableInt16Property = (RealmInteger<short>?)val;
                    return;
                case "NullableInt32Property":
                    NullableInt32Property = (RealmInteger<int>?)val;
                    return;
                case "NullableInt64Property":
                    NullableInt64Property = (RealmInteger<long>?)val;
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

            Id = (int)val;
        }

        public override IList<T> GetListValue<T>(string propertyName)
        {
            throw new MissingMemberException($"The object does not have a Realm list property with name {propertyName}");
        }

        public override ISet<T> GetSetValue<T>(string propertyName)
        {
            throw new MissingMemberException($"The object does not have a Realm set property with name {propertyName}");
        }

        public override IDictionary<string, TValue> GetDictionaryValue<TValue>(string propertyName)
        {
            throw new MissingMemberException($"The object does not have a Realm dictionary property with name {propertyName}");
        }
    }
}