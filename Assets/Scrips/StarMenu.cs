using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMenu : MonoBehaviour
{
    public GameObject mainMenu;

    // Start is called before the first frame update
    void Start(){

        //on program start it makes the menu active and disables input in the game object
        mainMenu.SetActive(true);
        Game.Instance.input.Disable();
    }

    // Update is called once per frame
    public void StartGame(){

        //hides the menu and enables input
        mainMenu.SetActive(false);
        Game.Instance.input.Enable();
    }
}
