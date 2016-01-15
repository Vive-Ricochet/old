using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour {

    public GameObject target;
    Vector3 offset;

    // Called once at insertion into scene
    void Start () {
        offset = transform.position - target.transform.position;
    }

    // Late update called after update has finished so player script calculates position first
    void LateUpdate () {
        float desiredAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = target.transform.position - (rotation * offset);
        transform.LookAt(target.transform);
    }
}
