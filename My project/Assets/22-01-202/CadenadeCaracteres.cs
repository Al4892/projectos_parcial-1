using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadenadeCaracteres : MonoBehaviour
{
    public GameObject xd;
    public string data = "x:2, y:5, z:8";
    public Vector3 pos;
    private readonly int i;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < data.Length; i++)
        {
            if (data[i] == 'x')
            {
                int x= (int)char.GetNumericValue(data[i+2]);
              
                pos = new Vector3(x,pos.y,pos.z);
                
            }
            if (data[i] == 'y')
            {
                int y = (int)char.GetNumericValue(data[i + 2]);

                pos = new Vector3(pos.x, y, pos.z);
            }
            if (data[i] == 'z')
            {
                int z = (int)char.GetNumericValue(data[i + 2]);

                pos = new Vector3(pos.x, pos.y, z);
            }
            
        }
            Instantiate(xd,pos,Quaternion.identity);
        
    }

    
}
