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



        //remove notif that have already seen
        AndroidNotificationCenter.CancelAllDisplayedNotifications();
        //create notif channel
        var channel2 = new AndroidNotificationChannel()
        {
            Id = "channel_id2",
            Name = "Notification Channel2",
            Importance = Importance.Default,
            Description = "Spin notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel2);

        //create notification that going to be sent
        var notification2 = new AndroidNotification();
        notification.Title = "Let's Spin The Wheel";
        notification.Text = "It's time to spin the wheel. Let's use your chance to win lots of coins and gems!";
        if (SpinnerTimer.secondsLeft == 0f)
        {
            notification.FireTime = System.DateTime.Now;
        }
        

        //send the notification 
        var id2 = AndroidNotificationCenter.SendNotification(notification2, "channel_id2");

        //if the script is run and a message is already scheduled, cancel it and re-schedule another message
        if (AndroidNotificationCenter.CheckScheduledNotificationStatus(id2) == NotificationStatus.Scheduled)
        {
            AndroidNotificationCenter.CancelAllNotifications();
            AndroidNotificationCenter.SendNotification(notification, "channel_id2");
        }

        
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