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

	public class MovementConfirmationLineStateEventIdDto
	{

		public MovementConfirmationLineStateEventIdDto()
		{
		}

        public virtual MovementConfirmationLineStateEventId ToMovementConfirmationLineStateEventId()
        {
            MovementConfirmationLineStateEventId v = new MovementConfirmationLineStateEventId();
            v.MovementDocumentNumber = this.MovementDocumentNumber;
            v.LineNumber = this.LineNumber;
            v.MovementVersion = this.MovementVersion;
            return v;
        }

		public virtual string MovementDocumentNumber { 
			get;
			set;
		}

		public virtual string LineNumber { 
			get;
			set;
		}

		public virtual long MovementVersion { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			MovementConfirmationLineStateEventIdDto other = obj as MovementConfirmationLineStateEventIdDto;
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

	}

}


