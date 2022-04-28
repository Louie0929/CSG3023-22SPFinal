/**** 
 * Created by: Bob Baloney
 * Date Created: April 20, 2022
 * 
 * Last Edited by: Xingzhou Li  
 * Last Edited: 4/28/2022
 * 
 * Description: Controls the ball and sets up the intial game behaviors. 
****/

/*** Using Namespaces ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ball : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField]
    private bool isInPlay;
    private AudioSource audioSourse;

    [Header("Set Dynamically")]
    public Text txt_Lives;
    public Text txt_Score;

    [Header("General Settings")]
    public GameObject paddle;
    static public int score;


    [Header("Ball Settings")]
    public float speed = 10f;
    public int numberOfBalls;
    public Vector3 intialForce;



    //Awake is called when the game loads (before Start).  Awake only once during the lifetime of the script instance.
    void Awake()
    {
        Rigidbody rb;
        AudioSource AudioSouce;
    }//end Awake()


        // Start is called before the first frame update
        void Start()
    {
        SetStartingPos(); //set the starting position

    }//end Start()


    // Update is called once per frame
    void Update()
    {
        GetGameStats();
        SetHUD();
    }//end Update()

    void GetGameStats()
    {
        //txt_Lives = numberOfBalls;
        //txt_Score = score;
    }

    void SetHUD()
    {

    }

    private void LateUpdate()
    {


    }//end LateUpdate()


    void SetStartingPos()
    {
        //isInPlay = false;//ball is not in play
       // rb.velocity = Vector3.zero;//set velocity to keep ball stationary

        Vector3 pos = new Vector3();
        //pos.x = paddle.transform.position.x; //x position of paddel
       // pos.y = paddle.transform.position.y + paddle.transform.localScale.y; //Y position of paddle plus it's height

        transform.position = pos;//set starting position of the ball 
    }//end SetStartingPos()






}
