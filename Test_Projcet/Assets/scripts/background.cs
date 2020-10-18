using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class background : MonoBehaviour
{

    public Transform bg1;
    public Transform bg2;
    private float size = 32;
    
    private Vector3 bg1TargetPos = new Vector3();
    private Vector3 bg2TargetPos = new Vector3();
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

     void FixedUpdate()
    {
     if(transform.position.y >= bg2.position.y)
        {
            bg1.position = SetPos(bg1TargetPos, bg1.position.x, bg2.position.y + size, bg1.position.z);
            SwitchBG();
        }
        if (transform.position.y < bg1.position.y)
        {
            bg2.position = SetPos(bg2TargetPos, bg2.position.x, bg1.position.y -size, bg2.position.z);
            SwitchBG();
        }
    }
    private void SwitchBG()
    {
        Transform temp = bg1;
        bg1 = bg2;
        bg2 = temp;
    }
    private Vector3 SetPos(Vector3 pos, float x, float y, float z)
    {
        pos.x = x;
        pos.y = y;
        pos.z = z;
        return pos;
    }
}
