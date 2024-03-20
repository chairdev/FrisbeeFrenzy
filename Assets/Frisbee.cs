using UnityEngine;

public class Frisbee : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 touchOffset;
    private float moveSpeed = 5f; // Adjust the speed as needed
    private float rightMovementSpeed = 1f; // Speed at which the frisbee moves to the right

    void OnMouseDown()
    {
        isDragging = true;
        touchOffset = transform.position - GetMouseWorldPos();
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    private void Update()
    {
        if (isDragging)
        {
            Vector3 targetPos = GetMouseWorldPos() + touchOffset;
            transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * 10f);
        }

        // Move to the right automatically
        transform.Translate(Vector3.right * Time.deltaTime * rightMovementSpeed);
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}
