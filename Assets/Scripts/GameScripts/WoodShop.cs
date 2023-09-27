using UnityEngine;

public class WoodShop : MonoBehaviour
{
    [SerializeField] private GameEvents gameEvents;
    [SerializeField] private Inventory playerInventory;
    private void OnCollisionEnter2D(Collision2D info)
    {
        if (info.collider.CompareTag("Player"))
        {
            playerInventory.numberOfMoney += playerInventory.numberOfWood;
            playerInventory.numberOfWood = 0;
            gameEvents.OnUpdateWoodCounter.Invoke();
            gameEvents.OnUpdateCoinCounter.Invoke();
        }
    }
}