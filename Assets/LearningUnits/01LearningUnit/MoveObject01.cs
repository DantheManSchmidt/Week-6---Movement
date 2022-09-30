using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject01 : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;
    Rigidbody RB;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void Update()
    {
        // My position equals my position PLUS 
        // where I want to be by the end of this frame...
        RB.AddTorque(moveDirection, ForceMode.Force);
    }
}
