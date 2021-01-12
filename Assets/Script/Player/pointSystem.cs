using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointSystem : MonoBehaviour
{
    [SerializeField] GameObject pointsText;
    [SerializeField] string piontTag;
    [SerializeField] string audio;
    [SerializeField] string AudioManagerName;

    public int point;
    AudioManager Audiomanager;

    void Start()
    {
        Audiomanager = GameObject.Find(AudioManagerName).GetComponent<AudioManager>();
        point = 0;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == piontTag)
        {
            Destroy(other.gameObject);
            point++;
            pointsText.GetComponent<TMPro.TextMeshProUGUI>().text = point.ToString();
            Audiomanager.Play(audio);


        }
    }


}
