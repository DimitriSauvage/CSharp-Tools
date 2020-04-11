﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Tools.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Infrastructure.Abstraction
{
    public interface IRepository<TEntity> : IRepository<TEntity, long>
        where TEntity : class
    {
    }

        public interface IRepository<TEntity, TId>
        where TEntity : class
    {
        DbContext Context { get; set; }

        /// <summary>
        /// Débute une transaction
        /// </summary>
        /// <returns></returns>
        IDbContextTransaction BeginTransaction();
        /// <summary>
        /// Obtient la liste de tous les <typeparamref name="TEntity"/>
        /// </summary>
        /// <returns></returns>
        ICollection<TEntity> List();
        /// <summary>
        /// Obtient la liste de tous les <typeparamref name="TEntity"/>
        /// </summary>
        /// <returns></returns>
        Task<ICollection<TEntity>> ListAsync();
        /// <summary>
        /// Obtient un <typeparamref name="TEntity"/> depuis son id
        /// </summary>
        /// <param name="id">Identifiant unique</param>
        /// <returns></returns>
        TEntity GetById(TId id);
        /// <summary>
        /// Obtient un <typeparamref name="TEntity"/> depuis son id
        /// </summary>
        /// <param name="id">Identifiant unique</param>
        /// <returns></returns>
        Task<TEntity> GetByIdAsync(TId id);
        /// <summary>
        /// Effectue un select de type <typeparamref name="TEntity"/>, la clause where sera passée en paramètre grâce à un prédicat
        /// </summary>
        /// <param name="predicate">Prédicat de sélection</param>
        /// <returns></returns>
        ICollection<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// Effectue un select de type <typeparamref name="TEntity"/>, la clause where sera passée en paramètre grâce à un prédicat
        /// </summary>
        /// <param name="predicate">Prédicat de sélection</param>
        /// <returns></returns>
        Task<ICollection<TEntity>> FindByAsync(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// Effectue un comptage des éléments de type <typeparamref name="TEntity"/>, la clause where sera passée en paramètre grâce à un prédicat
        /// </summary>
        /// <param name="predicate">Prédicat de sélection</param>
        /// <returns>Le nombre d'éléments</returns>
        int CountBy(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// Effectue un comptage des éléments de type <typeparamref name="TEntity"/>, la clause where sera passée en paramètre grâce à un prédicat
        /// </summary>
        /// <param name="predicate">Prédicat de sélection</param>
        /// <returns>Le nombre d'éléments</returns>
        Task<int> CountByAsync(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// Ajout un objet transiant de type <typeparamref name="TEntity"/>
        /// </summary>
        /// <param name="entity">Objet transiant</param>
        TEntity Add(TEntity entity);
        /// <summary>
        /// Ajout un objet transiant de type <typeparamref name="TEntity"/>
        /// </summary>
        /// <param name="entity">Objet transiant</param>
        Task<TEntity> AddAsync(TEntity entity);
        /// <summary>
        /// Attache une entité de type <typeparamref name="TEntity"/> au contexte actuel
        /// </summary>
        /// <param name="entity"></param>
        void Attach(TEntity entity);
        /// <summary>
        /// Attache une collection d'entités de type <typeparamref name="TEntity"/> au contexte actuel
        /// </summary>
        /// <param name="entities"></param>
        void Attach(IEnumerable<TEntity> entities);
        /// <summary>
        /// Supprime un objet de type <typeparamref name="TEntity"/>
        /// </summary>
        /// <param name="entity"></param>
        int Delete(TEntity entity);
        /// <summary>
        /// Supprime un objet de type <typeparamref name="TEntity"/>
        /// </summary>
        /// <param name="entity"></param>
        Task<int> DeleteAsync(TEntity entity);
        /// <summary>
        /// Marque l'objet de type <typeparamref name="TEntity"/> commme étant modifié
        /// </summary>
        /// <param name="entity"></param>
        void Edit(TEntity entity);
        /// <summary>
        /// Envoi en base de données les modifications
        /// </summary>
        void Save();
        /// <summary>
        /// Génère un objet requêtable
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> Query();
        /// <summary>
        /// Obtient une <see cref="TEntity"/> depuis les propriétés qui composent sa clé unique
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task<TEntity> GetByUniqueKeyAsync(TEntity obj);
        /// <summary>
        /// Obtient une <see cref="TEntity"/> depuis les propriétés qui composent sa clé unique
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        TEntity GetByUniqueKey(TEntity obj);
    }
}