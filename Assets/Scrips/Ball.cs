using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//we put this here in case we forget to add a rigidbody to the ball and also adds a AdioSource Component to the ball
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour {

    //rb is a Rigidbody object and we have Launchforce set to public so change the value form unit menu and then we make a AudioSource Instance
    private Rigidbody rb;
    //public int Lives { get; private set; }
    private const int MAX_LIVES = 1;
    public int lives;

    public float launchforce;
    AudioSource Launch_Sound;
    [HideInInspector] public Pinballinput input;
    public BallRestart Deathzone;
    public Menu menu;

    public static Ball Instance { get; private set; }

    //we get the properys of the rigidbody and store them inside rb and do the same with launch sound but get the audio source component
    void Start(){
        lives = MAX_LIVES;
        rb = GetComponent<Rigidbody>();
        Launch_Sound = GetComponent<AudioSource>();
        Instance = this;
    }
    //we add a force to the rb that has our launch force multiplied in
    //we play the sound when this function is called
    public void Launch() {
        rb.AddForce(Vector3.forward * launchforce, ForceMode.Impulse);
        Launch_Sound.Play();

    }
    //restart function used to resrart whole game after "losing"
    public void Restart(){
        transform.position = GameObject.FindWithTag("BallStart").transform.position;
        rb.velocity = Vector3.zero;
        lives = MAX_LIVES;
    }
    //if the object collided with has the ball restart tab then the following code will execute
    //it will move the current object to the gameobject with the ballstart tag and change its position,zero velocity, and re enable the launch key
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("BallRestart")){
            transform.position = GameObject.FindWithTag("BallStart").transform.position;
            rb.velocity = Vector3.zero;
            Game.Instance.input.FindAction("Launch Ball").Enable();
            Deathzone.play_sound();
            lives--;
            print($"number of lives: {lives}");
            if (lives == 0)
            {
                menu.GameOver();
            }
            
        }
    }
    //a bumper variable that detects if it has any collision with another object
    //if the bumper has any collision then we run the Bump function
    private void OnCollisionEnter(Collision collision){
        var bumper = collision.gameObject.GetComponent<Bumper>();
        if(bumper != null){
            bumper.Bump();
            print("bump");
            Game.Instance.AddScore(10);
        }
        
    }
}
