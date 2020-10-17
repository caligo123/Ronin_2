using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class user : MonoBehaviour
{
    Animator anim;

   public float spd;
    Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        spd = 1;
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
         
        
    }
}
