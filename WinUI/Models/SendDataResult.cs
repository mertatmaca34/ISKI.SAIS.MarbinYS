﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI.Models;

public class SendDataResult
{
    public int Period { get; set; }
    public DateTime ReadTime { get; set; }
    public double AKM { get; set; }
    public int AKM_Status { get; set; }
    public double CozunmusOksijen { get; set; }
    public int CozunmusOksijen_Status { get; set; }
    public double Debi { get; set; }
    public int Debi_Status { get; set; }
    public double KOi { get; set; }
    public int KOi_Status { get; set; }
    public double pH { get; set; }
    public int pH_Status { get; set; }
    public double Sicaklik { get; set; }
    public int Sicaklik_Status { get; set; }
    public double Iletkenlik { get; set; }
    public int Iletkenlik_Status { get; set; }
    public double AkisHizi { get; set; }
    public int AkisHizi_Status { get; set; }
    public double AKM_N { get; set; }
    public int AKM_N_Status { get; set; }
    public double CozunmusOksijen_N { get; set; }
    public int CozunmusOksijen_N_Status { get; set; }
    public double Debi_N { get; set; }
    public int Debi_N_Status { get; set; }
    public double AkisHizi_N { get; set; }
    public int AkisHizi_N_Status { get; set; }
    public double KOi_N { get; set; }
    public int KOi_N_Status { get; set; }
    public double pH_N { get; set; }
    public int pH_N_Status { get; set; }
    public double Iletkenlik_N { get; set; }
    public int Iletkenlik_N_Status { get; set; }
    public double Sicaklik_N { get; set; }
    public int Sicaklik_N_Status { get; set; }
}
