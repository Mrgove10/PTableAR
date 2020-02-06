using UnityEngine;
using System.Collections;
 
public class Orbit : MonoBehaviour {
     
    public GameObject CenterObj;
    private Transform center;
    public float radius;
    public float rotationSpeed;
 
    void Start () {
        center = CenterObj.transform;
        transform.position = (transform.position - center.position).normalized * radius + center.position;
    }
     
    void Update () {
        transform.RotateAround(center.position, center.up, rotationSpeed * Time.deltaTime);
        //   var desiredPosition = (transform.position - center.position).normalized * radius + center.position;
        // transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime);
    }
}