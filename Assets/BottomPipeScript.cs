using UnityEngine;

public class BottomPipeScript : MonoBehaviour
{
    public float dropSpeed;
    bool shouldMove = false;
    public GameObject bottomPipe;
    public GameObject topPipe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldMove)
        {
            bottomPipe.transform.position = bottomPipe.transform.position + (Vector3.down * dropSpeed) * Time.deltaTime;
            if(Vector3.Distance(bottomPipe.transform.position, topPipe.transform.position) >= 47.6)
            {
                shouldMove = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            shouldMove = true;
        }
    }
}
