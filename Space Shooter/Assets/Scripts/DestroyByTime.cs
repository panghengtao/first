using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour {
    public float leftTime;
    void Start()
    {
        Destroy(gameObject,leftTime);
    }
}
