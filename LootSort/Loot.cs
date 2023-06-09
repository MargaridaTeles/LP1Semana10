using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace LootSort
{
    /// <summary>
    /// The Loot class should implement IComparable<Loot>
    /// and override GetHashCode() and Equals()
    /// </summary>
    public class Loot : IComparable<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }

        /// <summary>
        /// Create a new instance of loot.
        /// </summary>
        /// <param name="kind">Type of loot.</param>
        /// <param name="description">Loot description.</param>
        /// <param name="value">Loot value.</param>
        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }

        public int CompareTo(Loot other)
        {
            if (other == null) return 1;

            if (Kind == other.Kind)
            {
                if (Value == other.Value)
                {
                    return (string.Compare(Description, other.Description));
                }
                else
                {
                    return (int)(other.Value - Value);
                }
            }
            else
            {
                return (string.Compare(Kind.ToString(), other.Kind.ToString()));
            }
        }

        public override int GetHashCode()
        {
            return  Kind.GetHashCode() 
                    ^ Value.GetHashCode() 
                    ^ Description.GetHashCode();
        }

        public override bool Equals(object other)
        {
            return Kind.Equals((other as Loot).Kind)
                    &&
                    Kind.Equals((other as Loot).Kind)
                    &&
                    Description.Equals((other as Loot).Description);
        }

        /// <summary>
        /// Return a nicely formatted string representing the loot instance.
        /// </summary>
        /// <returns>
        /// A nicely formatted string representing the loot instance.
        /// </returns>
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";
    }
}