using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{

    void OnTriggerrEnter(Collider other)
    {
        // �������� �� Jump
        //other.GetComponent<Jump>().jumpStreath = 10; 
    }

    void OnTriggerrExit(Collider other)
    {
        // �������� �� Jump
        //other.GetComponent<Jump>().jumpStreath = 2;
    }
}
