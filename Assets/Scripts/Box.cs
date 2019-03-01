using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {
    [SerializeField]
    bool Floating;
    [SerializeField]
    float FloatingSpeed;
    [SerializeField]
    float FloatDistance;
    [SerializeField]
    bool Rotate;
    [SerializeField]
    Vector3 RotSpeed;
    [SerializeField]
    bool sinX, sinY, sinZ;
    
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if(Floating)
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y + Mathf.Sin(Time.time * FloatingSpeed) * FloatDistance,
                transform.position.z);
        }

        if (Rotate)
        {
            Vector3 tSpeed = new Vector3();

            tSpeed.x = sinX ? Mathf.Sin(Time.time * RotSpeed.x) : RotSpeed.x;
            tSpeed.y = sinY ? Mathf.Sin(Time.time * RotSpeed.y) : RotSpeed.y;
            tSpeed.z = sinZ ? Mathf.Sin(Time.time * RotSpeed.z) : RotSpeed.z;

            transform.Rotate(tSpeed);
        }
        
    }
}
