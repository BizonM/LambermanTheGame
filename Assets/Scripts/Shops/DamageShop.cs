using UnityEngine;

public class DamageShop : Shop
{
    protected override void OnCollisionEnter2D(Collision2D info)
    {
        if (info.collider.CompareTag("Player"))
        {
            if (playerInventory.numberOfMoney >= shopInfoScriptableObject.PriceOfUpgrade)
            {
                playerInventory.playerDamage += shopInfoScriptableObject.AmountOfUpgrade;
                playerInventory.numberOfMoney -= shopInfoScriptableObject.PriceOfUpgrade;
                gameEvents.OnUpdateDamageCounter.Invoke();
                gameEvents.OnUpdateCoinCounter.Invoke();
            }
        }
    }
}