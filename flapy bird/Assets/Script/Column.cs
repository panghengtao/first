using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour {
    private void OnTriggerEnter2D()
    {
        Debug.Log("OnTriggerEnter2D");
        if (GameConller.instance.birdInstantiated)
        {
            GameConller.instance.BirdScored();
        }
    }
}
