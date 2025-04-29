using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public int Horas;
    public string TipoEntrenamiento;
    int resultado;
    int descuento;
    int resultadoTotal;

    // Start is called before the first frame update
    void Start()
    {
        if (Horas < 1 || Horas > 6)
        {
            Debug.Log("Error. Las horas tienen que ser entre 1 y 6 incluyendolos");
            return;
        }
        else if (TipoEntrenamiento != "Recreativo" && TipoEntrenamiento != "Cardio" && TipoEntrenamiento != "Fuerza")
        {
            Debug.Log("Error. El tipo de entrenamiento debe ser entre Cardio, Recreativo, Fuerza");
            return;
        }
        else
        {

            if (TipoEntrenamiento == "Cardio")
            {
                resultado = Horas * 1000;

                if (Horas == 6)
                {
                    resultadoTotal = resultado * 1;
                    descuento = resultado / 10;
                    resultado = resultado - descuento;
                    Debug.Log("El tipo de entrenamiento es " + TipoEntrenamiento);
                    Debug.Log("La cantidad de horas es " + Horas);
                    Debug.Log("El precio total es " + resultadoTotal);
                    Debug.Log("El precio con descuento es " + resultado);
                }
                else
                {
                    Debug.Log("El tipo de entrenamiento es " + TipoEntrenamiento);
                    Debug.Log("La cantidad de horas es " + Horas);
                    Debug.Log("El precio total es " + resultado);
                }
            }
            else if (TipoEntrenamiento == "Recreativo")
            {
                resultado = Horas * 2500;

                if (Horas == 6)
                {
                    resultadoTotal = resultado * 1;
                    descuento = resultado / 10;
                    resultado = resultado - descuento;
                    Debug.Log("El tipo de entrenamiento es " + TipoEntrenamiento);
                    Debug.Log("La cantidad de horas es " + Horas);
                    Debug.Log("El precio total es " + resultadoTotal);
                    Debug.Log("El precio con descuento es " + resultado);
                }
                else
                {
                    Debug.Log("El tipo de entrenamiento es " +TipoEntrenamiento);
                    Debug.Log("La cantidad de horas es " + Horas);
                    Debug.Log("El precio total es " + resultado);
                }
            }
            else if (TipoEntrenamiento == "Fuerza")
            {
                resultado = Horas * 1500;

                if (Horas == 6)
                {
                    resultadoTotal = resultado * 1;
                    descuento = resultado / 10;
                    resultado = resultado - descuento;
                    Debug.Log("El tipo de entrenamiento es " + TipoEntrenamiento);
                    Debug.Log("La cantidad de horas es " + Horas);
                    Debug.Log("El precio total es " + resultadoTotal);
                    Debug.Log("El precio con descuento es " + resultado);
                }
                else
                {
                    Debug.Log("El tipo de entrenamiento es " + TipoEntrenamiento);
                    Debug.Log("La cantidad de horas es " + Horas);
                    Debug.Log("El precio total es " + resultado);
                }
            }
        }
    }


}
