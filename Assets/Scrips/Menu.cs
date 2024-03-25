using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    //public GameObject gameOverlay;
    public GameObject gameOverMenu;

    // Start is called before the first frame update
    void Start()
    {
        mainMenu.SetActive(true);
        //gameOverlay.SetActive(false);
        gameOverMenu.SetActive(false);
        Game.Instance.input.Disable();
    }

    public void StartGame()
    {
        mainMenu.SetActive(false);
        //gameOverlay.SetActive(true);
        Game.Instance.input.Enable();
    }

    public void GameOver()
    {
        //gameOverlay.SetActive(false);
        gameOverMenu.SetActive(true);
        Game.Instance.input.Disable();

    }

    public void Restart()
    {
        gameOverMenu.SetActive(false);
        Game.Instance.input.Enable();
        Game.Instance.ResetScore();
    }
}
