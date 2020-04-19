﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tools.Domain.Abstractions;

namespace Tools.Infrastructure.EntityFramework.Abstractions
{
    /// <summary>
    /// Map class for a composite id entity
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public class EntityWithCompositeIdMap<TEntity> : EntityMap<TEntity>, IEntityTypeConfiguration<TEntity>
        where TEntity : class, IEntityWithCompositeId
    {
        /// <inheritdoc />
        public new virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
        }
    }
}