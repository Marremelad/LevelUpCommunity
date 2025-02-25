using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LevelUpCommunity.Models;

public class MemberEvent
{
    [Key]
    public int MemberEventId { get; set; }

    [ForeignKey("Member")]
    public required int MemberIdFk { get; set; }
    public virtual required Member Member { get; set; }
    
    [ForeignKey("Event")]
    public required int EventIdFk { get; set; }
    public virtual required Event Event { get; set; }
}