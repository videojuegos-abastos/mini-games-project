using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    [SerializeField]
    GameObject objectToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Las dimensiones de la pantalla son {Screen.width} x {Screen.height}.");
    }

    // Update is called once per frame
    void Update()
    {


        bool spacePressed = Input.GetKeyDown("space");

        if (spacePressed)
        {
            SpawnObject();
        }
        
        

    }


    void SpawnObject()
    {

        Vector2 random = new Vector2 (Random.Range(0, Screen.width), Random.Range(0, Screen.height));

        Vector2 v = Vector2.zero;

        switch (Random.Range(0, 4))
        {
            case 0:
                v = new Vector2(random.x, 0);
                break;
            case 1:
                v = new Vector2(random.x, Screen.height);
                break;
            case 2:
                v = new Vector2(0, random.y);
                break;
            case 3:
                v = new Vector2(Screen.width, random.y);
                break;
        }

        v = Camera.main.ScreenToWorldPoint(v);


        Instantiate(objectToSpawn, (Vector3) v, Quaternion.identity);
    
    }

}
