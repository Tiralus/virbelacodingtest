namespace Game
{
    using UnityEngine;

    public class DragObject : MonoBehaviour
    {
        private Vector3 screenPoint;
        private Vector3 offset;

        private Camera camera;

        private void Start()
        {
            camera = Camera.main;
        }

        void OnMouseDown()
        {
            screenPoint = camera.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position -
                     camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }

        void OnMouseDrag()
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            Vector3 curPosition = camera.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }
}
