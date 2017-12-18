﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.Order
{

    public class OrderItemStates : IOrderItemStates
    {
        
		protected IOrderItemStateDao OrderItemStateDao
		{
			get
			{
				return ApplicationContext.Current["OrderItemStateDao"] as IOrderItemStateDao;
			}
		}

		private Dictionary<OrderItemId, IOrderItemState> _loadedOrderItemStates = new Dictionary<OrderItemId, IOrderItemState>();

		private Dictionary<OrderItemId, IOrderItemState> _removedOrderItemStates = new Dictionary<OrderItemId, IOrderItemState>();

		protected virtual IEnumerable<IOrderItemState> LoadedOrderItemStates {
			get {
				return this._loadedOrderItemStates.Values;
			}
		}

        private IOrderState _orderState;

        private IEnumerable<IOrderItemState> InnerEnumeralbe
        {
            get
            {
                if (!ForReapplying)
                {
                    return OrderItemStateDao.FindByOrderId(_orderState.OrderId);
                }
                else
                {
                    return _loadedOrderItemStates.Values.Where(s => !(_removedOrderItemStates.ContainsKey(s.GlobalId)));
                }
            }
        }

        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public OrderItemStates(IOrderState outerState)
        {
            this._orderState = outerState;
            this._forReapplying = outerState.ForReapplying;
        }

        public IEnumerator<IOrderItemState> GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        public virtual void Remove(IOrderItemState state)
        {
            this._removedOrderItemStates.Add(state.GlobalId, state);
        }

        public virtual IOrderItemState Get(string orderItemSeqId)
		{
			return Get(orderItemSeqId, false, false);
		}

        public virtual IOrderItemState Get(string orderItemSeqId, bool forCreation)
        {
			return Get(orderItemSeqId, forCreation, false);
        }

        public virtual IOrderItemState Get(string orderItemSeqId, bool forCreation, bool nullAllowed)
        {
            OrderItemId globalId = new OrderItemId(_orderState.OrderId, orderItemSeqId);
            if (_loadedOrderItemStates.ContainsKey(globalId)) {
                return _loadedOrderItemStates[globalId];
            }
            if (forCreation || ForReapplying)
            {
                var state = new OrderItemState(ForReapplying);
                state.OrderItemId = globalId;
                _loadedOrderItemStates.Add(globalId, state);
                return state;
            }
            else
            {
                var state = OrderItemStateDao.Get(globalId, nullAllowed);
                if (state != null)
                {
                    _loadedOrderItemStates.Add(globalId, state);
                }
                return state;
            }
        }

        public virtual void AddToSave(IOrderItemState state)
        {
            this._loadedOrderItemStates[state.GlobalId] = state;
        }

		#region Saveable Implements

		public virtual void Save ()
		{
			foreach (IOrderItemState s in this.LoadedOrderItemStates) {
                OrderItemStateDao.Save(s);
			}
            foreach(IOrderItemState s in this._removedOrderItemStates.Values)
            {
                OrderItemStateDao.Delete(s);
            }
		}

		#endregion


    }



}


