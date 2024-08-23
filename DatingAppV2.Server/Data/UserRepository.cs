using AutoMapper;
using AutoMapper.QueryableExtensions;
using DatingAppV2.Server.DTOs;
using DatingAppV2.Server.Entities;
using DatingAppV2.Server.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DatingAppV2.Server.Data;

public class UserRepository(DataContext context, IMapper mapper) : IUserRepository
{
    private readonly DataContext context = context;
    private readonly IMapper mapper = mapper;

    public async Task<MemberDto?> GetMemberAsync(string username)
    {
        return await context.Users.Where(x => x.UserName == username).ProjectTo<MemberDto>(mapper.ConfigurationProvider)
            .SingleOrDefaultAsync();
    }

    public async Task<IEnumerable<MemberDto>> GetMembersAsync()
    {
        return await context.Users.ProjectTo<MemberDto>(mapper.ConfigurationProvider).ToListAsync();
    }

    public async Task<AppUser?> GetUserByIdAsync(int id)
    {
        return await context.Users.FindAsync(id);
    }

    public async Task<AppUser?> GetUserByNameAsync(string username)
    {
        return await context.Users.Include(x => x.Photos)
            .SingleOrDefaultAsync(x => x.UserName == username);
    }

    public async Task<IEnumerable<AppUser>> GetUsersAsync()
    {
        return await context.Users.Include(x => x.Photos).ToListAsync();
    }

    public async Task<bool> SaveAllAsync()
    {
        return await context.SaveChangesAsync() > 0;
    }

    public void Update(AppUser user)
    {
        context.Entry(user).State = EntityState.Modified;
    }
}