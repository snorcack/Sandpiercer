using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine;
using DentedPixel;
using UnityEngine.Rendering.Universal;
public class DayNightCycle : MonoBehaviour
{

    public Light2D headlight1;
    public Light2D headlight2;
    public Volume lightVolume;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchToDay ()
    {
        LeanTween.value(this.gameObject, SwitchDaylight, 1, 0,1f);
    }
    public void SwitchToNight()
    {
        LeanTween.value(this.gameObject, SwitchDaylight, 0, 1, 1f);
    }



    void SwitchDaylight (float value)
    {
        headlight1.intensity = value * 2;
        headlight2.intensity = value * 2;

        lightVolume.weight = value;
    }



}
