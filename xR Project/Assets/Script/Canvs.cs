using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvs : MonoBehaviour

{
    public Transform PlayerPosition;
    public float player_obj_distance;
    public GameObject MyPanel;

    // Start is called before the first frame update
    void Start()
    {
        MyPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        Text myText = this.GetComponent<Text>();
        if (Vector3.Distance(transform.position, PlayerPosition.transform.position) >= player_obj_distance)
        {
            MyPanel.SetActive(false);

        }
        else
        {
            MyPanel.SetActive(true);

        }
    }
}
