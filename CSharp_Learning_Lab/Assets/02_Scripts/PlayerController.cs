using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.05f;
    public GameObject BulletPrefab;
    public float BulletSpeed;

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
            transform.Translate(0f, speed, 0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.position
            transform.Translate(0f, -speed, 0f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //transform.position
            transform.Translate(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.position
            transform.Translate(-speed, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            /*
            GameObject bullet = Instantiate(BulletPrefab);
            bullet.transform.position = this.gameObject.transform.position + new Vector3(0f, 0.5f, 0f);
            bullet.GetComponent<Rigidbody>().AddForce(Vector3.up * BulletSpeed);

            GameObject bullet1 = Instantiate(BulletPrefab);
            bullet1.transform.position = this.gameObject.transform.position + new Vector3(0f, 1f, 0f);
            bullet1.GetComponent<Rigidbody>().AddForce(Vector3.up * BulletSpeed);

            GameObject bullet2 = Instantiate(BulletPrefab);
            bullet2.transform.position = this.gameObject.transform.position + new Vector3(0f, 1.5f, 0f);
            bullet2.GetComponent<Rigidbody>().AddForce(Vector3.up * BulletSpeed);
            */

            for (int i = 1; i <= 3; i++)
            {
                GameObject bullet = Instantiate(BulletPrefab);

                bullet.transform.position = this.gameObject.transform.position + new Vector3(0f, i * 0.5f, 0f);

                bullet.GetComponent<Rigidbody>().AddForce(Vector3.up * BulletSpeed);
            }
        }
        
            
        
    }
}