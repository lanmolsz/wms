﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentPackageContentMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentPackageContentMvo;
using Dddml.Wms.Domain.ShipmentPackage;

namespace Dddml.Wms.Domain.ShipmentPackageContentMvo
{

	public partial class ShipmentPackageContentMvoState : ShipmentPackageContentMvoStateProperties, IShipmentPackageContentMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		ShipmentPackageContentId IGlobalIdentity<ShipmentPackageContentId>.GlobalId
		{
			get
			{
				return this.ShipmentPackageContentId;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
			}
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.ShipmentPackageVersion;
			}
		}


		#endregion

        bool IShipmentPackageContentMvoState.IsUnsaved
        {
            get { return this.ShipmentPackageVersion == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public ShipmentPackageContentMvoState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.ShipmentPackageContentId = ((IShipmentPackageContentMvoEvent)events.First()).ShipmentPackageContentMvoEventId.ShipmentPackageContentId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.ShipmentPackageVersion += 1;
                }
            }
        }

        public ShipmentPackageContentMvoState() : this(false)
        {
        }

        public ShipmentPackageContentMvoState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IShipmentPackageContentMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.Quantity = e.Quantity;

			this.SubProductId = e.SubProductId;

			this.SubProductQuantity = e.SubProductQuantity;

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.ShipmentPackageShipmentBoxTypeId = e.ShipmentPackageShipmentBoxTypeId;

			this.ShipmentPackageDateCreated = e.ShipmentPackageDateCreated;

			this.ShipmentPackageBoxLength = e.ShipmentPackageBoxLength;

			this.ShipmentPackageBoxHeight = e.ShipmentPackageBoxHeight;

			this.ShipmentPackageBoxWidth = e.ShipmentPackageBoxWidth;

			this.ShipmentPackageDimensionUomId = e.ShipmentPackageDimensionUomId;

			this.ShipmentPackageWeight = e.ShipmentPackageWeight;

			this.ShipmentPackageWeightUomId = e.ShipmentPackageWeightUomId;

			this.ShipmentPackageInsuredValue = e.ShipmentPackageInsuredValue;

			this.ShipmentPackageCreatedBy = e.ShipmentPackageCreatedBy;

            this.ShipmentPackageCreatedAt = (e.ShipmentPackageCreatedAt != null && e.ShipmentPackageCreatedAt.HasValue) ? e.ShipmentPackageCreatedAt.Value : default(DateTime);

			this.ShipmentPackageUpdatedBy = e.ShipmentPackageUpdatedBy;

            this.ShipmentPackageUpdatedAt = (e.ShipmentPackageUpdatedAt != null && e.ShipmentPackageUpdatedAt.HasValue) ? e.ShipmentPackageUpdatedAt.Value : default(DateTime);

            this.ShipmentPackageActive = (e.ShipmentPackageActive != null && e.ShipmentPackageActive.HasValue) ? e.ShipmentPackageActive.Value : default(bool);

            this.ShipmentPackageDeleted = (e.ShipmentPackageDeleted != null && e.ShipmentPackageDeleted.HasValue) ? e.ShipmentPackageDeleted.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IShipmentPackageContentMvoStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.Quantity == null)
			{
				if (e.IsPropertyQuantityRemoved)
				{
					this.Quantity = default(decimal?);
				}
			}
			else
			{
				this.Quantity = e.Quantity;
			}

			if (e.SubProductId == null)
			{
				if (e.IsPropertySubProductIdRemoved)
				{
					this.SubProductId = default(string);
				}
			}
			else
			{
				this.SubProductId = e.SubProductId;
			}

			if (e.SubProductQuantity == null)
			{
				if (e.IsPropertySubProductQuantityRemoved)
				{
					this.SubProductQuantity = default(decimal?);
				}
			}
			else
			{
				this.SubProductQuantity = e.SubProductQuantity;
			}

			if (e.Version == null)
			{
				if (e.IsPropertyVersionRemoved)
				{
					this.Version = default(long);
				}
			}
			else
			{
				this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}

			if (e.ShipmentPackageShipmentBoxTypeId == null)
			{
				if (e.IsPropertyShipmentPackageShipmentBoxTypeIdRemoved)
				{
					this.ShipmentPackageShipmentBoxTypeId = default(string);
				}
			}
			else
			{
				this.ShipmentPackageShipmentBoxTypeId = e.ShipmentPackageShipmentBoxTypeId;
			}

			if (e.ShipmentPackageDateCreated == null)
			{
				if (e.IsPropertyShipmentPackageDateCreatedRemoved)
				{
					this.ShipmentPackageDateCreated = default(DateTime?);
				}
			}
			else
			{
				this.ShipmentPackageDateCreated = e.ShipmentPackageDateCreated;
			}

			if (e.ShipmentPackageBoxLength == null)
			{
				if (e.IsPropertyShipmentPackageBoxLengthRemoved)
				{
					this.ShipmentPackageBoxLength = default(decimal?);
				}
			}
			else
			{
				this.ShipmentPackageBoxLength = e.ShipmentPackageBoxLength;
			}

			if (e.ShipmentPackageBoxHeight == null)
			{
				if (e.IsPropertyShipmentPackageBoxHeightRemoved)
				{
					this.ShipmentPackageBoxHeight = default(decimal?);
				}
			}
			else
			{
				this.ShipmentPackageBoxHeight = e.ShipmentPackageBoxHeight;
			}

			if (e.ShipmentPackageBoxWidth == null)
			{
				if (e.IsPropertyShipmentPackageBoxWidthRemoved)
				{
					this.ShipmentPackageBoxWidth = default(decimal?);
				}
			}
			else
			{
				this.ShipmentPackageBoxWidth = e.ShipmentPackageBoxWidth;
			}

			if (e.ShipmentPackageDimensionUomId == null)
			{
				if (e.IsPropertyShipmentPackageDimensionUomIdRemoved)
				{
					this.ShipmentPackageDimensionUomId = default(string);
				}
			}
			else
			{
				this.ShipmentPackageDimensionUomId = e.ShipmentPackageDimensionUomId;
			}

			if (e.ShipmentPackageWeight == null)
			{
				if (e.IsPropertyShipmentPackageWeightRemoved)
				{
					this.ShipmentPackageWeight = default(decimal?);
				}
			}
			else
			{
				this.ShipmentPackageWeight = e.ShipmentPackageWeight;
			}

			if (e.ShipmentPackageWeightUomId == null)
			{
				if (e.IsPropertyShipmentPackageWeightUomIdRemoved)
				{
					this.ShipmentPackageWeightUomId = default(string);
				}
			}
			else
			{
				this.ShipmentPackageWeightUomId = e.ShipmentPackageWeightUomId;
			}

			if (e.ShipmentPackageInsuredValue == null)
			{
				if (e.IsPropertyShipmentPackageInsuredValueRemoved)
				{
					this.ShipmentPackageInsuredValue = default(decimal?);
				}
			}
			else
			{
				this.ShipmentPackageInsuredValue = e.ShipmentPackageInsuredValue;
			}

			if (e.ShipmentPackageCreatedBy == null)
			{
				if (e.IsPropertyShipmentPackageCreatedByRemoved)
				{
					this.ShipmentPackageCreatedBy = default(string);
				}
			}
			else
			{
				this.ShipmentPackageCreatedBy = e.ShipmentPackageCreatedBy;
			}

			if (e.ShipmentPackageCreatedAt == null)
			{
				if (e.IsPropertyShipmentPackageCreatedAtRemoved)
				{
					this.ShipmentPackageCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.ShipmentPackageCreatedAt = (e.ShipmentPackageCreatedAt != null && e.ShipmentPackageCreatedAt.HasValue) ? e.ShipmentPackageCreatedAt.Value : default(DateTime);
			}

			if (e.ShipmentPackageUpdatedBy == null)
			{
				if (e.IsPropertyShipmentPackageUpdatedByRemoved)
				{
					this.ShipmentPackageUpdatedBy = default(string);
				}
			}
			else
			{
				this.ShipmentPackageUpdatedBy = e.ShipmentPackageUpdatedBy;
			}

			if (e.ShipmentPackageUpdatedAt == null)
			{
				if (e.IsPropertyShipmentPackageUpdatedAtRemoved)
				{
					this.ShipmentPackageUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.ShipmentPackageUpdatedAt = (e.ShipmentPackageUpdatedAt != null && e.ShipmentPackageUpdatedAt.HasValue) ? e.ShipmentPackageUpdatedAt.Value : default(DateTime);
			}

			if (e.ShipmentPackageActive == null)
			{
				if (e.IsPropertyShipmentPackageActiveRemoved)
				{
					this.ShipmentPackageActive = default(bool);
				}
			}
			else
			{
				this.ShipmentPackageActive = (e.ShipmentPackageActive != null && e.ShipmentPackageActive.HasValue) ? e.ShipmentPackageActive.Value : default(bool);
			}

			if (e.ShipmentPackageDeleted == null)
			{
				if (e.IsPropertyShipmentPackageDeletedRemoved)
				{
					this.ShipmentPackageDeleted = default(bool);
				}
			}
			else
			{
				this.ShipmentPackageDeleted = (e.ShipmentPackageDeleted != null && e.ShipmentPackageDeleted.HasValue) ? e.ShipmentPackageDeleted.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IShipmentPackageContentMvoStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IShipmentPackageContentMvoEvent e)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("ShipmentPackageContentMvo|");

            var stateEntityId = this.ShipmentPackageContentId; // Aggregate Id
            var eventEntityId = e.ShipmentPackageContentMvoEventId.ShipmentPackageContentId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.ShipmentPackageVersion;
            var eventVersion = e.ShipmentPackageContentMvoEventId.ShipmentPackageVersion;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

