namespace EventEaseAppBlazor.Models
{
    public class UserSession
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public DateTime JoinTime { get; set; }
        public DateTime? LeaveTime { get; set; }
        public bool IsActive => LeaveTime == null;
    }
}