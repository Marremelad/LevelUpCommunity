using LevelUpCommunity.Models;
using Microsoft.EntityFrameworkCore;

namespace LevelUpCommunity.Data;

public class LevelUpCommunityContext : DbContext
{
    public LevelUpCommunityContext(DbContextOptions<LevelUpCommunityContext> options) : base(options)
    {
        
    }

    public DbSet<Member> Members { get; set; }

    public DbSet<Event> Events { get; set; }

    public DbSet<MemberEvent> MemberEvents { get; set; }
}