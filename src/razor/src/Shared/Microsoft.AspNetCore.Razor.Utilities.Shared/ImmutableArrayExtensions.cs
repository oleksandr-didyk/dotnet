﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

namespace System.Collections.Immutable;

/// <summary>
/// <see cref="ImmutableArray{T}"/> extension methods
/// </summary>
internal static class ImmutableArrayExtensions
{
    /// <summary>
    /// Returns an empty array if the input array is null (default)
    /// </summary>
    public static ImmutableArray<T> NullToEmpty<T>(this ImmutableArray<T> array)
    {
        return array.IsDefault ? ImmutableArray<T>.Empty : array;
    }

    public static void SetCapacityIfNeeded<T>(this ImmutableArray<T>.Builder builder, int newCapacity)
    {
        if (builder.Capacity < newCapacity)
        {
            builder.Capacity = newCapacity;
        }
    }
}
