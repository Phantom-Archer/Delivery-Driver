using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform followTarget;
    
    Vector3 offset;
    void Start()
    {
        offset = new Vector3(0, 0, -10);
    }
    void LateUpdate()
    {
        transform.position = followTarget.transform.position + offset;
    }
}
