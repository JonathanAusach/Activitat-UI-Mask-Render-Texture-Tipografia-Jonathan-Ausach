using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMAnager : MonoBehaviour
{
    // Velocidad de rotación que puedes ajustar desde el Inspector
    public Vector3 velocidadRotacion = new Vector3(0, 50, 0);

    void Update()
    {
        // Rota el objeto cada frame
        // Space.Self asegura que rote sobre su propio eje local
        transform.Rotate(velocidadRotacion * Time.deltaTime, Space.Self);
    }
}
