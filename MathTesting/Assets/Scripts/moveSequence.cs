using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class moveSequence : MonoBehaviour {

    public Material ironMan;

    public static int count = 1;
 
    public Text countText;

    public GameObject epsilonBall;
    public float radiusCount = 1;

	private void Start()
	{
        
        epsilonBall.SetActive(false);
        epsilonBall.transform.localScale = new Vector3(radiusCount,1,1);

        SetText(); 
	}

	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){


            count++;

            GameObject newSphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            newSphere.transform.localScale = new Vector3((float).3, (float).3, (float).3);
            newSphere.transform.position = new Vector3 (0, 0, (float)-10 / (float)count);

            newSphere.GetComponent<Renderer>().material = ironMan;

            SetText();

        }


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
           
            radiusCount = (float)radiusCount * 2;
            epsilonBall.SetActive(true);
            epsilonBall.transform.localScale = new Vector3(1, radiusCount, 1);

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            
            radiusCount = (float) radiusCount / 2;
            epsilonBall.SetActive(true);
            epsilonBall.transform.localScale = new Vector3(1, radiusCount, 1);
        }

    }

    void SetText()
    {
        countText.text = "Term: 1/" + count.ToString();
    }
}
