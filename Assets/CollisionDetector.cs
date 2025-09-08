using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public GameObject particles;
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Instantiate(particles, transform.position, transform.rotation);
    }
}