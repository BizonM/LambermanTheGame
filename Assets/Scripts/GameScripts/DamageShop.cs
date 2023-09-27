using UnityEngine;

public class DamageShop : MonoBehaviour
{
    [SerializeField] private GameEvents gameEvents;
    [SerializeField] private Shop damageShop;
    [SerializeField] private Inventory playerInventory;

    private void OnCollisionEnter2D(Collision2D info)
    {
        if (info.collider.CompareTag("Player"))
        {
            if (playerInventory.numberOfMoney >= damageShop.PriceOfUpgrade)
            {
                playerInventory.playerDamage += damageShop.AmountOfUpgrade;
                playerInventory.numberOfMoney -= damageShop.PriceOfUpgrade;
                gameEvents.OnUpdateDamageCounter.Invoke();
                gameEvents.OnUpdateCoinCounter.Invoke();
            }
        }
    }
}