﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;

namespace BriefFiniteElementNet.Sections
{
    [Serializable]
    public abstract class Base2DSection:ISerializable
    {
        public abstract double GetThicknessAt(params double[] isoCoords);

        public abstract int[] GetMaxFunctionOrder();

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //base.GetObjectData(info, context);
        }

        protected Base2DSection(SerializationInfo info, StreamingContext context)
        {
            //base.GetObjectData(info, context);
        }

        public Base2DSection()
        {

        }
    }
}