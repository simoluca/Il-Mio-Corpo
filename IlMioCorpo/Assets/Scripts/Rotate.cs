using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //this allows only one coroutine at a time to run
    private bool coroutineAllowed;

    void Start()
    {
        // set to true to coroutine can be started initially
        coroutineAllowed = true;
    }

    // method is invoked when mouse pointer is above object.
    // the collider helps to detect when this event occurs
    // when pointer is above the object and coroutine is allowed, start the animation
    private void OnMouseOver() {

        if (coroutineAllowed)
        {
            StartCoroutine("StartAnimation");
        }
        
    }

    private IEnumerator StartAnimation()
    {
        // initially set to false to a new coroutine will not start
        coroutineAllowed = false;

        /*
        each loop has 10 steps of 0.1 from 0 to 1
        */
        for (float i = 0f; i <= 1f; i += 0.1f)
        {
            transform.Rotate(new Vector3(0f, 300f, 0f) * Time.deltaTime);   
            yield return new WaitForSeconds(0.015f);
        }
        
        
         coroutineAllowed = true;

    }

    /*
    void Update()
    {
        //Time.deltaTime to make sure that the animation runs at the same speed on every device
        transform.Rotate(new Vector3(0f, 200f, 0f) * Time.deltaTime);   
    }
    */
}
