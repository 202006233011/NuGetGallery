﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace NuGetGallery
{
    public interface IDatabase
    {
        IDbContextTransaction BeginTransaction();

        DbConnection Connection { get; }

        DbRawSqlQuery<TElement> SqlQuery<TElement>(string sql, params object[] parameters);

        Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters);

        Task<int> ExecuteSqlResourceAsync(string name, params object[] parameters);
    }
}
