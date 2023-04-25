using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void LateUpdate() // "LateUpdate" is called once per frame (as "Update"), but it runs after all other updates.
    {
        transform.position = player.transform.position + offset;
    }
}