﻿// Copyright (c) Philipp Wagner. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using NpgsqlTypes;
using System;

namespace PostgreSQLCopyHelper.Extensions
{
    public static class DateTimeTypeExtensions
    {
        public static PostgreSQLCopyHelper<TEntity> MapDate<TEntity>(this PostgreSQLCopyHelper<TEntity> helper, string columnName, Func<TEntity, DateTime> propertyGetter)
        {
            return helper.Map(columnName, propertyGetter, NpgsqlDbType.Date);
        }

        public static PostgreSQLCopyHelper<TEntity> MapDate<TEntity>(this PostgreSQLCopyHelper<TEntity> helper, string columnName, Func<TEntity, DateTime?> propertyGetter)
        {
            return helper.Map(columnName, propertyGetter, NpgsqlDbType.Date);
        }

        public static PostgreSQLCopyHelper<TEntity> MapTime<TEntity>(this PostgreSQLCopyHelper<TEntity> helper, string columnName, Func<TEntity, DateTime> propertyGetter)
        {
            return helper.Map(columnName, propertyGetter, NpgsqlDbType.Time);
        }

        public static PostgreSQLCopyHelper<TEntity> MapTime<TEntity>(this PostgreSQLCopyHelper<TEntity> helper, string columnName, Func<TEntity, DateTime?> propertyGetter)
        {
            return helper.Map(columnName, propertyGetter, NpgsqlDbType.Time);
        }

        public static PostgreSQLCopyHelper<TEntity> MapTimeWithTimeZone<TEntity>(this PostgreSQLCopyHelper<TEntity> helper, string columnName, Func<TEntity, DateTime> propertyGetter)
        {
            return helper.Map(columnName, propertyGetter, NpgsqlDbType.Time);
        }

        public static PostgreSQLCopyHelper<TEntity> MapTimeWithTimeZone<TEntity>(this PostgreSQLCopyHelper<TEntity> helper, string columnName, Func<TEntity, DateTime?> propertyGetter)
        {
            return helper.Map(columnName, propertyGetter, NpgsqlDbType.Time);
        }

        public static PostgreSQLCopyHelper<TEntity> MapTimeStamp<TEntity>(this PostgreSQLCopyHelper<TEntity> helper, string columnName, Func<TEntity, DateTime> propertyGetter)
        {
            return helper.Map(columnName, propertyGetter, NpgsqlDbType.Timestamp);
        }

        public static PostgreSQLCopyHelper<TEntity> MapTimeStamp<TEntity>(this PostgreSQLCopyHelper<TEntity> helper, string columnName, Func<TEntity, DateTime?> propertyGetter)
        {
            return helper.Map(columnName, propertyGetter, NpgsqlDbType.Timestamp);
        }

        public static PostgreSQLCopyHelper<TEntity> MapTimeStampWithTimeZone<TEntity>(this PostgreSQLCopyHelper<TEntity> helper, string columnName, Func<TEntity, DateTime> propertyGetter)
        {
            return helper.Map(columnName, propertyGetter, NpgsqlDbType.TimestampTZ);
        }

        public static PostgreSQLCopyHelper<TEntity> MapTimeStampWithTimeZone<TEntity>(this PostgreSQLCopyHelper<TEntity> helper, string columnName, Func<TEntity, DateTime?> propertyGetter)
        {
            return helper.Map(columnName, propertyGetter, NpgsqlDbType.TimestampTZ);
        }

        public static PostgreSQLCopyHelper<TEntity> MapInterval<TEntity>(this PostgreSQLCopyHelper<TEntity> helper, string columnName, Func<TEntity, TimeSpan> propertyGetter)
        {
            return helper.Map(columnName, propertyGetter, NpgsqlDbType.Interval);
        }

        public static PostgreSQLCopyHelper<TEntity> MapInterval<TEntity>(this PostgreSQLCopyHelper<TEntity> helper, string columnName, Func<TEntity, TimeSpan?> propertyGetter)
        {
            return helper.Map(columnName, propertyGetter, NpgsqlDbType.Interval);
        }
    }
}