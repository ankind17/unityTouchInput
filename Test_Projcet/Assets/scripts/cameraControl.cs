
using UnityEngine;

public class cameraControl : MonoBehaviour
{
    public Transform traget1;


     void FixedUpdate()
    {
        Vector3 targetpos = new Vector3(transform.position.x, traget1.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetpos, 0.2f);
    }
}
