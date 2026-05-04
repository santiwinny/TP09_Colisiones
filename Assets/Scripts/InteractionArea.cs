using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Hubo colisión");
    }
}
