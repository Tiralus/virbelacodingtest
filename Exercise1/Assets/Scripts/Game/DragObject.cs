namespace Game
{
    using UnityEngine;

    public class DragObject : MonoBehaviour
    {
        private Vector3 screenPoint;
        private Vector3 offset;

        private Camera cam;

        private void Start()
        {
            cam = Camera.main;
        }

        void OnMouseDown()
        {
            screenPoint = cam.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position -
                     cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }

        void OnMouseDrag()
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            Vector3 curPosition = cam.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }
}
