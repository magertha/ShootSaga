using UnityEngine;
using System.Collections;
using System;

public class SpinWheel : MonoBehaviour
{

    float degrees = 360f;
    int numberOfRewards = 1;
    float maxTime = 3, minTime = 1.2f;
    float timeToSlow = 1f;
    float offSet = 0f;
    float speed = 20f;
    public GameObject go;

    Action<int> reward;

    /// <summary>
    /// To create a new SpinWheel.
    /// </summary>
    /// <param name="numberOfRewards">The number of rewards that the player has.</param>
	public SpinWheel(int numberOfRewards)
    {
        degrees /= numberOfRewards;
        this.numberOfRewards = numberOfRewards;
    }

    /// <summary>
    /// To set the time when the spin start slowing EX: 1 -> 1 seconds from ending it starts to slow.
    /// </summary>
    /// <param name="time">Time in seconds</param>
    public void setSlowingTime(float time)
    {
        if (time < maxTime - minTime)
        {
            timeToSlow = time;
        }
    }

    /// <summary>
    /// The max time for the spin to spin and give a random number.
    /// </summary>
    /// <param name="mTime">Time in seconds</param>
    public void setMaxTime(float mTime)
    {
        if (mTime >= minTime)
            maxTime = mTime;
    }

    /// <summary>
    /// The minimum time for the spin to spin and give a random number.
    /// </summary>
    /// <param name="mTime">Time in seconds</param>
    public void setMinTime(float mTime)
    {
        if (mTime <= maxTime)
            minTime = mTime;
    }

    /// <summary>
    /// Set the offset of the starting position of the first reward.
    /// </summary>
    public void setOffset()
    {
        if (offSet != 0f)
        {
            offSet = ((360 / numberOfRewards) / 2);
        }
        else
        {
            offSet = 0;
        }
    }

    /// <summary>
    /// Has offset -> true otherwise its false.
    /// </summary>
    /// <returns></returns>
    public bool hasOffset()
    {
        return offSet != 0f;
    }

    /// <summary>
    /// Add a callback to the system.
    /// </summary>
    /// <param name="callback"></param>
    public void AddCallback(Action<int> callback)
    {
        reward += callback;
    }

    /// <summary>
    /// Removes a callback to the system.
    /// </summary>
    /// <param name="callback"></param>
    public void RemoveCallback(Action<int> callback)
    {
        reward -= callback;
    }

    /// <summary>
    /// Set the wheel gameobject in this script.
    /// </summary>
    /// <param name="go">This is just the wheel. </param>
    public void setWheel(GameObject go)
    {
        this.go = go;
    }

    /// <summary>
    /// Sets the maximum velocity that the well reaches.
    /// </summary>
    /// <param name="vel">float</param>
    public void setVelocity(float vel)
    {
        speed = vel;
    }

    /// <summary>
    /// Starts the spin!
    /// </summary>
    /// <returns></returns>
    public IEnumerator StartNewRun()
    {
        float r = UnityEngine.Random.Range(minTime, maxTime);

        bool runing = true;
        float timeRemaining = r;
        float timePassed = 0f;

        while (runing)
        {
            yield return new WaitForSeconds(0.01f);
            timeRemaining -= 0.01f;
            timePassed += 0.01f;

            if (timeRemaining <= timeToSlow)
            {
                float z = speed * (timeRemaining / timeToSlow);
                go.transform.Rotate(0, 0, z);
            }
            else
            {
                float z = speed * (timePassed / (r - timeToSlow));
                go.transform.Rotate(0, 0, z);
            }

            if (timeRemaining <= 0f)
                runing = false;
        }
        int index = (int)(numberOfRewards * (go.transform.eulerAngles.z / 360));

        reward(index + 1);
    }
}
