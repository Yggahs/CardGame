using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragging : MonoBehaviour {

    float distance = 10;
    Vector3 objStartPosition;

    private void Start()
    {
        objStartPosition = gameObject.transform.position;
    }

    void OnMouseDrag()
    {
        // camera should be tagged as mainCamera, otherwise you should reference it above.
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
        distance_to_screen));
    }
    private void Update()
    {
        if(gameObject.transform.position.z > -1 )
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
        Debug.Log(gameObject.transform.position.x);
    }
}
