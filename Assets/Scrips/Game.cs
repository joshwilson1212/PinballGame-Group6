using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour{
    //name might be slightly messed up but its lowercase
    [HideInInspector] public Pinballinput input;
    public Ball ball;
    public Flipper RightFlipper;
    public Flipper LeftFlipper;
    public Bumper bumper;
    public Bumper bumper2;
    public Bumper bumper3;
    public Bumper bumper4;
    
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


        if (input.Default.LaunchBall.WasReleasedThisFrame()){
            ball.Launch();

            //disables the  spacebar on first ball launch
            Game.Instance.input.FindAction("Launch Ball").Disable();

        }
        else if(input.Default.RightFlipper.WasPressedThisFrame()){
            RightFlipper.Flip();
            
        }
        else if (input.Default.LeftFlipper.WasPressedThisFrame())
        {
            LeftFlipper.Flip();
        }
        else if (input.Default.Ghost.WasPressedThisFrame()){
            //print("ghost key in game script");
            bumper.Ghost();
            bumper2.Ghost();
            bumper3.Ghost();
            bumper4.Ghost();
        }

    }
}
