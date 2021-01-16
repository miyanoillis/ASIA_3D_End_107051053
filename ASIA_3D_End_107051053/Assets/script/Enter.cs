using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public enmy tigger;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            tigger.a = true;
            print("a");
        }
    }
}
