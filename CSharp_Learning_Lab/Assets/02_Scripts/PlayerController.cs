using UnityEngine;

public class PlayerController : MonoBehaviour
{
    


    void Start()
    {
        //Vector3 newPos = transform.position;
        //Vector3 newPos = this.gameObject.GetComponent<Transform>().position; //(x, y, z) = (1, 1, 1)
        //newPos.x = newPos.x + 5;
        //this.gameObject.GetComponent<Transform>().position = newPos;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position
            transform.Translate(0f, 0.05f, 0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.position
            transform.Translate(0f, -0.05f, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.position
            transform.Translate(-0.05f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //transform.position
            transform.Translate(0.05f, 0f, 0f);
        }
    }
}