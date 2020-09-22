using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    // Create public variables (GameObjects)
    public GameObject mainMenu;
    public GameObject curser;
    public GameObject gameArena;
    public GameObject[] curserPositions;
    public GameObject playerSelectIndicator;
    public GameObject player01SpawnPoint;
    public GameObject playerPrefab;
    public Text thisText;

    // Declare camera variables
    public Camera gameCamera;
    public Camera mainCamera;

    private bool onStartGameSelection;
    private bool onePlayer = true;

    //int thisNumber = 0;
    //float thisDecimalNumber = 0.5f;
    //string yourName = "Harry Potter";
    //bool yourValue = true; // (or false)

    // Start is called before the first frame update
    void Start()
    {
        onStartGameSelection = false;
        thisText = playerSelectIndicator.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        // Check for space or enter key pressed
        // if pressed then deactivate the menu game object
        // and show the player character game object

        //if (Input.GetKey("space") || Input.GetKey("return"))
        //{
        //    player.SetActive(true);
        //    mainMenu.SetActive(false);
        //}

        // if the user presses up
        // move curser to next selection

        if(Input.GetKeyDown("up") || Input.GetKeyDown("down"))
        {
            if(onStartGameSelection)
            {
                onStartGameSelection = false;
            }
            else
            {
                onStartGameSelection = true;
            }
        }

        if(onStartGameSelection)
        {
            curser.transform.position = curserPositions[1].transform.position;
        }
        else
        {
            curser.transform.position = curserPositions[0].transform.position;
        }

        if(onStartGameSelection && Input.GetKeyDown("return"))
        {
            // Start game

            // Turn off main menu turn on game Arena
            gameArena.SetActive(true);
            mainMenu.SetActive(false);

            // Turn off main camera, turn on gameplayer camera
            mainCamera.enabled = false;
            gameCamera.enabled = true;

            // Instantiate the player from a prefab!
            Instantiate(playerPrefab, player01SpawnPoint.transform.position, Quaternion.identity);

        }

        // Toggle number of players
        if (!onStartGameSelection && Input.GetKeyDown("return"))
        {
            if (onePlayer)
            {
                thisText.text = "2";
                onePlayer = false;
            }
            else
            {
                thisText.text = "1";
                onePlayer = true;
            }
        }

        // if user presses down
        // move curser to next selection

        // if the user presses enter AND if onStartGameSelection is false then
        // toggle number of players

        // if the user presses enter AND if onStartGameSelection is true then
        // start the game

        // This code is new
        // Now this code is new

    }
}
