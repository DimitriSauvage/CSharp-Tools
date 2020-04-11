﻿using Microsoft.EntityFrameworkCore;
using Tools.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Infrastructure.Idempotency
{
    public class RequestManager<TContext> : IRequestManager 
        where TContext : DbContext
    {
        private readonly TContext _context;

        public RequestManager(TContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(TContext));
        }
        
        public async Task<bool> ExistAsync(Guid id)
        {
            var request = await _context.FindAsync<ClientRequest>(id);
            return request != null;
        }

        public async Task CreateRequestForCommandAsync<T>(Guid id)
        {
            var exists = await ExistAsync(id);

            var request = exists ?
                throw new ToolsException($"La requêtre portant l'id {id} existe déjà") :
                new ClientRequest()
                {
                    Id = id,
                    Name = typeof(T).Name,
                    Time = DateTime.UtcNow
                };

            _context.Add(request);

            await _context.SaveChangesAsync();
        }
    }
}