using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWaypoint : MonoBehaviour {

    public Transform followObject1;
    private Vector3 moveTemp;
    public float offsetY1 = 2;
    public float offsetX1 = 2;

    // Use this for initialization
    void Start () {
        moveTemp = followObject1.transform.position;
    }
    
    // Update is called once per frame
    void Update () {
        moveTemp = followObject1.transform.position;
        moveTemp.y += offsetY1;
        moveTemp.x += offsetX1;
        moveTemp.z = transform.position.z;
        transform.position = moveTemp;
    }
}