using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    float horizontalMouseMovement;
    public InputActionReference mouseInput;
    private float degreesPerSecond = 30f;
    public float sensitivityMultiplier = 1f;
    // Start is called before the first frame update
    void Start()
    {
        LockCursor();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMouseMovement = mouseInput.action.ReadValue<Vector2>().x;
        RotateWithMouse();
    }

    void RotateWithMouse() {
        transform.Rotate(0f, horizontalMouseMovement * sensitivityMultiplier * Time.deltaTime * degreesPerSecond, 0f, Space.Self);
    }

    void LockCursor(){
        Cursor.lockState = CursorLockMode.Locked;
    }
}
