using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //kercim rritet
        other.GetComponent<Jump>().jumpStrength = 10;

    }

    void OnTriggerExit(Collider other)
    {
        //kercimi reduktohet
        other.GetComponent<Jump>().jumpStrength = 2;

    }
}
