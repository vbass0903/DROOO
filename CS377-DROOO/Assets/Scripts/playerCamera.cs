using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class playerCamera : MonoBehaviour
{
    public GameObject[] players;
    public Vector3 offset;
    private Vector3 velocity;
    public float smoothTime = 0.5f;
    public float minZoom = 40f;
    public float maxZoom = 10f;
    public float zoomLimiter = 10f;

    private Camera cam;

    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
    }

    void LateUpdate()
    {
        if (players.Length == 0)
        {
            return;
        }

        Move();
        Zoom();
    }

    void Move()
    {
        offset = new Vector3(0f, 0f, -10f);
        Vector3 centerPoint = GetCenterPoint();
        Vector3 newPoint = centerPoint + offset;
        transform.position = Vector3.SmoothDamp(transform.position, newPoint, ref velocity, smoothTime);
    }

    void Zoom()
    {
        float newZoom = Mathf.Lerp(maxZoom, minZoom, GetGreatestDistance() / zoomLimiter);
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, newZoom, Time.deltaTime);
    }

    Vector3 GetCenterPoint()
    {
        if (players.Length == 1)
        {
            return players[0].transform.position;
        }

        var bounds = new Bounds(players[0].transform.position, Vector3.zero);
        for (int i = 0; i <players.Length; i++)
        {
            bounds.Encapsulate(players[i].transform.position);
        }

        return bounds.center;
    }

    float GetGreatestDistance()
    {
        var bounds = new Bounds(players[0].transform.position, Vector3.zero);
        for (int i = 0; i < players.Length; i++)
        {
            bounds.Encapsulate(players[i].transform.position);
        }

        return Mathf.Max(bounds.size.x, bounds.size.y);
    }
}
