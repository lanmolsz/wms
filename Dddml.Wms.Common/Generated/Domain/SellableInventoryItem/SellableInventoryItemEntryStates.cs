﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItem
{

    public class SellableInventoryItemEntryStates : ISellableInventoryItemEntryStates
    {
        
		protected ISellableInventoryItemEntryStateDao SellableInventoryItemEntryStateDao
		{
			get
			{
				return ApplicationContext.Current["SellableInventoryItemEntryStateDao"] as ISellableInventoryItemEntryStateDao;
			}
		}

		private Dictionary<SellableInventoryItemEntryId, ISellableInventoryItemEntryState> _loadedSellableInventoryItemEntryStates = new Dictionary<SellableInventoryItemEntryId, ISellableInventoryItemEntryState>();

		private Dictionary<SellableInventoryItemEntryId, ISellableInventoryItemEntryState> _removedSellableInventoryItemEntryStates = new Dictionary<SellableInventoryItemEntryId, ISellableInventoryItemEntryState>();

		protected virtual IEnumerable<ISellableInventoryItemEntryState> LoadedSellableInventoryItemEntryStates {
			get {
				return this._loadedSellableInventoryItemEntryStates.Values;
			}
		}

        private ISellableInventoryItemState _sellableInventoryItemState;

        private IEnumerable<ISellableInventoryItemEntryState> InnerEnumeralbe
        {
            get
            {
                if (!ForReapplying)
                {
                    return SellableInventoryItemEntryStateDao.FindBySellableInventoryItemId(_sellableInventoryItemState.SellableInventoryItemId);
                }
                else
                {
                    return _loadedSellableInventoryItemEntryStates.Values.Where(s => !(_removedSellableInventoryItemEntryStates.ContainsKey(s.GlobalId) && s.Deleted));
                }
            }
        }

        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public SellableInventoryItemEntryStates(ISellableInventoryItemState outerState)
        {
            this._sellableInventoryItemState = outerState;
            this._forReapplying = outerState.ForReapplying;
        }

        public IEnumerator<ISellableInventoryItemEntryState> GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        public virtual void Remove(ISellableInventoryItemEntryState state)
        {
            this._removedSellableInventoryItemEntryStates.Add(state.GlobalId, state);
        }

        public virtual ISellableInventoryItemEntryState Get(long entrySeqId)
		{
			return Get(entrySeqId, false, false);
		}

        public virtual ISellableInventoryItemEntryState Get(long entrySeqId, bool forCreation)
        {
			return Get(entrySeqId, forCreation, false);
        }

        public virtual ISellableInventoryItemEntryState Get(long entrySeqId, bool forCreation, bool nullAllowed)
        {
            SellableInventoryItemEntryId globalId = new SellableInventoryItemEntryId(_sellableInventoryItemState.SellableInventoryItemId, entrySeqId);
            if (_loadedSellableInventoryItemEntryStates.ContainsKey(globalId)) {
                return _loadedSellableInventoryItemEntryStates[globalId];
            }
            if (forCreation || ForReapplying)
            {
                var state = new SellableInventoryItemEntryState(ForReapplying);
                state.SellableInventoryItemEntryId = globalId;
                _loadedSellableInventoryItemEntryStates.Add(globalId, state);
                return state;
            }
            else
            {
                var state = SellableInventoryItemEntryStateDao.Get(globalId, nullAllowed);
                if (state != null)
                {
                    _loadedSellableInventoryItemEntryStates.Add(globalId, state);
                }
                return state;
            }
        }

        public virtual void AddToSave(ISellableInventoryItemEntryState state)
        {
            this._loadedSellableInventoryItemEntryStates[state.GlobalId] = state;
        }

		#region Saveable Implements

		public virtual void Save ()
		{
			foreach (ISellableInventoryItemEntryState s in this.LoadedSellableInventoryItemEntryStates) {
                SellableInventoryItemEntryStateDao.Save(s);
			}
            foreach(ISellableInventoryItemEntryState s in this._removedSellableInventoryItemEntryStates.Values)
            {
                SellableInventoryItemEntryStateDao.Delete(s);
            }
		}

		#endregion


    }



}


