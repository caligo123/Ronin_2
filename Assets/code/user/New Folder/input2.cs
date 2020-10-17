using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input2 : MonoBehaviour
{
    float userspd = 1;


    public float hsp;
    public float vsp;

    Touch touch;
    float screenMid;

    float downtime;
    float uptime;

    user self;
    GameObject moveinput;

    // Start is called before the first frame update
    void Start()
    {
        screenMid = Screen.width / 2;
        self = gameObject.GetComponent<user>();
        moveinput = GameObject.Find("movep");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)//터치 1개 이상
        {
            downtime = Time.time;

            hsp = 0;
            vsp = 0;

            for (int i = 0; i < Input.touchCount; i++)
            {
                touch = Input.GetTouch(i);

                if (touch.phase == TouchPhase.Began && touch.position.x < screenMid)// 왼쪽 터치 && 터치 시작
                {
                    hsp = Mathf.Sign(moveinput.transform.position.x - touch.position.x);
                    vsp = Mathf.Sign(moveinput.transform.position.y - touch.position.y);

                    transform.Translate(new Vector3(hsp * self.spd * Time.deltaTime,0,0));


                    break;   //한 프레임(update)에는 하나만.

                }
                else if(touch.phase == TouchPhase.Began && touch.position.x > screenMid)
                {
                    continue;
                }



            }
        }

    }
}
