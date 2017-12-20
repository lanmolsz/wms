﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.Movement
{

	public class MovementLineId
	{

		private string _movementDocumentNumber;

		public virtual string MovementDocumentNumber { 
			get { return this._movementDocumentNumber; } 
			internal set { _movementDocumentNumber = value; } 
		}

		private string _lineNumber;

		public virtual string LineNumber { 
			get { return this._lineNumber; } 
			internal set { _lineNumber = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal MovementLineId ()
		{
		}

		public MovementLineId (string movementDocumentNumber, string lineNumber)
		{
			this._movementDocumentNumber = movementDocumentNumber;
			this._lineNumber = lineNumber;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			MovementLineId other = obj as MovementLineId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.MovementDocumentNumber, other.MovementDocumentNumber)
				&& Object.Equals (this.LineNumber, other.LineNumber)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.MovementDocumentNumber != null) {
				hash += 13 * this.MovementDocumentNumber.GetHashCode ();
			}
			if (this.LineNumber != null) {
				hash += 13 * this.LineNumber.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(MovementLineId obj1, MovementLineId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(MovementLineId obj1, MovementLineId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}


