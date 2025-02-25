using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace LevelUpCommunity.Models;

public class Member
{
    [Key]
    public int MemberId { get; set; }
    
    [StringLength(35, MinimumLength = 1)]
    public required string MemberName { get; set; }

    [StringLength(254)]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")]
    public required string MemberEmail { get; set; }
    
    public virtual List<MemberEvent>? MemberEvents { get; set; }
}