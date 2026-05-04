using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public ScoreUiManager scoreUIMgr;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Pickable"))
        {
           Debug.Log("Hubo colisión con un Pickable");
           Destroy(col.gameObject);
           scoreUIMgr.AddPointAndUpdateScoreUI(); 
        }
    }
}
