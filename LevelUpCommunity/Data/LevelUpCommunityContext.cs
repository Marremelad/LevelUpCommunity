using Microsoft.EntityFrameworkCore;

namespace LevelUpCommunity.Data;

public class LevelUpCommunityContext : DbContext
{
    public LevelUpCommunityContext(DbContextOptions<LevelUpCommunityContext> options) : base(options)
    {
        
    }
}