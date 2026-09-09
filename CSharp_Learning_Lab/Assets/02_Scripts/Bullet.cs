using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
    

    private void Start()
    {
        //Destroy(gameObject, 2);
        Invoke("DestroySelf", 2f);
    }
}
