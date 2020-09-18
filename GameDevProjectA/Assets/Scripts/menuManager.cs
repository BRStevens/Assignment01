using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    // Create public variables (GameObjects)
    public GameObject player;
    public GameObject mainMenu;
    public GameObject curser;
    public GameObject level01;
    public GameObject[] curserPositions;
    public GameObject playerSelectIndicator;
    public Text thisText;

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
            level01.SetActive(true);
            player.SetActive(true);
            mainMenu.SetActive(false);

            mainCamera.enabled = false;
            gameCamera.enabled = true;
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

    }
}
