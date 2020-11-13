using UnityEngine;
public class Draggable : MonoBehaviour
{
    public bool dragging;
    private Transform objectToMove;
    private void Start()
    {
        objectToMove = GetComponent<Transform>();
    }
    private void OnMouseDown()
    {
        dragging = true;
    }
    private void OnMouseUp()
    {
        dragging = false;
    }
    private void Update()
    {
        if (dragging == true)
        {
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            objectToMove.transform.position = worldPosition;
        }
    }
}
