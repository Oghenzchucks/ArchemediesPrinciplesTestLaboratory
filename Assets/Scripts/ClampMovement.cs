using UnityEngine;

public class ClampMovement : MonoBehaviour {
    
    private Vector3 offset;
    private Vector3 screenPoint;

    public Vector2 panLimit;
    
    void OnMouseDown() {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(screenPoint.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag() {
        Vector3 curScreenPoint = new Vector3(screenPoint.x, Input.mousePosition.y, screenPoint.z);
        transform.position = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;

        Vector3 pos = gameObject.transform.position;
        
        pos.y = Mathf.Clamp(pos.y, -panLimit.y, panLimit.y);

        gameObject.transform.position = pos;
    }
}