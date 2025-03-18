using UnityEngine;

public class ArrowFire : MonoBehaviour
{
    public float arrowSpeed;
    float deadZone = 27.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.right * arrowSpeed) * Time.deltaTime;
        if(transform.position.x > deadZone )
        {
            Destroy(gameObject);
            Debug.Log("Arrow destroyed");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            Destroy(gameObject);
        }
    }
}
