using System.Collections.Generic;
using ChallengeHash.Business.Notifications;

namespace ChallengeHash.Business.Intefaces
{
    public interface INotify
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}