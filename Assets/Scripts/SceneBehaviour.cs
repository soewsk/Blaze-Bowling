using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using DG.Tweening;

public class SceneBehaviour : MonoBehaviour
{
    
    [SerializeField] private GameObject _chooseButtons;
    [SerializeField] private AudioSource _butAudio;
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _time = 5f;
    [SerializeField] private GameObject _startButton;

    public void Start()
    {
        Vector3[] path = new Vector3[_points.Length];
        for (int i = 0; i < _points.Length; i++)
        {
            path[i] = _points[i].position;
        }
        _startButton.transform.DOPath(path, _time);
    }

    public void StartBut()
    {
        ChooseMode();
        _butAudio.Play();
    }
    public void ExitBut()
    {
        Application.Quit();
        Debug.Log("Exit!!!!!");
        _butAudio.Play();
    }
    public void EasyModeBut()
    {
        SceneManager.LoadScene("BoulingEasyModeScene");
        _butAudio.Play();
    }
    public void HardModeBut()
    {
        SceneManager.LoadScene("BoulingHardMode");
        _butAudio.Play();
    }
    
    
    public void ChooseMode()
    {
        _startButton.SetActive(false);
       
        _chooseButtons.SetActive(true);
    }



}
