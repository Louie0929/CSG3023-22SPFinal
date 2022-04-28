/**** 
 * Created by: Bob Baloney
 * Date Created: April 20, 2022
 * 
 * Last Edited by: Xingzhou Li
 * Last Edited: 4/28/2022
 * 
 * Description: Paddle controler on Horizontal Axis
****/

/*** Using Namespaces ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10; //speed of paddle
    Vector3 pos;


    // Update is called once per frame
    void Update()
    {
        pos = transform.localPosition;
        pos.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        transform.localPosition = pos;


        

    }//end Update()
}
