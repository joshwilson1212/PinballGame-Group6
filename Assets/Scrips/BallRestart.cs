using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRestart : MonoBehaviour{
    AudioSource gameover_sound;

    // Start is called before the first frame update
    void Start(){
        gameover_sound = GetComponent<AudioSource>();
    }
    public void play_sound(){
        gameover_sound.Play();
    } 
}
