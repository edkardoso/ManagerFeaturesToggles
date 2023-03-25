using edk.Fusc.Contracts;
using edk.ManagerFeaturesToggles.Domain.Entities.Common;
using FluentValidation.Results;

namespace edk.ManagerFeatureToogles.Application.Common;
public static class NotificationCollectionExtension
{
    public static bool HasError(this List<Notification> notifications)
        => notifications.Any(n => n.Severity.Equals(SeverityType.Error));

    public static bool HasWarning(this List<Notification> notifications)
        => notifications.Any(n => n.Severity.Equals(SeverityType.Warning));

    public static bool HasInfo(this List<Notification> notifications)
       => notifications.Any(n => n.Severity.Equals(SeverityType.Info));

    public static void AddRange(this List<Notification> notifications, List<ValidationFailure> failures)
    {
        if (failures == null || failures.Count == 0)
            return;

        notifications.AddRange(Notification.ConvertFrom(failures));
    }

    public static IEnumerable<string> ToStringList(this IReadOnlyCollection<INotification> notifications)
    {
        foreach (var notification in notifications)
        {
            yield return $"[{notification.Severity}] {notification.Message}";
        }
    }
}