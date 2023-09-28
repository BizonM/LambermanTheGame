using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameEvents gameEvents;
    [SerializeField] private InventoryScriptableObject playerInventory;
    [SerializeField] private Text numberOfWood;
    [SerializeField] private Text numberOfMoney;
    [SerializeField] private Text numberOfDamage;
    void OnEnable()
    {
        gameEvents.OnUpdateWoodCounter += UpdateWoodCounter;
        gameEvents.OnUpdateCoinCounter += UpdateCoinCounter;
        gameEvents.OnUpdateDamageCounter += UpdateDamageCounter;
        numberOfWood.text = playerInventory.numberOfWood.ToString();
        numberOfMoney.text = playerInventory.numberOfMoney.ToString();
        numberOfDamage.text = playerInventory.playerDamage.ToString();
    }
    private void OnDisable()
    {
        gameEvents.OnUpdateWoodCounter -= UpdateWoodCounter;
        gameEvents.OnUpdateCoinCounter -= UpdateCoinCounter;
        gameEvents.OnUpdateDamageCounter -= UpdateDamageCounter;
    }

    private void UpdateWoodCounter()
    {
        numberOfWood.text = playerInventory.numberOfWood.ToString();
    }

    private void UpdateCoinCounter()
    {
        numberOfMoney.text = playerInventory.numberOfMoney.ToString();
    }

    private void UpdateDamageCounter()
    {
        numberOfDamage.text = playerInventory.playerDamage.ToString();
    }
}
