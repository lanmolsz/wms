﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSupplierProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SupplierProduct;

namespace Dddml.Wms.Domain.SupplierProduct
{
    public partial class SupplierProductAggregate : AggregateBase, ISupplierProductAggregate
    {

        readonly ISupplierProductState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public ISupplierProductState State
        {
            get
            {
                return _state;
            }
        }

        public IList<IEvent> Changes
        {
            get
            {
                return _changes;
            }
        }

        #region IIdentity implementation

        SupplierProductId IGlobalIdentity<SupplierProductId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public SupplierProductAggregate(ISupplierProductState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((ISupplierProductStateProperties)_state).Version == SupplierProductState.VersionZero)
            {
                if (IsCommandCreate((ISupplierProductCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (IsCommandCreate((ISupplierProductCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(ISupplierProductCommand c)
        {
            return c.Version == SupplierProductState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateSupplierProduct c)
        {
            ISupplierProductStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchSupplierProduct c)
        {
            ISupplierProductStateMergePatched e = Map(c);
            Apply(e);
        }


        protected virtual ISupplierProductStateCreated Map(ICreateSupplierProduct c)
        {
			var stateEventId = new SupplierProductStateEventId(c.SupplierProductId, c.Version);
            ISupplierProductStateCreated e = NewSupplierProductStateCreated(stateEventId);
		
            e.AvailableThruDate = c.AvailableThruDate;
            e.SupplierPrefOrderId = c.SupplierPrefOrderId;
            e.SupplierRatingTypeId = c.SupplierRatingTypeId;
            e.StandardLeadTimeDays = c.StandardLeadTimeDays;
            e.ManufacturingLeadTimeDays = c.ManufacturingLeadTimeDays;
            e.DeliveryLeadTimeDays = c.DeliveryLeadTimeDays;
            e.QuantityUomId = c.QuantityUomId;
            e.LastPrice = c.LastPrice;
            e.ShippingPrice = c.ShippingPrice;
            e.ExternalProductName = c.ExternalProductName;
            e.ExternalProductId = c.ExternalProductId;
            e.CanDropShip = c.CanDropShip;
            e.Comments = c.Comments;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;


            return e;
        }

        protected virtual ISupplierProductStateMergePatched Map(IMergePatchSupplierProduct c)
        {
			var stateEventId = new SupplierProductStateEventId(c.SupplierProductId, c.Version);
            ISupplierProductStateMergePatched e = NewSupplierProductStateMergePatched(stateEventId);

            e.AvailableThruDate = c.AvailableThruDate;
            e.SupplierPrefOrderId = c.SupplierPrefOrderId;
            e.SupplierRatingTypeId = c.SupplierRatingTypeId;
            e.StandardLeadTimeDays = c.StandardLeadTimeDays;
            e.ManufacturingLeadTimeDays = c.ManufacturingLeadTimeDays;
            e.DeliveryLeadTimeDays = c.DeliveryLeadTimeDays;
            e.QuantityUomId = c.QuantityUomId;
            e.LastPrice = c.LastPrice;
            e.ShippingPrice = c.ShippingPrice;
            e.ExternalProductName = c.ExternalProductName;
            e.ExternalProductId = c.ExternalProductId;
            e.CanDropShip = c.CanDropShip;
            e.Comments = c.Comments;
            e.Active = c.Active;
            e.IsPropertyAvailableThruDateRemoved = c.IsPropertyAvailableThruDateRemoved;
            e.IsPropertySupplierPrefOrderIdRemoved = c.IsPropertySupplierPrefOrderIdRemoved;
            e.IsPropertySupplierRatingTypeIdRemoved = c.IsPropertySupplierRatingTypeIdRemoved;
            e.IsPropertyStandardLeadTimeDaysRemoved = c.IsPropertyStandardLeadTimeDaysRemoved;
            e.IsPropertyManufacturingLeadTimeDaysRemoved = c.IsPropertyManufacturingLeadTimeDaysRemoved;
            e.IsPropertyDeliveryLeadTimeDaysRemoved = c.IsPropertyDeliveryLeadTimeDaysRemoved;
            e.IsPropertyQuantityUomIdRemoved = c.IsPropertyQuantityUomIdRemoved;
            e.IsPropertyLastPriceRemoved = c.IsPropertyLastPriceRemoved;
            e.IsPropertyShippingPriceRemoved = c.IsPropertyShippingPriceRemoved;
            e.IsPropertyExternalProductNameRemoved = c.IsPropertyExternalProductNameRemoved;
            e.IsPropertyExternalProductIdRemoved = c.IsPropertyExternalProductIdRemoved;
            e.IsPropertyCanDropShipRemoved = c.IsPropertyCanDropShipRemoved;
            e.IsPropertyCommentsRemoved = c.IsPropertyCommentsRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;


            return e;
        }

        private void ThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (!Object.Equals(innerIdValue, outerIdValue))
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected SupplierProductStateCreated NewSupplierProductStateCreated(long version, string commandId, string requesterId)
        {
            var stateEventId = new SupplierProductStateEventId(_state.SupplierProductId, version);
            var e = NewSupplierProductStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected SupplierProductStateMergePatched NewSupplierProductStateMergePatched(long version, string commandId, string requesterId)
        {
            var stateEventId = new SupplierProductStateEventId(_state.SupplierProductId, version);
            var e = NewSupplierProductStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


////////////////////////

		private SupplierProductStateCreated NewSupplierProductStateCreated(SupplierProductStateEventId stateEventId)
		{
			return new SupplierProductStateCreated(stateEventId);			
		}

        private SupplierProductStateMergePatched NewSupplierProductStateMergePatched(SupplierProductStateEventId stateEventId)
		{
			return new SupplierProductStateMergePatched(stateEventId);
		}

    }

}

