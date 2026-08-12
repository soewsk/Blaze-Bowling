using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _leftBorder;
    [SerializeField] private float _rightBorder;
    [SerializeField] private float _rotateSpeed = 50f;
    private int _direction = 1;  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
        
        
    }
    public void Move()
    {
        Vector3 pos = transform.position;
        pos.z += _speed * Time.deltaTime * _direction;
        transform.position = pos;
        if (transform.position.z >= _rightBorder)
        {
            _direction = -1;

        }
        if (transform.position.z <= _leftBorder)
        {
            _direction = 1;
        }
    }
    public void Rotate()
    {
        transform.Rotate(0, _rotateSpeed * Time.deltaTime, 0);
    }

}
