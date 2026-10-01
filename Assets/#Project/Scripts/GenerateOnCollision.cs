using UnityEngine;

public class GenerateOnCollision : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    private float valY = 6f;

    private int count;

    // Update is called once per frame
    void OnCollisionEnter(Collision collisions)
    {
        
        if(count == 2)
        {
            float valX = Random.Range(-4, 4);
            float valZ = Random.Range(-4, 4);
            Vector3 vector3 = new Vector3(valX, valY, valZ);

            GameObject clonePrefab = Instantiate(prefab, vector3, Quaternion.identity);

            count = 0;
        } else {
            count += 1;
        }
        
    }
}
