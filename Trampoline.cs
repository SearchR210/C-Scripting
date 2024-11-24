using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{

    void OnTriggerrEnter(Collider other)
    {
        // Жалуется на Jump
        //other.GetComponent<Jump>().jumpStreath = 10; 
    }

    void OnTriggerrExit(Collider other)
    {
        // Жалуется на Jump
        //other.GetComponent<Jump>().jumpStreath = 2;
    }
}
