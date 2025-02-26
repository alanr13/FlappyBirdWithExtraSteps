using UnityEngine;

public class WingFlyScript : MonoBehaviour
{
    Animator wing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        wing = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (wing != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                wing.SetTrigger("Fly");
            }
            else
            {
                wing.SetTrigger("Idle");
            }
        }
    }
}
