using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceUI : MonoBehaviour
   
{
    public Transform PlayerPosition;
    public float player_obj_distance;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        Text myText = this.GetComponent<Text>();
        if (Vector3.Distance(transform.position, PlayerPosition.transform.position) >= player_obj_distance)
        {
            myText.color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
            
        }
        else
        {
            myText.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
            
        }
    }
}
