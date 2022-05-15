using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;

    public float FillSpeed;
    private float targetProgess = 0;


    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }


    // Start is called before the first frame update
    void Start()
    {
        IncrementProgress(100f);
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value < targetProgess)
        {
            if (slider.value < 0)
            {
                slider.value = 1;
            }else
            {
                if (GameController.instance.pain == true)
                {
                    slider.value += (GameController.instance.TotalScore * Time.deltaTime);
                    StartCoroutine(On());
                    GameController.instance.pain = false;
                }
                else
                {
                    slider.value += FillSpeed * Time.deltaTime;
                }
            }   
        }

    }

    public void IncrementProgress(float newProgress)
    {
        targetProgess = slider.value + newProgress;
    }

    IEnumerator On()
    {
        yield return new WaitForSeconds(1f);
    }
}
