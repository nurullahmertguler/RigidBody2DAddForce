using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToGear : MonoBehaviour
{
    public Transform Arrow;
    public Rigidbody2D GearRB;
    public GameObject destroyArrowObj;
    bool start;
    public float ForcePower;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !start)
        {
            AddForceGearFunc();
        }
        
    }
    void AddForceGearFunc()
    {
        GearRB.AddForce(Arrow.transform.TransformDirection(Vector3.right) * ForcePower);
        start = true;
        Destroy(destroyArrowObj);
    }
}
