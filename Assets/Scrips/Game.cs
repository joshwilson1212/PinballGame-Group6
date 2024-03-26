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
    public int CurScore {  get; private set; }
    public int HighScore { get; private set; }

    /// <summary>
    /// Used for setting and getting PlayerPrefs values.
    /// Put any PlayerPrefs dictionary keys here
    /// </summary>
    


    void Awake(){
        //this runs on program launch and makes a new instance of pinball input and enables and then makes the instance equal to the current instance
        input = new Pinballinput();
        input.Enable();
        Instance = this;
    }

    public void Start()
    {
        // grab high score when game starts

        //FIX HERE
        HighScore = PlayerPrefs.GetInt("highScore", 0);
    }

    private void OnDisable()
    {
        // if game is disabled (for example if the player quits the game), save
        // the high score

        //FIX HERE
        PlayerPrefs.SetInt("highScore", HighScore);
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
            ball.SeeThrough();
           
        }

    }

    public void AddScore(int amt)
    {
        CurScore += amt;
        if (CurScore > HighScore)
        {
            HighScore = CurScore;
        }
    }

    public void ResetScore() 
    {
        Game.Instance.CurScore = 0;
    }

}
