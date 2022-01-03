using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.EntityFrameworkCore.Frameworks.Base
{
    public class BaseRepository<D_DbContext, E_Entity, P_PrimaryKey> : Domain.Contract.Abstracts.IRepository<E_Entity, P_PrimaryKey>
         where E_Entity : class
         where D_DbContext : IdentityDbContext<ApplicationUser>
    {
        #region [-Ctor-]
        public BaseRepository(D_DbContext context)
        {
            Context = context;
            DbSet = context.Set<E_Entity>();
        }
        #endregion

        #region [-Props-]
        public D_DbContext Context { get; set; }
        public DbSet<E_Entity> DbSet { get; set; }
        #endregion

        #region [-Tasks-]

        #region [-DeleteAsync(P_PrimaryKey id)-]
        public virtual async Task DeleteAsync(P_PrimaryKey id)
        {
            var target = await DbSet.FindAsync(id);
            Context.Entry(target).State = EntityState.Deleted;
            await SaveChanges();
        }
        #endregion

        #region [-DeleteAsync(E_Entity entity)-]
        public virtual async Task DeleteAsync(E_Entity entity)
        {
            if (Context.Entry(entity).State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            DbSet.Remove(entity);
            await SaveChanges();
        }
        #endregion

        #region [-FindByIdAsync(P_PrimaryKey id)-]
        public virtual async Task<E_Entity> FindByIdAsync(P_PrimaryKey id)
        {
            var target = await DbSet.FindAsync(id);
            return target;
        }
        #endregion

        #region [-InsertAsync(E_Entity entity)-]
        public virtual async Task InsertAsync(E_Entity entity)
        {
            await DbSet.AddAsync(entity);
            await SaveChanges();
        }
        #endregion

        #region [-Async-SaveChanges()-]
        public async Task SaveChanges()
        {
            await Context.SaveChangesAsync();
        }
        #endregion

        #region [-Select()-]
        public virtual async Task<List<E_Entity>> Select()
        {
            var q = await DbSet.AsNoTracking().ToListAsync();
            return q;
        }
        #endregion

        #region [-UpdateAsync(E_Entity entity)-]
        public virtual async Task UpdateAsync(E_Entity entity)
        {
            DbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
            await SaveChanges();
        }
        #endregion


        #endregion















    }
}
