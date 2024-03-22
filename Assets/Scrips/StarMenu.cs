using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMenu : MonoBehaviour{
    public GameObject mainMenu;

    //on program start it makes the menu active and disables input in the game object
    void Start(){
        mainMenu.SetActive(true);
        Game.Instance.input.Disable();
    }

    //hides the menu and enables input
    public void StartGame(){
        mainMenu.SetActive(false);
        Game.Instance.input.Enable();  
    }
}
