using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject AIM;
    private Camera camera;
    void Start()
    {
        camera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var hit = Physics2D.Raycast(camera.ScreenToWorldPoint(Input.mousePosition),
                camera.ScreenToWorldPoint(Input.mousePosition));
            if (hit.collider != null)
            {
                AIM.transform.position = hit.point;
                hit.collider.gameObject.GetComponent<DuckMove>().Shoot();
                Destroy(hit.collider.gameObject);
            }
            else
            {
                AIM.transform.position = new Vector3(100,100,0);
            }
        }
    }
}
