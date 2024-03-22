using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour{
    //name might be slightly messed up but its lowercase
    [HideInInspector] public Pinballinput input;
    public Ball ball;
    public Flipper RightFlipper;
    public Flipper LeftFlipper;
    public BumperGone Bumpers_all;
    private bool isGhost = false;
    
    //creates a instance of game
    public static Game Instance { get; private set; }    

 
    void Awake(){
        //this runs on program launch and makes a new instance of pinball input and enables and then makes the instance equal to the current instance
        input = new Pinballinput();
        input.Enable();
        Instance = this;
        
    }

    // this whole function is updated every frame and just checks if the certain key was pressed and will run the code inside if it has
    void Update(){
        if (Input.GetKey(KeyCode.LeftArrow)){
            LeftFlipper.Flip();
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            RightFlipper.Flip();
        }

        //launches the ball then disables the key for it disables the  spacebar on first ball launch
        if (input.Default.LaunchBall.WasReleasedThisFrame()){
            ball.Launch();
            Game.Instance.input.FindAction("Launch Ball").Disable();
        }
        else if(input.Default.RightFlipper.WasPressedThisFrame()){
            RightFlipper.Flip();
        }
        else if (input.Default.LeftFlipper.WasPressedThisFrame()){
            LeftFlipper.Flip();
        }
        //this will turn on and off all bumper meshes with the G key
        else if (input.Default.Ghost.WasPressedThisFrame()){
            if (isGhost){
                Bumpers_all.TurnOnMesh();
                isGhost = false;
            }
            else{
                Bumpers_all.TurnOffMesh();
                isGhost = true;
            }
           
        }

    }
}
