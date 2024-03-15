using UnityEngine;

namespace DefaultNamespace
{
    public class DuckSpawner : MonoBehaviour
    {
        [SerializeField] private float minDelay;
        [SerializeField] private float maxDelay;
        [SerializeField] private GameObject[] Ducks;
        void Start()
        {
            Invoke(nameof(Spawn),Random.Range(minDelay,maxDelay));
        }

        void Spawn()
        {
            Instantiate(Ducks[Random.Range(0, Ducks.Length)], transform.position, Quaternion.identity);
            Invoke(nameof(Spawn),Random.Range(minDelay,maxDelay));
        }
    }
}