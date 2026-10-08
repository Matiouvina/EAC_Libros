using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BibliotecaScript : MonoBehaviour
{
    public LibroScript[] libros;
    public GameObject cartelReservado;

    // Start is called before the first frame update
    void Start()
    {
        libros = FindObjectsOfType<LibroScript>();
        for(int i = 0; i<libros.Length; i++)
        {
            libros[i].color = Random.Range(1,6);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CheckIfReservedndReserve(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CheckIfReservedndReserve(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CheckIfReservedndReserve(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CheckIfReservedndReserve(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            CheckIfReservedndReserve(4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            CheckIfReservedndReserve(5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            CheckIfReservedndReserve(6);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            CheckIfReservedndReserve(7);
        }
    }

    void MostrarMensajeReservado()
    {
        cartelReservado.SetActive(true);
        Invoke(nameof(OcultarMensajeReservado),2);
    }

    void OcultarMensajeReservado()
    {
        cartelReservado.SetActive(false);
    }
    
    void CheckIfReservedndReserve(int index)
    {
        if (libros[index].reservado==false)
        {
            libros[index].color = 0;
            libros[index].reservado = true;
        }
        else
        {
            MostrarMensajeReservado();
        }
    }
}
