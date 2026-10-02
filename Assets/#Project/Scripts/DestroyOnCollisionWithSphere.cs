using UnityEngine;

public class DestroyOnCollisionWithSphere : MonoBehaviour
{
    private TagHandle _sphereTag;
    // Update is called once per frame

    void Start()
    {
        _sphereTag = TagHandle.GetExistingTag("Sphere");
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag(_sphereTag))
        {
            Destroy(gameObject);
        }

    }
}
