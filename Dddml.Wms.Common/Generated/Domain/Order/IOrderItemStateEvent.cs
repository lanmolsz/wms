﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.Order
{
	public interface IOrderItemStateEvent : IEvent, IStateEventDto, IGlobalIdentity<OrderItemStateEventId>, ICreated<string>
	{
		OrderItemStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		string ProductId { get; set; }

		string ExternalProductId { get; set; }

		decimal? Quantity { get; set; }

		decimal? CancelQuantity { get; set; }

		decimal? SelectedAmount { get; set; }

		string ExternalId { get; set; }

		string OrderItemTypeId { get; set; }

		string OrderItemGroupSeqId { get; set; }

		string IsItemGroupPrimary { get; set; }

		string FromInventoryItemId { get; set; }

		string IsPromo { get; set; }

		string QuoteId { get; set; }

		string QuoteItemSeqId { get; set; }

		string ShoppingListId { get; set; }

		string ShoppingListItemSeqId { get; set; }

		decimal? UnitPrice { get; set; }

		decimal? UnitListPrice { get; set; }

		decimal? UnitAverageCost { get; set; }

		decimal? UnitRecurringPrice { get; set; }

		string IsModifiedPrice { get; set; }

		string RecurringFreqUomId { get; set; }

		string ItemDescription { get; set; }

		string Comments { get; set; }

		string CorrespondingPoId { get; set; }

		string StatusId { get; set; }

		string SyncStatusId { get; set; }

		DateTime? EstimatedShipDate { get; set; }

		DateTime? EstimatedDeliveryDate { get; set; }

		DateTime? AutoCancelDate { get; set; }

		DateTime? DontCancelSetDate { get; set; }

		string DontCancelSetBy { get; set; }

		DateTime? ShipBeforeDate { get; set; }

		DateTime? ShipAfterDate { get; set; }

		DateTime? CancelBackOrderDate { get; set; }

		string OverrideGlAccountId { get; set; }

		bool? Active { get; set; }

		// Outer Id:
		//string OrderId { get; set; }

	}

	public interface IOrderItemStateCreated : IOrderItemStateEvent//, IOrderItemStateProperties
	{
	
	}


	public interface IOrderItemStateMergePatched : IOrderItemStateEvent//, IOrderItemStateProperties
	{
		bool IsPropertyProductIdRemoved { get; set; }

		bool IsPropertyExternalProductIdRemoved { get; set; }

		bool IsPropertyQuantityRemoved { get; set; }

		bool IsPropertyCancelQuantityRemoved { get; set; }

		bool IsPropertySelectedAmountRemoved { get; set; }

		bool IsPropertyExternalIdRemoved { get; set; }

		bool IsPropertyOrderItemTypeIdRemoved { get; set; }

		bool IsPropertyOrderItemGroupSeqIdRemoved { get; set; }

		bool IsPropertyIsItemGroupPrimaryRemoved { get; set; }

		bool IsPropertyFromInventoryItemIdRemoved { get; set; }

		bool IsPropertyIsPromoRemoved { get; set; }

		bool IsPropertyQuoteIdRemoved { get; set; }

		bool IsPropertyQuoteItemSeqIdRemoved { get; set; }

		bool IsPropertyShoppingListIdRemoved { get; set; }

		bool IsPropertyShoppingListItemSeqIdRemoved { get; set; }

		bool IsPropertyUnitPriceRemoved { get; set; }

		bool IsPropertyUnitListPriceRemoved { get; set; }

		bool IsPropertyUnitAverageCostRemoved { get; set; }

		bool IsPropertyUnitRecurringPriceRemoved { get; set; }

		bool IsPropertyIsModifiedPriceRemoved { get; set; }

		bool IsPropertyRecurringFreqUomIdRemoved { get; set; }

		bool IsPropertyItemDescriptionRemoved { get; set; }

		bool IsPropertyCommentsRemoved { get; set; }

		bool IsPropertyCorrespondingPoIdRemoved { get; set; }

		bool IsPropertyStatusIdRemoved { get; set; }

		bool IsPropertySyncStatusIdRemoved { get; set; }

		bool IsPropertyEstimatedShipDateRemoved { get; set; }

		bool IsPropertyEstimatedDeliveryDateRemoved { get; set; }

		bool IsPropertyAutoCancelDateRemoved { get; set; }

		bool IsPropertyDontCancelSetDateRemoved { get; set; }

		bool IsPropertyDontCancelSetByRemoved { get; set; }

		bool IsPropertyShipBeforeDateRemoved { get; set; }

		bool IsPropertyShipAfterDateRemoved { get; set; }

		bool IsPropertyCancelBackOrderDateRemoved { get; set; }

		bool IsPropertyOverrideGlAccountIdRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}


}

