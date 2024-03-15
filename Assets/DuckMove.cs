using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class DuckMove : MonoBehaviour
{

    [SerializeField] private float forceDif;
    [SerializeField] private Vector2 baseForce;
    private float birthTime;


    public void Shoot()
    {
        float scoreMultiplyer = 2 - (Time.timeSinceLevelLoad - birthTime);
        var multiplyer = scoreMultiplyer > 1 ? scoreMultiplyer = scoreMultiplyer : scoreMultiplyer = 1;
        
        Score.AddScore((int)(10 * scoreMultiplyer));
    }
    void Start()
    {
        birthTime = Time.timeSinceLevelLoad;
        GetComponent<Rigidbody2D>().velocity = new Vector2(baseForce.x * Random.Range(forceDif *-1,forceDif),baseForce.y);        
        Invoke(nameof(FlyAway),5);
    }

    void FlyAway()
    {
        Destroy(gameObject);
    }
}
