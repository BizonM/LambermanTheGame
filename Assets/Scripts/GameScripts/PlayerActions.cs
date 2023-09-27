using System;
using System.Collections;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform playerSpriteTransform;
    [SerializeField] private Rigidbody2D playerRigidbody2D;
    [SerializeField] private Inventory playerInventory;
    [SerializeField] private GameObject inGameMenu;
    private bool isInMenu = false;
    private bool isTurningRight;
    private bool isTurningLeft;
    private int playerAngle;

    private Vector3 PlayerRotation;

    private void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        if (!isInMenu)
        {
            if (Input.GetKey("w"))
            {
                playerRigidbody2D.AddForce(playerInventory.playerSpeed * Time.deltaTime * transform.up, ForceMode2D.Force);
                RotatePlayer(0);
            } 
            if (Input.GetKey("s"))
            {
                playerRigidbody2D.AddForce(playerInventory.playerSpeed * Time.deltaTime * -transform.up, ForceMode2D.Force);
                RotatePlayer(180);
            }
            if (Input.GetKey("d"))
            {
                playerRigidbody2D.AddForce(playerInventory.playerSpeed * Time.deltaTime * transform.right, ForceMode2D.Force);
                RotatePlayer(270);
            }
            if (Input.GetKey("a"))
            {
                playerRigidbody2D.AddForce(playerInventory.playerSpeed * Time.deltaTime * -transform.right, ForceMode2D.Force);
                RotatePlayer(90);
            }
        }

        if (Input.GetKeyDown("escape") && !isInMenu)
        {
            inGameMenu.SetActive(true);
            isInMenu = true;
            Cursor.visible = true;
        }
        else if(Input.GetKeyDown("escape") && isInMenu)
        {
            inGameMenu.SetActive(false);
            isInMenu = false;
            Cursor.visible = false;
        }
    }

    private void RotatePlayer(int rotation)
    {
        var playerRotation = playerSpriteTransform.rotation.eulerAngles;
        playerRotation.z = rotation;
        playerSpriteTransform.rotation = Quaternion.Euler(playerRotation);
    }
}