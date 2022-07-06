using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Undo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && XsiO.ord > 0)
        {
            for (XsiO.i = 0; XsiO.i < 3; XsiO.i++)
                for (XsiO.j = 0; XsiO.j < 3; XsiO.j++)
                {
                    if (XsiO.ordine[XsiO.i, XsiO.j] == XsiO.ord - 1)
                    {

                        Debug.Log(name + " " + XsiO.i + "," + XsiO.j + "=" + XsiO.ord);
                        XsiO.ordine[XsiO.i, XsiO.j] = 0;
                        XsiO.matrix[XsiO.i, XsiO.j] = 0;
                        GameObject.Find("C" + XsiO.i + XsiO.j).GetComponent<TMP_Text>().text = " ";
                    }
                }
            XsiO.ord--;
            if (XsiO.player == 0)
                XsiO.player = 1;
            else
                XsiO.player = 0;
        }
    }
}
