using UnityEngine;

public class SpeedShop : MonoBehaviour
{
    [SerializeField] private GameEvents gameEvents;
    [SerializeField] private Inventory playerInventory;
    [SerializeField] private Shop speedShop;
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Player"))
        {
            if (playerInventory.numberOfMoney >= speedShop.PriceOfUpgrade)
            {
                playerInventory.playerSpeed += speedShop.AmountOfUpgrade;
                playerInventory.numberOfMoney -= speedShop.PriceOfUpgrade;
                gameEvents.OnUpdateCoinCounter.Invoke();
            }
        }
    }
}