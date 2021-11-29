﻿using System.Collections.Generic;
using System.Linq;
using ChallengeHash.Business.Intefaces;

namespace ChallengeHash.Business.Notifications
{
    public class Notify : INotify
    {
        private readonly List<Notification> _notifications;

        public Notify()
        {
            _notifications = new List<Notification>();
        }

        public void Handle(Notification notification)
        {
            _notifications.Add(notification);
        }

        public List<Notification> GetNotifications()
        {
            return _notifications;
        }

        public bool HasNotification()
        {
            return _notifications.Any();
        }
    }
}