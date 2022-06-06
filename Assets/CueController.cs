using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueController : MonoBehaviour
{
    private Vector3 stickPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            stickPoint = new Vector3(raycastHit.point.x, transform.position.y, raycastHit.point.z);

            if (Input.GetMouseButton(0))
            {
                var position = Input.mousePosition;
                transform.position = stickPoint;
            }

        }


    }

    void FixedUpdate()
    {

       


    }
}
