using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSlocker : MonoBehaviour
{



    void Awake()
    {
        Application.targetFrameRate = 30;
    }

   
}
