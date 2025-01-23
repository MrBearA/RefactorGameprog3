using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{

    [SerializeField] private KeyCode forwardKey = KeyCode.W;
    [SerializeField] private KeyCode backwardKey = KeyCode.S;
    [SerializeField] private KeyCode leftKey = KeyCode.A;
    [SerializeField] private KeyCode rightKey = KeyCode.D;

    public Vector3 GetInputVector()
    {
        float xInput = 0;
        float zInput = 0;

        if (Input.GetKey(forwardKey)) zInput++;
        if (Input.GetKey(backwardKey)) zInput--;
        if (Input.GetKey(leftKey)) xInput--;
        if (Input.GetKey(rightKey)) xInput++;

        return new Vector3(xInput, 0, zInput);
    }
}
