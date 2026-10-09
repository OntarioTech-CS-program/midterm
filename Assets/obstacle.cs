using UnityEngine;

public class obstacle : MonoBehaviour
{
    public bool moving = true;

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            transform.position = new Vector3(transform.position.x +0.1f, transform.position.y, transform.position.z);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            Debug.Log("hitplayer");
            Material shader = GetComponent<Renderer>().material;
            shader.SetFloat("specular", 0f);
            moving = false;
        }
    }
    
    
}
