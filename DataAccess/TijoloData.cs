﻿using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TijoloData
    {
        private int i = 0;
        private static string connString = @"Data Source=PLANNIXSERVER\SQL2008R2;
            Initial Catalog=TEA1101;
            User Id=sa;
            Password=plannix@2016;";

        Tijolo[] arrayDeTijolos = new Tijolo[10];

        

       


        public Array AddTijolosAndShow(Tijolo tijolo)
        {
            arrayDeTijolos[i] = new Tijolo(tijolo);
            i++;
            return arrayDeTijolos;
        }

        public Tijolo GetTijoloPorSerial(int serialDigitado)
        {
            Tijolo tijoloPorSerial = arrayDeTijolos.FirstOrDefault((t) => t.serial == serialDigitado);
            return tijoloPorSerial;
        }

        public Array OrdenarTijolosPorData()
        {
            Tijolo repos;
            //percorrer array
            for (int i = 0; i < arrayDeTijolos.Length - 1; i++)
            {
                for (int j = 0; j < arrayDeTijolos.Length - (i + 1); j++)
                { 
                    //Confere ano
                    if (arrayDeTijolos[j].date.Year < arrayDeTijolos[j + 1].date.Year)
                    {
                        repos = arrayDeTijolos[j];
                        arrayDeTijolos[j] = arrayDeTijolos[j + 1];
                        arrayDeTijolos[j + 1] = repos;
                    }
                    //Confere mes
                    else if (arrayDeTijolos[j].date.Month < arrayDeTijolos[j + 1].date.Month)
                    {
                        repos = arrayDeTijolos[j];
                        arrayDeTijolos[j] = arrayDeTijolos[j + 1];
                        arrayDeTijolos[j + 1] = repos;
                    }
                    //Confere dia
                    else if (arrayDeTijolos[j].date.Day < arrayDeTijolos[j + 1].date.Day)
                    {
                        repos = arrayDeTijolos[j];
                        arrayDeTijolos[j] = arrayDeTijolos[j + 1];
                        arrayDeTijolos[j + 1] = repos;
                    }
                }
            }
            return arrayDeTijolos;
        }
    }
}
