﻿using Library.Models;

namespace AnnouncementApi.Repositories.Interfaces;

public interface IAnnouncementRepository
{
    public Task<ICollection<Announcement>> GetAsync(Guid? subcategoryId);
    public Task CreateAsync(Announcement announcement);
    public Task UpdateAsync(Announcement announcement);
    public Task DeleteAsync(Guid id);
}