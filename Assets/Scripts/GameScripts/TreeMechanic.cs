using UnityEngine;
public class TreeMechanic : MonoBehaviour
{
    [SerializeField] private Inventory playerInventory;
    [SerializeField] private Tree treeInformation;
    [SerializeField] private int treeHealth;
    void Start()
    {
        treeHealth = treeInformation.TreeHealth;
        gameObject.tag = treeInformation.TreeTag;
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Player"))
        {
            treeHealth -= playerInventory.playerDamage;
            if (treeHealth <= 0)
            {
                gameObject.SetActive(false);
            }
        }
    }
    
}