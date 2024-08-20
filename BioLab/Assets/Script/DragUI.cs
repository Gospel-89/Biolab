
using UnityEngine;

public class DragUI : MonoBehaviour
{
    public Transform pointer; // The transform representing the pointer (e.g., mouse or touch position)
    public bool x; // Option to include dragging along the x-axis
    public bool y; // Option to include dragging along the y-axis
    public bool z; // Option to include dragging along the z-axis

    public void Drag()
    {
        float newX = x ? pointer.position.x : transform.position.x;
        float newY = y ? pointer.position.y : transform.position.y;
        float newZ = z ? pointer.position.z : transform.position.z;

        transform.position = new Vector3(newX, newY, newZ);
    }
}