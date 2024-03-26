using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameOverlay;
    public GameObject gameOverMenu;
    AudioSource backGroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        backGroundMusic = GetComponent<AudioSource>();
        mainMenu.SetActive(true);
        gameOverlay.SetActive(false);
        gameOverMenu.SetActive(false);
        Game.Instance.input.Disable();
    }

    public void StartGame()
    {
        backGroundMusic.Play();
        mainMenu.SetActive(false);
        gameOverlay.SetActive(true);
        Game.Instance.input.Enable();

    }

    public void GameOver()
    {
        backGroundMusic.enabled = false;
        gameOverlay.SetActive(false);
        gameOverMenu.SetActive(true);
        Game.Instance.input.Disable();
        backGroundMusic.enabled = true;

    }

    public void Restart()
    {
        gameOverMenu.SetActive(false);
        gameOverlay.SetActive(true);
        Game.Instance.input.Enable();
        Game.Instance.ResetScore();
        backGroundMusic.Play();
    }
}
