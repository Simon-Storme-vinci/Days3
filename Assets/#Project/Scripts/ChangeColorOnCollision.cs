using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class ChangeColorOnCollision : MonoBehaviour
{
    private TagHandle _playerTag;
    private Renderer renderer;
    [SerializeField] private List<Color> colors;
    private int indexColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    public void Onable()
    {
        _playerTag = TagHandle.GetExistingTag("Ground");        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        // foreach(ContactPoint contact in collision.contacts) {
            if(collision.collider.CompareTag(_playerTag)){
                return;
            }

            if(colors.Count == 0) {
                return;
            }

            if(indexColor == colors.Count) {
                indexColor = 0;
            }

            renderer.material.color = colors[indexColor];
            indexColor++;
        // }
        
    }
}
