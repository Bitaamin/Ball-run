
using UnityEngine;

public class Dragable : MonoBehaviour
{
    Vector3 MousePositionOffset;

    public Vector3 GetMouseWorldPosition(){
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void OnMouseDrag(){
        transform.position = GetMouseWorldPosition() + MousePositionOffset;
    }
}
