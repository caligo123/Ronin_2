using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usermove : MonoBehaviour
{

    public stickv value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(value.sticktouch);
    }
}
    