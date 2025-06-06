using System.Collections.Concurrent;
using EventEaseAppBlazor.Models;

namespace EventEaseAppBlazor.Services
{
    public class UserSessionService
    {
        private readonly ConcurrentDictionary<string, UserSession> _sessions = new();

        public void StartSession(int eventId, string userId)
        {
            var key = $"{userId}-{eventId}";
            var session = new UserSession
            {
                Id = Guid.NewGuid().GetHashCode(),
                EventId = eventId,
                UserId = userId,
                JoinTime = DateTime.Now
            };
            _sessions[key] = session;
        }

        public void EndSession(int eventId, string userId)
        {
            var key = $"{userId}-{eventId}";
            if (_sessions.TryGetValue(key, out var session))
            {
                session.LeaveTime = DateTime.Now;
            }
        }

        public IEnumerable<UserSession> GetSessionsForEvent(int eventId)
            => _sessions.Values.Where(s => s.EventId == eventId);

        public IEnumerable<UserSession> GetSessionsForUser(string userId)
            => _sessions.Values.Where(s => s.UserId == userId);

        public IEnumerable<UserSession> GetAllSessions()
            => _sessions.Values;
    }
}