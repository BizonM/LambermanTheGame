using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private GameEvents gameEvents;
    [SerializeField] private InventoryScriptableObject playerInventory;
    
    private void Awake()
    {
        playerInventory.numberOfWood = 0;
        playerInventory.numberOfMoney = 0;
        playerInventory.playerDamage = 1;
        playerInventory.playerSpeed = 1000;
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Tree"))
        {
            playerInventory.numberOfWood += playerInventory.playerDamage;
            gameEvents.OnUpdateWoodCounter.Invoke();
        }
        else if (collisionInfo.collider.CompareTag("BetterTree"))
        {
            playerInventory.numberOfWood += playerInventory.playerDamage * 2;
            gameEvents.OnUpdateWoodCounter.Invoke();
        }
    }
}