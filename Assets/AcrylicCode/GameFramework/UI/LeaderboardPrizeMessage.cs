using PlayFab;
using PlayFab.ClientModels;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardPrizeMessage : MonoBehaviour
{
    [Header("PlayFab Variables")]
    [Tooltip("Item class to sort out prizes from other inventory items")]
    public string itemClass = "prize";

    [Header("UI Elements")]
    public TokenManager tokenManager;
    public CanvasInitiate canvas;
    public Text titleText;
    public Text amountText;


    private string prizeInstanceID = "";
    private int prizeAmount = 0;

    private void Awake()
    {
        PlayFabLogin.LoginSuccess += CheckForPrizes;
    }

    private void CheckForPrizes()
    {
        PlayFabClientAPI.GetUserInventory(new GetUserInventoryRequest(),
            result =>
            {
                if (result.Inventory.Count > 0)
                {
                    for(int i = 0; i < result.Inventory.Count; i++)
                    {
                        if(result.Inventory[i].ItemClass == itemClass)
                        {
                            prizeInstanceID = result.Inventory[i].ItemInstanceId;
                            SetItemData(result.Inventory[i].ItemId);
                        }
                    }
                }
                else
                {
                    canvas.FadeCanvasGroup(0);
                }
            },
            error =>
            {
                Debug.Log("Got error getting inventory");
                Debug.Log(error.GenerateErrorReport());
            }
       );
    }

    private void SetItemData(string itemID)
    {
        PlayFabClientAPI.GetCatalogItems(new GetCatalogItemsRequest(),
            result =>
            {
                if (result.Catalog.Count > 0)
                {
                    for (int i = 0; i < result.Catalog.Count; i++)
                    {
                        if (result.Catalog[i].ItemId == itemID)
                        {
                            canvas.FadeCanvasGroup(1);

                            titleText.text = result.Catalog[i].DisplayName;
                            prizeAmount = (int)result.Catalog[i].VirtualCurrencyPrices["GC"];
                            amountText.text = prizeAmount.ToString();
                        }
                    }
                }
            },
            error =>
            {
                Debug.Log("Got error getting custom data for: " + itemID);
                Debug.Log(error.GenerateErrorReport());
            }
       );
    }

    /// <summary>
    /// Called from the button in the popup
    /// </summary>
    public void ConsumePrize()
    {
        PlayFabClientAPI.ConsumeItem(new ConsumeItemRequest() { ItemInstanceId = prizeInstanceID, ConsumeCount = 1 },
        result =>
        {
            tokenManager.AddTokens(prizeAmount);
        },
        error =>
        {
            Debug.Log("Got consuming prize");
            Debug.Log(error.GenerateErrorReport());
        }
        );
    }
}
