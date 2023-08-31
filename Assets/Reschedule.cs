using System.Collections;
using UnityEngine;

public class NotificationRescheduler : MonoBehaviour
{
    private const float CheckInterval = 3600f; // Check every hour

    private void Start()
    {
        StartCoroutine(CheckAndReschedule());
    }

    private IEnumerator CheckAndReschedule()
    {
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
                    // Reschedule the notification here
                    // Create a new AndroidNotification and send it
                    // Store the new timestamp in PlayerPrefs
                }
            }
        }
    }
}
