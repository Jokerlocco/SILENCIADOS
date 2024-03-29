﻿using UnityEngine;

public class EstadoDelJuego : MonoBehaviour
{
    public bool CajaDeSeguridadSecretariaAbierta { get; set; } = false;
    public bool MotorHidraulicoArreglado { get; set; } = false;
    public bool EscapeDeGasArreglado { get; set; } = false;
    public bool CajaDeSeguridadSObservacionAbierta { get; set; } = false;
    public bool CajaDeSeguridadDMJAbierta { get; set; } = false;
    public bool CajaDeSeguridadDeIdentificacionAbierta { get; set; } = false;
    public bool CajaDeSeguridadSMaquinasAbierta { get; set; } = false;
    public bool EstatuaMovida { get; set; } = false;
}
