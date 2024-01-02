using UnityEngine;

public class DestroyOnBound : MonoBehaviour
{
    private float TopBound = 30f;
    private float BottomBound = -20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < BottomBound || transform.position.z > TopBound)
        {
            Destroy(gameObject);
        }
    }
}
