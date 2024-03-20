using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMenu : MonoBehaviour
{
    public GameObject mainMenu;
    // Start is called before the first frame update
    void Start(){
        mainMenu.SetActive(true);
        Game.Instance.input.Disable();
    }

    // Update is called once per frame
    public void StartGame(){
        mainMenu.SetActive(false);
        Game.Instance.input.Enable();
    }
}
