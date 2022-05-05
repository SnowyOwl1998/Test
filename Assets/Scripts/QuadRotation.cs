using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadRotation : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 targetDir = target.position - transform.position;
        Vector3 fwd = transform.forward;
        float angle = Vector3.SignedAngle(targetDir, fwd, Vector3.right);
        print("Angle: " + angle);
        if (angle < 5.0f)
            print("turn left");
        else if (angle > 5.0f)
            print("turn right");
        else
            print("forward");
            
    }
}
