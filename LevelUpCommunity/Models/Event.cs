using System.ComponentModel.DataAnnotations;

namespace LevelUpCommunity.Models;

public class Event
{
    [Key]
    public int EventId { get; set; }

    [StringLength(35, MinimumLength = 10)]
    public required string EventName { get; set; }

    public required DateOnly EventDate { get; set; }
    
    public virtual List<MemberEvent>? MemberEvents { get; set; }
}