using UnityEngine;

public class BottomPipeScript : MonoBehaviour
{
    public float dropSpeed;
    bool shouldMove = false;
    public GameObject bottomPipe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldMove)
        {
            while (bottomPipe.transform.position.y > -39.1)
            {
                bottomPipe.transform.position = bottomPipe.transform.position + (Vector3.down * dropSpeed) * Time.deltaTime;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            shouldMove = true;
        }
    }
}
