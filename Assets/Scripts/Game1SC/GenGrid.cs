using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenGrid : MonoBehaviour
{
    public AudioSource aus;
    public int cols = 3;
    public int rows = 3;
    public float size = 1f;
    public GameObject go;
    public Camera cam;
    
   
    // Start is called before the first frame update

    public void Awake()
    {
       
        generate();
    }
  
    
    public void generate()
    {
        aus.Play();
        if (GetComponent<Controllr>().level > 2)
        { cols=4; rows=4; }

        if (GetComponent<Controllr>().level > 4)
        { cols = 5; rows = 5; }

        if (GetComponent<Controllr>().level > 6)
        { cols = 6; rows =6; }

        transform.position = new Vector2(0, 0);
        
        if (cols == 3)
            cam.orthographicSize = 2.5f;

        if (cols == 4)
            cam.orthographicSize = 2.7f;

        if (cols == 5)
            cam.orthographicSize = 3.5f;

        if (cols == 6)
            cam.orthographicSize = 4.2f;

        for (int i=0;i<cols;i++)
        {
            for(int j=0;j<rows;j++)

            {
                GameObject tile =Instantiate(go, transform);

                float posx = i * size;
                float posy = j * -size;

                tile.transform.position = new Vector2(posx, posy);
            }

            
        }

        //if (cols == 3)
        //    transform.position = new Vector2(-1, 1);
        //if (cols == 4)
        //    transform.position = new Vector2(-1.5f, 1.5f);
        //if (cols == 5)
        //    transform.position = new Vector2(-2f, 2f);
        //if (cols == 6)
        //    transform.position = new Vector2(-2.5f, -2.5f);

        transform.position = new Vector2(-0.5f * (cols - 1), 0.5f * (cols - 1));

        





        //Destroy(go);


    }
}
