using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class PlayFabLogin : MonoBehaviour
{
    public delegate void ProfileEvent(PlayerProfileModel profile);
    /// <summary>
    /// Event that fires when login is completed successfully
    /// </summary>
    public static ProfileEvent LoginSuccess;
    private void Announce_LoginSuccess(PlayerProfileModel profile) { if (LoginSuccess != null) LoginSuccess(profile); }

    public CanvasInitiate loginCanvas;
    public Text displayNameInput;
    private string playFabId = "";

    public void Awake()
    {
        //ANDROID
        if (Application.platform == RuntimePlatform.Android)
        {
            var request = new LoginWithAndroidDeviceIDRequest
            {
                TitleId = PlayFabSettings.TitleId,
                AndroidDeviceId = SystemInfo.deviceUniqueIdentifier,
                AndroidDevice = SystemInfo.deviceModel,
                CreateAccount = true
            };
            PlayFabClientAPI.LoginWithAndroidDeviceID(request, OnLoginSuccess, OnLoginFailure);
        }
        //EDITOR
        if (Application.platform == RuntimePlatform.WindowsEditor)
        {
            var request = new LoginWithCustomIDRequest { CustomId = "Unity Editor", CreateAccount = true };
            PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFailure);
        }
    }

    private void OnLoginSuccess(LoginResult result)
    {
        playFabId = result.PlayFabId;

        //check if has a display name already
        PlayFabClientAPI.GetPlayerProfile(new GetPlayerProfileRequest()
        {
            PlayFabId = playFabId
        },
            success =>
            {
                //if no display name set yet, first login
                if (success.PlayerProfile.DisplayName == null)
                {
                    Debug.Log("No display name, first login");
                    loginCanvas.FadeCanvasGroup(1);
                }
                else
                {
                    Debug.Log("DisplayName: " + success.PlayerProfile.DisplayName);
                    loginCanvas.FadeCanvasGroup(0);
                }

                //signal other scripts that login is completed
                Announce_LoginSuccess(success.PlayerProfile);
            },
            error =>
            {
                Debug.Log("Got error logging in:");
                Debug.Log(error.GenerateErrorReport());
            }
        );
    }

    private void OnLoginFailure(PlayFabError error)
    {
        Debug.LogWarning("Something went wrong with your first API call.  :(");
        Debug.LogError("Here's some debug information:");
        Debug.LogError(error.GenerateErrorReport());
    }

    public void SetDisplayName()
    {
        PlayFabClientAPI.UpdateUserTitleDisplayName(new UpdateUserTitleDisplayNameRequest()
        {
            DisplayName = displayNameInput.text
        },
            result =>
            {
                Debug.Log("Set Display Name to: " + result.DisplayName);
            },
            error =>
            {
                Debug.LogError("Error setting Display Name");
                Debug.LogError(error.GenerateErrorReport());
            }
        );
    }
}