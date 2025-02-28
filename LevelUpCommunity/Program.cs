using LevelUpCommunity.Data;
using Microsoft.EntityFrameworkCore;

namespace LevelUpCommunity;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddAuthorization();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<LevelUpCommunityContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        // Returns all members in the database.
        app.MapGet("/members", async (LevelUpCommunityContext context) => await context.Members.ToListAsync());
        
        // Returns all events in the database.
        app.MapGet("/events", async (LevelUpCommunityContext context) => await context.Events.ToListAsync());
        
        // Returns all participants of an event.
        app.MapGet("/member-events/{id:int}", async (LevelUpCommunityContext context, int id) =>
        {
            var eventParticipants = await context.MemberEvents
                .Where(me => me.EventIdFk == id)
                .Include(me => me.Member)
                .Include(me => me.Event)
                .GroupBy(me => me.EventIdFk)
                .Select(group => new
                {
                    eventName = group.First().Event.EventName,
                    eventParticipants = group.Select(me => me.Member.MemberName).ToList()
                })
                .FirstOrDefaultAsync();

            return eventParticipants;
        });
        
        app.Run();
    }
}