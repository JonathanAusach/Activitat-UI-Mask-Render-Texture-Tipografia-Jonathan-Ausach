using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerActividad : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TextoButton;
    [SerializeField] Image MyDeamonLoad;

    bool EstaPresionando = false;
    bool Create = true;
    private void Start()
    {
        TextoButton.text = "Cargar";
    }
    private void Update()
    {
        if (EstaPresionando)
        {
            TextoButton.text = "Cargando";
            if (Create)
            {
                MyDeamonLoad.fillAmount -= 0.01f;
                if (MyDeamonLoad.fillAmount == 0)
                {
                    Create = false;
                }
            }
            else
            {
                MyDeamonLoad.fillAmount += 0.01f;
                if (MyDeamonLoad.fillAmount == 1)
                {
                    Create = true;
                }
            }
        }
        else
        {
            TextoButton.text = "Cargar";
        }
    }

    public void PressButton() => EstaPresionando =  true;
    public void AlSoltar() => EstaPresionando = false;
}
