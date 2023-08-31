using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class MobileNotifications : MonoBehaviour
{
    private const float CheckInterval = 3600f; // Check every hour
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
        //yeni
        PlayerPrefs.SetString("LastNotificationTime", System.DateTime.Now.ToString());
        PlayerPrefs.Save();
        //yeni

        //create notification that going to be sent
        var notification = new AndroidNotification();
        notification.Title = "Miss the action? ";
        notification.Text = "Your court is waiting! Jump back into the game now and keep the excitement alive!";
        notification.FireTime = System.DateTime.Now.AddHours(8);

        //send the notification 
        var id = AndroidNotificationCenter.SendNotification(notification, "channel_id");

        //if the script is run and a message is already scheduled, cancel it and re-schedule another message
        if (AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Scheduled)
        {
            AndroidNotificationCenter.CancelAllNotifications();
            AndroidNotificationCenter.SendNotification(notification, "channel_id");
        }
        StartCoroutine(CheckAndReschedule());//yeni
        
    }
    //yeni
    private IEnumerator CheckAndReschedule()
    {
        var notification = new AndroidNotification();
        while (true)
        {
            yield return new WaitForSeconds(CheckInterval);

            // Check if the user has entered the game since the last notification
            string lastNotificationTimeStr = PlayerPrefs.GetString("LastNotificationTime", "");
            if (!string.IsNullOrEmpty(lastNotificationTimeStr))
            {
                System.DateTime lastNotificationTime = System.DateTime.Parse(lastNotificationTimeStr);
                System.TimeSpan timeSinceNotification = System.DateTime.Now - lastNotificationTime;

                if (timeSinceNotification.TotalHours >= 8) // If 8 hours have passed
                {
                    AndroidNotificationCenter.CancelAllNotifications();
                    AndroidNotificationCenter.SendNotification(notification, "channel_id");
                }
            }
        }
    }
    //yeni
}