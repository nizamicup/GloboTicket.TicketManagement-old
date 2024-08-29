using System;
using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GloboTicket.TicketManagement.Persistence.Repositories;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(GloboTicketDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<IReadOnlyList<Category>> GetCategoriesWithEvents(bool includeHistory)
    {
        var allCategories = await _dbContext.Categories.Include(x => x.Events).ToListAsync();
        if (!includeHistory)
        {
            allCategories.ForEach(p => p.Events.ToList().RemoveAll(c => c.Date < DateTime.Today));
        }

        return allCategories;
    }
}
