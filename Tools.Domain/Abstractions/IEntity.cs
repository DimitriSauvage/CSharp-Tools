﻿using System;
using System.Collections.Generic;
using System.Text;
using Tools.Domain.Extensions;

namespace Tools.Domain.Abstractions
{
    public interface IEntity
    {
        /// <summary>
        /// Recopie l'ensemble des propriétés simples (membres par valeur).
        /// Ne recopie par les champs qui composent la clé unique ainsi que l'identifiant.
        /// </summary>
        /// <param name="other">objet à recopier</param>
        /// <returns>Copie</returns>
        void CopyFrom(IEntity other);
    }

    public interface IEntityWithId<TId> : IEntity
    {
        TId Id { get; set; }
    }

    public interface IEntityWithId : IEntityWithId<long>
    {

    }

    public interface IEntityWithCompositeId : IEntity
    {

    }

    public interface IEntityWithTracking : IEntityWithId<long>
    {
        DateTime CreatedAt { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedAt { get; set; }
        string UpdatedBy { get; set; }
    }

    
}