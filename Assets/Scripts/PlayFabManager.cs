using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using TMPro;

public class PlayFabManager : MonoBehaviour
{
    public GameObject nameWindow;
    public TMP_InputField nameInput;
    public GameObject rowPrefab;
    public Transform rowsParent;
    string loggedInPlayedId;
    public static bool nameAccepter, playerFound;
    // Start is called before the first frame update
    void Start()
    {
        playerFound = false;
        nameAccepter = false;
        Login();
    }

    IEnumerator EXO()
    {
        yield return new WaitForSeconds(3f);

        GetLeaderboard();
    }

    // Update is called once per frame
    private void Update()
    {
        if (nameAccepter == true)
        {
            nameWindow.SetActive(true);
            nameAccepter = false;
        }
    }
    void Login()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true,
            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true
            }
        };
        PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);

    }
    void OnSuccess(LoginResult result)
    {
        loggedInPlayedId = result.PlayFabId;
        Debug.Log("Successful");
        EXO();
        string name = null;
        if (result.InfoResultPayload.PlayerProfile != null)
        {
            name = result.InfoResultPayload.PlayerProfile.DisplayName;
        }
        if (name == null)
        {
            nameAccepter = true;
        }

    }
    public void SubmitNameButton()
    {
        var request = new UpdateUserTitleDisplayNameRequest
        {
            DisplayName = nameInput.text,

        };
        nameWindow.SetActive(false);
        PlayFabClientAPI.UpdateUserTitleDisplayName(request, OnDisplayNameUpdate, OnError);
    }
    void OnDisplayNameUpdate(UpdateUserTitleDisplayNameResult result)
    {
        Debug.Log("NameUpdated");
    }
    void OnError(PlayFabError error)
    {
        Debug.Log("Error");
        Debug.Log(error.GenerateErrorReport());
    }
    public void SendLeaderboard(int score)
    {
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate
                {
                    StatisticName="Shoot Saga Leaderboard",
                    Value=score
                }
            }
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnLeaderboardUpdate, OnError);
    }
    void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result)
    {
        Debug.Log("Successfull leaderboard sent");
    }
    public void GetLeaderboard()
    {
        var request = new GetLeaderboardRequest
        {
            StatisticName = "Shoot Saga Leaderboard",
            StartPosition = 0,
            MaxResultsCount = 11
        };
        PlayFabClientAPI.GetLeaderboard(request, OnLeaderboardGet, OnError);
    }
    void OnLeaderboardGet(GetLeaderboardResult result)
    {
        foreach (Transform item in rowsParent)
        {
            Destroy(item.gameObject);
        }
        foreach (var item in result.Leaderboard)
        {
            if (item.Position < 10)
            {
                GameObject newGo = Instantiate(rowPrefab, rowsParent);
                TMP_Text[] texts = newGo.GetComponentsInChildren<TMP_Text>();
                texts[0].text = (item.Position + 1).ToString();
                texts[1].text = item.DisplayName;
                texts[2].text = item.StatValue.ToString();
                Debug.Log(item.Position + " " + item.DisplayName + " " + item.StatValue);
                if (item.PlayFabId == loggedInPlayedId)
                {
                    playerFound = true;
                    texts[0].color = new Color(97 / 255f, 56 / 255f, 253 / 255f);
                    texts[1].color = new Color(97 / 255f, 56 / 255f, 253 / 255f);
                    texts[2].color = new Color(97 / 255f, 56 / 255f, 253 / 255f);
                }
            }
            else
            {
                Debug.Log("getaroundcart");
                GetLeaderboardAroundPlayer();

            }

        }


    }
    void OnLeaderboardAroundPlayerGet(GetLeaderboardAroundPlayerResult result)
    {
        foreach (Transform item in rowsParent)
        {
            //Destroy(item.gameObject);
        }
        foreach (var item in result.Leaderboard)
        {
            if (playerFound == false)
            {
                GameObject newGo = Instantiate(rowPrefab, rowsParent);
                TMP_Text[] texts = newGo.GetComponentsInChildren<TMP_Text>();
                texts[0].text = (item.Position + 1).ToString();
                texts[1].text = item.DisplayName;
                texts[2].text = item.StatValue.ToString();
                if (item.PlayFabId == loggedInPlayedId)
                {
                    texts[0].color = new Color(97 / 255f, 56 / 255f, 253 / 255f);
                    texts[1].color = new Color(97 / 255f, 56 / 255f, 253 / 255f);
                    texts[2].color = new Color(97 / 255f, 56 / 255f, 253 / 255f);
                }
                Debug.Log(item.Position + " " + item.DisplayName + " " + item.StatValue);
            }

        }
    }
    public void GetLeaderboardAroundPlayer()
    {
        var request = new GetLeaderboardAroundPlayerRequest
        {
            StatisticName = "Shoot Saga Leaderboard",
            MaxResultsCount = 1
        };
        PlayFabClientAPI.GetLeaderboardAroundPlayer(request, OnLeaderboardAroundPlayerGet, OnError);
    }
}