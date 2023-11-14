using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float upperBound = 10f;
    public float lowerBound = -10f;
    private float camBounds;

    // Start is called before the first frame update
    void Start()
    {
        camBounds = Camera.main.orthographicSize;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerCam = target.transform.position + new Vector3(0, 0, -5);
        //Debug.Log("Cam Y: " + playerCam.y);
        if (playerCam.y - camBounds < lowerBound)
        {
            playerCam.y = lowerBound + camBounds;
        }
        else if (playerCam.y + camBounds > upperBound)
        {
            playerCam.y = upperBound - camBounds;
        }

        transform.position = playerCam;
    }


}