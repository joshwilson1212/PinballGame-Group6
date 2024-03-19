using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour{
    //name might be slightly messed up but its lowercase
    private Pinballinput input;
    public Ball ball;
    public Flipper RightFlipper;
    public Flipper LeftFlipper;
    public bool LeftFlipper_up;
    public bool RightFlipper_up;

    // Start is called before the first frame update
    void Start(){
        input = new Pinballinput();
        input.Enable();
        
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.LeftArrow)){
            LeftFlipper.Flip();
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            RightFlipper.Flip();
        }


        if (input.Default.LaunchBall.WasReleasedThisFrame()){
            ball.Launch();
        }
        else if(input.Default.RightFlipper.WasPressedThisFrame()){
            RightFlipper.Flip();
            
        }
        else if (input.Default.LeftFlipper.WasPressedThisFrame())
        {
            LeftFlipper.Flip();
        }

    }
}
