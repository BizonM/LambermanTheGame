using UnityEngine;

public class BorderShop : MonoBehaviour
{
    [SerializeField] private GameEvents gameEvents;
    [SerializeField] private Inventory playerInventory;
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Player"))
        {
            if (playerInventory.numberOfMoney >= 20)
            {
                playerInventory.numberOfMoney -= 20;
                gameEvents.OnOpenBorders.Invoke();
                gameEvents.OnUpdateCoinCounter.Invoke();
                gameObject.SetActive(false);
            }
        }
    }
}