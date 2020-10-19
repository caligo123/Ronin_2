﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class atkc : MonoBehaviour, IPointerDownHandler,IPointerUpHandler,IDragHandler
{
    [SerializeField] private RectTransform rect_p;
    [SerializeField] private RectTransform rect_c;

    [SerializeField] private GameObject sword;
    [SerializeField] private float movespd;

    private float radius;

    private bool is_touch = false;
    private Vector3 move_position;



    Vector2 v;



    // Start is called before the first frame update
    void Start()
    {
        radius = rect_p.rect.width * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {

        if (is_touch)
        {

            if (move_position.x > 0)
            {
                sword.transform.localScale = new Vector3(1, 1, 1);
            }
            else if (move_position.x < 0)
            {
                sword.transform.localScale = new Vector3(-1, 1, 1);
            }


            /*/
            if (move_position.x > 0 || move_position.y < 0)
            {
                anim.SetBool("x", true);
            }
            else anim.SetBool("x", is_touch);
            //*/
        }
        else;
        {
            transform.position = new Vector2(base.transform.position.x, base.transform.position.y + 5);
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
        }
    }




    public void OnDrag(PointerEventData eventData)
    {
      
        v = eventData.position - (Vector2)rect_p.position;
        v = Vector2.ClampMagnitude(v, radius);
        rect_c.localPosition = v;

        float dist = Vector2.Distance(rect_p.position, rect_c.position)/radius;


        v = v.normalized;
        move_position = new Vector3(v.x * movespd *dist, v.y * movespd*dist,0f );

        //user.transform.position += move_position;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        is_touch = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        is_touch = false; 
        rect_c.localPosition = Vector3.zero;
        move_position = Vector3.zero;
    }




}