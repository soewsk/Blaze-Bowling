using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using DG.Tweening;
public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _scoreText;
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private Transform[] _points;
    [SerializeField] private float _time = 5f;
    private bool _menuOpen = false;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _menuOpen = !_menuOpen;

            _scoreText.SetActive(!_menuOpen);
            _menuPanel.SetActive(true);

            Vector3[] path = new Vector3[_points.Length];
            if (_menuOpen)
            {
                for (int i = 0; i < _points.Length; i++)
                {
                    path[i] = _points[i].position;
                }
                _menuPanel.transform.DOPath(path, _time);
            }
             
            else
            {
                
                for (int i = 0; i < _points.Length; i++)
                {
                    path[i] = _points[_points.Length - 1 - i].position;
                }

                _menuPanel.transform.DOPath(path, _time);
            }

        }
    
    
    }
    public void BackBut()
    {
       
        SceneManager.LoadScene("MenuScene");
        
    }
    public void RestartBut()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
