﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentPackageContentMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentPackageContentMvo;
using Dddml.Wms.Domain.ShipmentPackage;

namespace Dddml.Wms.Domain.ShipmentPackageContentMvo
{

	public abstract class ShipmentPackageContentMvoStateEventDtoBase : IEventDto, IShipmentPackageContentMvoStateCreated, IShipmentPackageContentMvoStateMergePatched, IShipmentPackageContentMvoStateDeleted
	{

        private ShipmentPackageContentMvoEventId _shipmentPackageContentMvoEventId;

		protected internal virtual ShipmentPackageContentMvoEventId ShipmentPackageContentMvoEventId 
        {
            get 
            {
                if (_shipmentPackageContentMvoEventId == null) { _shipmentPackageContentMvoEventId = new ShipmentPackageContentMvoEventId(); }
                return _shipmentPackageContentMvoEventId;
            }
            set
            {
                _shipmentPackageContentMvoEventId = value;
            }
        }

        public virtual ShipmentPackageContentId ShipmentPackageContentId
        {
            get { return ShipmentPackageContentMvoEventId.ShipmentPackageContentId; }
            set { ShipmentPackageContentMvoEventId.ShipmentPackageContentId = value; }
        }

        public virtual long ShipmentPackageVersion
        {
            get { return ShipmentPackageContentMvoEventId.ShipmentPackageVersion; }
            set { ShipmentPackageContentMvoEventId.ShipmentPackageVersion = value; }
        }

		public virtual decimal? Quantity { get; set; }

		public virtual string SubProductId { get; set; }

		public virtual decimal? SubProductQuantity { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string ShipmentPackageShipmentBoxTypeId { get; set; }

		public virtual DateTime? ShipmentPackageDateCreated { get; set; }

		public virtual decimal? ShipmentPackageBoxLength { get; set; }

		public virtual decimal? ShipmentPackageBoxHeight { get; set; }

		public virtual decimal? ShipmentPackageBoxWidth { get; set; }

		public virtual string ShipmentPackageDimensionUomId { get; set; }

		public virtual decimal? ShipmentPackageWeight { get; set; }

		public virtual string ShipmentPackageWeightUomId { get; set; }

		public virtual decimal? ShipmentPackageInsuredValue { get; set; }

		public virtual string ShipmentPackageCreatedBy { get; set; }

		public virtual DateTime? ShipmentPackageCreatedAt { get; set; }

		public virtual string ShipmentPackageUpdatedBy { get; set; }

		public virtual DateTime? ShipmentPackageUpdatedAt { get; set; }

		public virtual bool? ShipmentPackageActive { get; set; }

		public virtual bool? ShipmentPackageDeleted { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ShipmentPackageContentMvoEventId IGlobalIdentity<ShipmentPackageContentMvoEventId>.GlobalId {
			get 
			{
				return this.ShipmentPackageContentMvoEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IShipmentPackageContentMvoEvent.ReadOnly
        {
            get
            {
                return this.EventReadOnly;
            }
            set
            {
                this.EventReadOnly = value;
            }
        }

		public virtual bool? IsPropertyQuantityRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertySubProductIdRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertySubProductIdRemoved
        {
            get 
            {
                var b = this.IsPropertySubProductIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySubProductIdRemoved = value;
            }
        }

		public virtual bool? IsPropertySubProductQuantityRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertySubProductQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertySubProductQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySubProductQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyVersionRemoved
        {
            get 
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageShipmentBoxTypeIdRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageShipmentBoxTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageShipmentBoxTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageShipmentBoxTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageDateCreatedRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageDateCreatedRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageDateCreatedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageDateCreatedRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageBoxLengthRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageBoxLengthRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageBoxLengthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageBoxLengthRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageBoxHeightRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageBoxHeightRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageBoxHeightRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageBoxHeightRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageBoxWidthRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageBoxWidthRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageBoxWidthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageBoxWidthRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageDimensionUomIdRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageDimensionUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageDimensionUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageDimensionUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageWeightRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageWeightRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageWeightRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageWeightRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageWeightUomIdRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageWeightUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageWeightUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageWeightUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageInsuredValueRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageInsuredValueRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageInsuredValueRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageInsuredValueRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageCreatedByRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageCreatedAtRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageUpdatedByRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageUpdatedAtRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageActiveRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageDeletedRemoved { get; set; }

        bool IShipmentPackageContentMvoStateMergePatched.IsPropertyShipmentPackageDeletedRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentPackageDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentPackageDeletedRemoved = value;
            }
        }

		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}


        ShipmentPackageContentMvoEventId IShipmentPackageContentMvoEvent.ShipmentPackageContentMvoEventId
        {
            get { return this.ShipmentPackageContentMvoEventId; }
        }

        protected ShipmentPackageContentMvoStateEventDtoBase()
        {
        }

        protected ShipmentPackageContentMvoStateEventDtoBase(ShipmentPackageContentMvoEventId stateEventId)
        {
            this.ShipmentPackageContentMvoEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IEventDto.EventType 
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}


    public class ShipmentPackageContentMvoStateCreatedOrMergePatchedOrDeletedDto : ShipmentPackageContentMvoStateEventDtoBase
    {
        private string _eventType;

        public virtual string EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }

        protected override string GetEventType()
        {
            return this._eventType;
        }

    }



	public class ShipmentPackageContentMvoStateCreatedDto : ShipmentPackageContentMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public ShipmentPackageContentMvoStateCreatedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ShipmentPackageContentMvoStateMergePatchedDto : ShipmentPackageContentMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public ShipmentPackageContentMvoStateMergePatchedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class ShipmentPackageContentMvoStateDeletedDto : ShipmentPackageContentMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public ShipmentPackageContentMvoStateDeletedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class ShipmentPackageContentMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IShipmentPackageContentMvoStateCreated>, IEnumerable<IShipmentPackageContentMvoStateMergePatched>, IEnumerable<IShipmentPackageContentMvoStateDeleted>
    {
        private List<ShipmentPackageContentMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<ShipmentPackageContentMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual ShipmentPackageContentMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<ShipmentPackageContentMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IShipmentPackageContentMvoStateCreated> IEnumerable<IShipmentPackageContentMvoStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IShipmentPackageContentMvoStateMergePatched> IEnumerable<IShipmentPackageContentMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IShipmentPackageContentMvoStateDeleted> IEnumerable<IShipmentPackageContentMvoStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddShipmentPackageContentMvoEvent(IShipmentPackageContentMvoStateCreated e)
        {
            _innerStateEvents.Add((ShipmentPackageContentMvoStateCreatedDto)e);
        }

        public void AddShipmentPackageContentMvoEvent(IShipmentPackageContentMvoEvent e)
        {
            _innerStateEvents.Add((ShipmentPackageContentMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddShipmentPackageContentMvoEvent(IShipmentPackageContentMvoStateDeleted e)
        {
            _innerStateEvents.Add((ShipmentPackageContentMvoStateDeletedDto)e);
        }

    }


}

