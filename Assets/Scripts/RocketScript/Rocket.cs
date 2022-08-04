
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float damage = 5f;

    void Start()
    {
        Destroy(gameObject, 5f);   
    }
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Hit(collision.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Hit(other.gameObject);
    }
    private void Hit(GameObject collissionGameObject)
    {
        if (collissionGameObject.TryGetComponent(out HealtManager health))
        {
            health.Hit(damage);
        }
        Destroy(gameObject);
    }
}
