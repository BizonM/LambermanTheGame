using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Rigidbody2D playerRigidbody2D;
    [SerializeField] private InventoryScriptableObject playerInventory;
    [SerializeField] private InventoryScriptableObject startPlayerInventory;
    [SerializeField] private TreeScrtiptableObject tree;
    [SerializeField] private TreeScrtiptableObject betterTree;
    [SerializeField] private GameEvents gameEvents;
    [SerializeField] private GameObject inGameMenu;
    [SerializeField] private GameObject howToPlayMenu;
    private bool isInMenu;
    private bool isTurningRight;
    private bool isTurningLeft;
    private int playerAngle;
    
    private void Awake()
    {
        Cursor.visible = false;
        playerInventory.numberOfWood = startPlayerInventory.numberOfWood;
        playerInventory.numberOfMoney = startPlayerInventory.numberOfMoney;
        playerInventory.playerDamage = startPlayerInventory.playerDamage;
        playerInventory.playerSpeed = startPlayerInventory.playerSpeed;
    }

    void Update()
    {
        if (!isInMenu)
        {
            if (Input.GetKey("w"))
            {
                MovePlayer(0);
            } 
            if (Input.GetKey("s"))
            {
                MovePlayer(180);
            }
            if (Input.GetKey("d"))
            {
                MovePlayer(270);
            }
            if (Input.GetKey("a"))
            {
                MovePlayer(90);
            }
        }
        if (Input.GetKeyDown("escape") && !isInMenu)
        {
            CursorVisibility(true);
        }
        else if(Input.GetKeyDown("escape") && isInMenu)
        {
            CursorVisibility(false);
            howToPlayMenu.SetActive(false);
        }
    }
    
    void OnCollisionEnter2D(Collision2D info)
    {
        if (info.collider.CompareTag("Tree"))
        {
            GetWood(tree.WoodMultiplier);
        }
        else if (info.collider.CompareTag("BetterTree"))
        {
            GetWood(betterTree.WoodMultiplier);
        }
    }
    
    private void RotatePlayer(int rotation)
    {
        var playerRotation = playerTransform.rotation.eulerAngles;
        playerRotation.z = rotation;
        playerTransform.rotation = Quaternion.Euler(playerRotation);
    }
    
    private void MovePlayer(int rotation)
    {
        playerRigidbody2D.AddForce(playerInventory.playerSpeed * Time.deltaTime * transform.up, ForceMode2D.Force);
        RotatePlayer(rotation);
    }
    private void CursorVisibility(bool enablingCursor)
    {
        inGameMenu.SetActive(enablingCursor);
        isInMenu = enablingCursor;
        Cursor.visible = enablingCursor;
    }

    private void GetWood(int multiplier)
    {
        playerInventory.numberOfWood += playerInventory.playerDamage * multiplier;
        gameEvents.OnUpdateWoodCounter.Invoke();
    }
}