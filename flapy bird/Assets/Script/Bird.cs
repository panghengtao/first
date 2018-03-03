using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    public float upForce = 200f;

    private bool isDead = false;
    private Rigidbody2D rd2d;
    private Animator anim;

	// Use this for initialization
	void Start () 
    {
        GameConller.instance.birdInstantiated = true;
        rd2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
    {
		if(!isDead)
        {
            if(Input.GetMouseButton(0))
            {
                rd2d.velocity = Vector2.zero;
                rd2d.velocity = (new Vector2(0, upForce));

                anim.SetTrigger("Flap");
            }
        }
	}

    void OnCollisionEnter2D()
    {
        GameConller.instance.birdInstantiated = false;
        rd2d.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");

        GameConller.instance.BirdDied();
    }

}
