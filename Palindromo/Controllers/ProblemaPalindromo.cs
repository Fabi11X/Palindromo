using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Palindromo.Controllers
{

    /*
     
    Nombre de la escuela: Universidad Tecnologica Metropolitana



    Asignatura: Aplicaciones Web Orientadas a Servicios



    Nombre del Maestro: Joel Ivan Chuc Uc



    Nombre de la actividad: Actividad 2 "Los Palindromos"



    Nombre del alumno: Fabian Francisco Aguilar Rivero



    Cuatrimestre: 4



    Grupo: B



    Parcial: 1
    */


    [Route("api/[controller]")]
    [ApiController]
    public class ProblemaPalindromo : ControllerBase
    {

        [HttpGet]

        public IActionResult Palindromo(string guardar)

        {
            var Pali = new Palindromo();

            Pali.palindromo = guardar;

            var PaliFinal = string.Empty;

            var PaliContar = guardar;

            int i = PaliContar.Length;

            var PalindromoFinal = "";


            for (int n = i  - 1;  n >=0; n--)
            {

            }


            for (int j = i - 1; j >= 0; j--)
            {

                PaliFinal = PaliFinal + PaliContar[j];
            }


            if (PaliFinal.ToLower().Replace(" ", string.Empty) == PaliContar.ToLower().Replace(" ", string.Empty))
            {

                PalindromoFinal = (PaliContar + " Es Palindromo ");

            }

            else
            {
                PalindromoFinal = (PaliContar + " No es palindromo ");
            }


            int CantidadPalabras = PaliContar.Length - PaliContar.Replace(" ", string.Empty).Count() + 1;

            var ResultadoInvertida = (" Palabra Ingresada:  " + PalindromoFinal.ToLower() + " Su Invertido es: " + PalindromoFinal.ToLower() + " Numero de palabras: " + CantidadPalabras);

            return Ok(ResultadoInvertida.ToLower());
        }






    }
}
