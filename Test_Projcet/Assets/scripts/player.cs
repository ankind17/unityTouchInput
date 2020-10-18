using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    [SerializeField] private GameObject character;
    [SerializeField] private float speed = 60f;

    void Start()
    {
        Input.multiTouchEnabled = false;
    }


    void FixedUpdate()
    {
        if (Input.touchCount == 1 ||( Input.GetTouch(0).phase == TouchPhase.Moved))
        {

            Vector3 target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
            character.transform.Translate(Vector3.MoveTowards(character.transform.position, target, speed * Time.deltaTime) - character.transform.position);

        }

        if(transform.position.x <= -3)
        {
            transform.position = new Vector3(-3, transform.position.y, transform.position.z);
        }
        else if(transform.position.x >= 3)
        {
            transform.position = new Vector3(3, transform.position.y, transform.position.z);
        }
    }
}
