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
    public float launchforce;
    AudioSource Launch_Sound;
    [HideInInspector] public Pinballinput input;
    public GameObject Deathzone;
    public AudioSource Death;

    void Start(){
        //we get the properys of the rigidbody and store them inside rb and do the same with launch sound but get the audio source component
        rb = GetComponent<Rigidbody>();
        Launch_Sound = GetComponent<AudioSource>();
        Death = GetComponent<AudioSource>();
        
    }
    public void Launch() {
        //we add a force to the rb that has our launch force multiplied in
        rb.AddForce(Vector3.forward * launchforce, ForceMode.Impulse);
        //we play the sound when this function is called
        Launch_Sound.Play();
        
        

    }
    //restart function used to resrart whole game after "losing"
    public void Restart()
    {
        transform.position = GameObject.FindWithTag("BallStart").transform.position;
        rb.velocity = Vector3.zero;
    }
    private void OnTriggerEnter(Collider other)
    {
        //if the object collided with has the ball restart tab then the following code will execute
        //it will move the current object to the gameobject with the ballstart tag and change its position,zero velocity, and re enable the launch key
        if (other.CompareTag("BallRestart")){
            transform.position = GameObject.FindWithTag("BallStart").transform.position;
            rb.velocity = Vector3.zero;
            Game.Instance.input.FindAction("Launch Ball").Enable();
            Death.Play();

        }
        
    }


    private void OnCollisionEnter(Collision collision){
        //a bumper variable that detects if it has any collision with another object
        var bumper = collision.gameObject.GetComponent<Bumper>();
        
        //if the bumper has any collision then we run the Bump function
        if(bumper != null)
        {
            bumper.Bump();
        }
        
    }

    
    
    void Update()
    {
        
    }
}
