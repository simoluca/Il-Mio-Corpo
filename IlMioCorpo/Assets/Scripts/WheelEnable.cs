using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelEnable : MonoBehaviour
{

    public GameObject wheel;

    public void Onclick()
    {
        wheel.SetActive(true);
    }
}
