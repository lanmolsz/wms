﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.Shipment
{

	public abstract class ShipmentItemStateEventDtoBase : IStateEventDto, IShipmentItemStateCreated, IShipmentItemStateMergePatched
	{

        private ShipmentItemStateEventIdDto _stateEventId;

		protected internal virtual ShipmentItemStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new ShipmentItemStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string ShipmentItemSeqId
        {
            get { return StateEventId.ShipmentItemSeqId; }
            set { StateEventId.ShipmentItemSeqId = value; }
        }

		public virtual string ProductId { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual string ShipmentContentDescription { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ShipmentItemStateEventId IGlobalIdentity<ShipmentItemStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToShipmentItemStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IShipmentItemStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }

		public virtual long Version { get; set; }

		public virtual bool? IsPropertyProductIdRemoved { get; set; }

        bool IShipmentItemStateMergePatched.IsPropertyProductIdRemoved
        {
            get 
            {
                var b = this.IsPropertyProductIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetInstanceIdRemoved { get; set; }

        bool IShipmentItemStateMergePatched.IsPropertyAttributeSetInstanceIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetInstanceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetInstanceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuantityRemoved { get; set; }

        bool IShipmentItemStateMergePatched.IsPropertyQuantityRemoved
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

		public virtual bool? IsPropertyShipmentContentDescriptionRemoved { get; set; }

        bool IShipmentItemStateMergePatched.IsPropertyShipmentContentDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentContentDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentContentDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IShipmentItemStateMergePatched.IsPropertyActiveRemoved
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


        ShipmentItemStateEventId IShipmentItemStateEvent.StateEventId
        {
            get { return this.StateEventId.ToShipmentItemStateEventId(); }
        }

        protected ShipmentItemStateEventDtoBase()
        {
        }

        protected ShipmentItemStateEventDtoBase(ShipmentItemStateEventIdDto stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class ShipmentItemStateCreatedOrMergePatchedOrRemovedDto : ShipmentItemStateEventDtoBase
    {
        private string _stateEventType;

        public virtual string StateEventType
        {
            get { return _stateEventType; }
            set { _stateEventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._stateEventType;
        }

    }



	public class ShipmentItemStateCreatedDto : ShipmentItemStateCreatedOrMergePatchedOrRemovedDto
	{
		public ShipmentItemStateCreatedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ShipmentItemStateMergePatchedDto : ShipmentItemStateCreatedOrMergePatchedOrRemovedDto
	{
		public ShipmentItemStateMergePatchedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class ShipmentItemStateRemovedDto : ShipmentItemStateCreatedOrMergePatchedOrRemovedDto
	{
		public ShipmentItemStateRemovedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }

	}


    public partial class ShipmentItemStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IShipmentItemStateCreated>, IEnumerable<IShipmentItemStateMergePatched>
    {
        private List<ShipmentItemStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<ShipmentItemStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual ShipmentItemStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<ShipmentItemStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IShipmentItemStateCreated> IEnumerable<IShipmentItemStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IShipmentItemStateMergePatched> IEnumerable<IShipmentItemStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddShipmentItemEvent(IShipmentItemStateCreated e)
        {
            _innerStateEvents.Add((ShipmentItemStateCreatedDto)e);
        }

        public void AddShipmentItemEvent(IShipmentItemStateEvent e)
        {
            _innerStateEvents.Add((ShipmentItemStateCreatedOrMergePatchedOrRemovedDto)e);
        }


    }


}

