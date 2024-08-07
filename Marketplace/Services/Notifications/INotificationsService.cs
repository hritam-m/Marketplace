using Marketplace.Models.Notification;

namespace Marketplace.Services;

public interface INotificationsService
{
    Task<IEnumerable<NotificationModel>> GetNotifications();
    Task<IEnumerable<NotificationModel>> GetActiveNotifications();
}