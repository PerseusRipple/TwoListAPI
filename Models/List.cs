using System;

namespace TwoListAPI.Models
{
  public class List
  {
    public int Id { get; set; }

    public string ListItem { get; set; }

    public bool IsDone { get; set; } = false;

    public bool IsDueToday { get; set; } = true;

    public DateTime? DateOfCompletion { get; set; } = null;
  }
}