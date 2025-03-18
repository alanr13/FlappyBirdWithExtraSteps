using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public GameObject arrow;
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Instantiate(arrow, new Vector3(player.transform.position.x+3, player.transform.position.y-1), transform.rotation);
            }
        }
    }
}
