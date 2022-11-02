using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime to make sure that the animation runs at the same speed on every device
        transform.Rotate(new Vector3(0f, 200f, 0f) * Time.deltaTime);   
    }
}
