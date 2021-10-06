using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TP.Infrastructure.Common.Extensions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Checks whatever given collection object is null or has no item.
        /// </summary>
        public static bool IsNullOrEmpty<T>(this ICollection<T> source)
        {
            return source == null || source.Count <= 0;
        }

        /// <summary>
        /// Adds an item to the collection if it's not already in the collection.
        /// </summary>
        /// <param name="source">Collection</param>
        /// <param name="item">Item to check and add</param>
        /// <typeparam name="T">Type of the items in the collection</typeparam>
        /// <returns>Returns True if added, returns False if not.</returns>
        public static bool AddIfNotContains<T>(this ICollection<T> source, T item)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (source.Contains(item))
            {
                return false;
            }

            source.Add(item);
            return true;
        }
        
        public static IEnumerable<T> Add<T>(this IEnumerable<T> collection, T item)
        {
            foreach (var c in collection)
            {
                yield return c;
            }

            yield return item;
        }

        /// <summary>
        /// Add a range of items to a collection.
        /// </summary>
        /// <typeparam name="T">Type of objects within the collection.</typeparam>
        /// <param name="collection">The collection to add items to.</param>
        /// <param name="items">The items to add to the collection.</param>
        /// <returns>The collection.</returns>
        /// <exception cref="ArgumentNullException">An <see cref="System.ArgumentNullException"/> is thrown if <paramref name="collection"/> or <paramref name="items"/> is <see langword="null"/>.</exception>
        public static Collection<T> AddRange<T>(this Collection<T> collection, IEnumerable<T> items)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            foreach (var each in items)
            {
                collection.Add(each);
            }

            return collection;
        }

        public static IEnumerable<long> ToListOfLong(this string[] array)
        {
            foreach (var a in array)
                yield return Convert.ToInt64(a);
        }
    }
}
