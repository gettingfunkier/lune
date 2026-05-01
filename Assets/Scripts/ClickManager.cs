using UnityEngine;

public class ClickManager : MonoBehaviour
{
    Camera _camera;

    void Start()
    {
        _camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        CheckLeftClick();
    }

    private void CheckLeftClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Click!");
            Vector2 worldPoint = _camera.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero, Mathf.Infinity);

            if (hit.collider != null)
            {
                Debug.Log("Hit: " + hit.collider.name);
            }
        }
    }
}
