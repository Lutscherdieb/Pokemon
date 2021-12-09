using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// An `AtomFunction&lt;int, int&gt;` that clamps the value using a min and a max value and returns it.
    /// </summary>
    [EditorIcon("atom-icon-sand")]
    [CreateAssetMenu(menuName = "Unity Atoms/Functions/Transformers/Event on MinMax", fileName = "MinMaxEvent")]
    public class EventOnMinMax : IntIntFunction, IIsValid
    {
        /// <summary>
        /// The minimum value.
        /// </summary>
        public IntReference Min;

        /// <summary>
        /// The maximum value.
        /// </summary>
        public IntReference Max;
        /// <summary>
        /// The minimum value.
        /// </summary>
        public VoidEvent MinEvent;
        /// <summary>
        /// The minimum value.
        /// </summary>
        public VoidEvent MaxEvent;

        public override int Call(int value){
            if (!IsValid()) { throw new Exception("Either( MinEvent & MinValue) or (MaxEvent & MaxValue) needed."); }
            if(value <= Min.Value && MinEvent){MinEvent.Raise();}
            if(value >= Max.Value && MaxEvent){MaxEvent.Raise();}
            return value;
        }

        public bool IsValid(){
            return !Min.IsUnassigned && MinEvent || !Max.IsUnassigned && MaxEvent;
        }
    }
}
