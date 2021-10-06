using System;
using System.Collections.Generic;

namespace TP.Infrastructure.Common.Entities
{
    public abstract class EntityBase<TPrimaryKey>
    {

        public virtual TPrimaryKey Id { get; set; }

        /// <summary>
        /// Checks if this entity is transient (it has not an Id).
        /// </summary>
        /// <returns>True, if this entity is transient</returns>
        public virtual bool IsTransient()
        {
            if (EqualityComparer<TPrimaryKey>.Default.Equals(Id, default(TPrimaryKey)))
            {
                return true;
            }

            //Workaround for EF Core since it sets int/long to min value when attaching to dbcontext
            if (typeof(TPrimaryKey) == typeof(int))
            {
                return Convert.ToInt32(Id) <= 0;
            }

            if (typeof(TPrimaryKey) == typeof(long))
            {
                return Convert.ToInt64(Id) <= 0;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static bool IsTransient(EntityBase<TPrimaryKey> obj)
        {
            return obj != null && Equals(obj.Id, default(TPrimaryKey));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as EntityBase<TPrimaryKey>);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public virtual bool Equals(EntityBase<TPrimaryKey> other)
        {
            if (other == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (!IsTransient(this) && !IsTransient(other) && Equals(Id, other.Id))
            {
                Type otherType = other.GetUnproxiedType();

                Type thisType = GetUnproxiedType();

                return thisType.IsAssignableFrom(otherType) || otherType.IsAssignableFrom(thisType);
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            if (Equals(Id, default(TPrimaryKey)))
            {
                return base.GetHashCode();
            }

            return Id.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Type GetUnproxiedType()
        {
            return GetType();
        }
    }
}
