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

	public class MovementLineStateEventId
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

		private long _movementVersion;

		public virtual long MovementVersion { 
			get { return this._movementVersion; } 
			internal set { _movementVersion = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal MovementLineStateEventId ()
		{
		}

		public MovementLineStateEventId (string movementDocumentNumber, string lineNumber, long movementVersion)
		{
			this._movementDocumentNumber = movementDocumentNumber;
			this._lineNumber = lineNumber;
			this._movementVersion = movementVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			MovementLineStateEventId other = obj as MovementLineStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.MovementDocumentNumber, other.MovementDocumentNumber)
				&& Object.Equals (this.LineNumber, other.LineNumber)
				&& Object.Equals (this.MovementVersion, other.MovementVersion)
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
			if (this.MovementVersion != null) {
				hash += 13 * this.MovementVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(MovementLineStateEventId obj1, MovementLineStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(MovementLineStateEventId obj1, MovementLineStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}


