using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public float pLerp;
    public float rLerp;

    public Transform target;

    private void FixedUpdate() 
    {
        transform.position = new Vector3(target.position.x, Mathf.Lerp(transform.position.y, target.position.y, Time.deltaTime * pLerp), target.position.z);
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(target.rotation.eulerAngles.x , target.rotation.eulerAngles.y, 0), rLerp);
    }
}
