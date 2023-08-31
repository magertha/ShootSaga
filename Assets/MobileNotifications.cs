using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class MobileNotifications : MonoBehaviour
{
    void Start()
    {
        //remove notif that have already seen
        AndroidNotificationCenter.CancelAllDisplayedNotifications();
        //create notif channel
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Notification Channel",
            Importance = Importance.Default,
            Description = "Reminder notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        //create notification that going to be sent
        var notification = new AndroidNotification();
        notification.Title = "Miss the action? ";
        notification.Text = "Your court is waiting! Jump back into the game now and keep the excitement alive!";
        notification.FireTime = System.DateTime.Now.AddSeconds(15);

        //send the notification 
        var id = AndroidNotificationCenter.SendNotification(notification, "channel_id");

        //if the script is run and a message is already scheduled, cancel it and re-schedule another message
        if (AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Scheduled)
        {
            AndroidNotificationCenter.CancelAllNotifications();
            AndroidNotificationCenter.SendNotification(notification, "channel_id");
        }
    }

}