using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class XsiO : MonoBehaviour
{
    public static int player = 0, won=0, ord=1, i, j;
    public int lin, col;
    public static int[,] matrix = new int[3, 3];
    public static int[,] ordine = new int[3, 3];
    private void OnMouseDown()
    {
        if (won != 1 && matrix[lin, col]==0)
        {

            matrix[lin, col] = player + 1;
            Debug.Log(lin + "," + col + "=" + ord);
            ordine[lin, col] = ord;
            ord++;

            if (player == 0)
                GetComponent<TMP_Text>().text = "X";
            else
                GetComponent<TMP_Text>().text = "O";

            for (i = 0; i < 3; i++)
            {
                if (matrix[i, 0] == player + 1 && matrix[i, 1] == player + 1 && matrix[i, 2] == player + 1)
                {
                    won = 1;
                    Debug.Log("Player-ul " + player + "a castigat!!!");
                }

                if (matrix[0, i] == player + 1 && matrix[1, i] == player + 1 && matrix[2, i] == player + 1)
                {
                    won = 1;
                    Debug.Log("Player-ul " + player + "a castigat!!!");
                }
            }

            if (matrix[0, 0] == player + 1 && matrix[1, 1] == player + 1 && matrix[2, 2] == player + 1)
            {
                won = 1;
                Debug.Log("Player-ul " + player + "a castigat!!!");
            }

            if (matrix[0, 2] == player + 1 && matrix[1, 1] == player + 1 && matrix[2, 0] == player + 1)
            {
                won = 1;
                Debug.Log("Player-ul " + player + "a castigat!!!");
            }

            if(won==1)
            {
                for(i=0; i<3; i++)
                    for(j=0; j<3; j++)
                        GameObject.Find("C" + i + j).GetComponent<TMP_Text>().text = " ";
                if (player==0)
                    GameObject.Find("Finish").GetComponent<TMP_Text>().text = "Playerul X a castigat!!!";
                else
                    GameObject.Find("Finish").GetComponent<TMP_Text>().text = "Playerul O a castigat!!!";
            }

            if (player == 0)
                player = 1;
            else
                player = 0;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            for(i=0; i<3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    GameObject.Find("C" + i + j).GetComponent<TMP_Text>().text = " ";
                    matrix[lin, col] = 0;
                    ordine[lin, col] = 0;
                }
            }
            ord = 1;
            player = 0;
        }
    }
}
