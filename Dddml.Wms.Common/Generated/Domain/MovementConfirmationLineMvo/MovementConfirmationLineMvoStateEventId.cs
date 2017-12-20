﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmationLineMvo;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.MovementConfirmationLineMvo
{

	public class MovementConfirmationLineMvoStateEventId
	{

		private MovementConfirmationLineId _movementConfirmationLineId = new MovementConfirmationLineId();

		public virtual MovementConfirmationLineId MovementConfirmationLineId { 
			get { return this._movementConfirmationLineId; } 
			internal set { _movementConfirmationLineId = value; } 
		}

		private long _movementVersion;

		public virtual long MovementVersion { 
			get { return this._movementVersion; } 
			internal set { _movementVersion = value; } 
		}


        #region  Flattened Properties


		public virtual string MovementConfirmationLineIdMovementDocumentNumber {
			get { return MovementConfirmationLineId.MovementDocumentNumber; }
			internal set { MovementConfirmationLineId.MovementDocumentNumber = value; }
		}

		public virtual string MovementConfirmationLineIdLineNumber {
			get { return MovementConfirmationLineId.LineNumber; }
			internal set { MovementConfirmationLineId.LineNumber = value; }
		}

        #endregion

		internal MovementConfirmationLineMvoStateEventId ()
		{
		}

		public MovementConfirmationLineMvoStateEventId (MovementConfirmationLineId movementConfirmationLineId, long movementVersion)
		{
			this._movementConfirmationLineId = movementConfirmationLineId;
			this._movementVersion = movementVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			MovementConfirmationLineMvoStateEventId other = obj as MovementConfirmationLineMvoStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.MovementConfirmationLineId, other.MovementConfirmationLineId)
				&& Object.Equals (this.MovementVersion, other.MovementVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.MovementConfirmationLineId != null) {
				hash += 13 * this.MovementConfirmationLineId.GetHashCode ();
			}
			if (this.MovementVersion != null) {
				hash += 13 * this.MovementVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(MovementConfirmationLineMvoStateEventId obj1, MovementConfirmationLineMvoStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(MovementConfirmationLineMvoStateEventId obj1, MovementConfirmationLineMvoStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}


