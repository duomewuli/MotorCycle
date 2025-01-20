using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public float followSpeed = 2f;
    public Transform target;
    public float plusx;
    public float plusy;

    // Update is called once per frame
    void Update()
    {
        Vector3 po = new Vector3 (target.position.x+plusx, target.position.y+plusy, -10f);
        transform.position = Vector3.Slerp(transform.position ,po,followSpeed*Time.deltaTime );
    }
}
