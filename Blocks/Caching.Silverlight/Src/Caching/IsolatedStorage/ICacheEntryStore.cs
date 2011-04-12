﻿using System.Collections.Generic;

namespace Microsoft.Practices.EnterpriseLibrary.Caching.IsolatedStorage
{
    /// <summary>
    /// Manages the storage and retrieval of cache entries.
    /// </summary>
    public interface ICacheEntryStore
    {
        /// <summary>
        /// Gets a value indicating whether this instance is writable.
        /// </summary>
        bool IsWritable { get; }

        /// <summary>
        /// Gets the quota allowed for the store.
        /// </summary>
        long Quota { get; }

        /// <summary>
        /// Gets an estimate of the physical size used by the store.
        /// </summary>
        long UsedPhysicalSize { get; }

        /// <summary>
        /// Stores a new entry.
        /// </summary>
        /// <param name="entry">The entry to add.</param>
        void Add(IsolatedStorageCacheEntry entry);

        /// <summary>
        /// Removes an entry from storage.
        /// </summary>
        /// <param name="entry">The entry to remove.</param>
        void Remove(IsolatedStorageCacheEntry entry);

        /// <summary>
        /// Updates the last access time for the entry in storage.
        /// </summary>
        /// <param name="entry">The entry to update.</param>
        void UpdateLastUpdateTime(IsolatedStorageCacheEntry entry);

        /// <summary>
        /// Retrieves all the entries currently stored by the store.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IsolatedStorageCacheEntry> GetSerializedEntries();
    }
}
