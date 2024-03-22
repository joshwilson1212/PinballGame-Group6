using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Bumper : MonoBehaviour{
    private Renderer ren;
    //private float time;
    public Ball ball;
    
    AudioSource Bumper_sound;
    MeshCollider bumper;
    

    void Start()
    {
        //we get the Render Componnent and save it in ren
        ren = GetComponent<Renderer>();
        Bumper_sound = GetComponent<AudioSource>();

        bumper = GetComponent<MeshCollider>();
       


        //time = 0;
    }

    
    void Update(){
        
    }
    public void Ghost()
    {
        print("ghost mode");
        Destroy(bumper);
     

    }

    public void Bump() {
        //plays the bumper sound
        print("impact");
        Bumper_sound.Play();
    }
}
