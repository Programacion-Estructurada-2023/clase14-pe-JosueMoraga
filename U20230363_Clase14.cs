﻿using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

          //Declaración de variables int

          int opciones; 

          do
          {
                Console.WriteLine("\n----------MENÚ----------");
                Console.WriteLine("1.Programa que suma los números pares hasta el 75.");
                Console.WriteLine("2.Lista de 9 números enteros que encuentra el número mas grande.");
                Console.WriteLine("3.Tabla que multiplica un número n, del 1 al 12 y le suma 2 al resultado.");
                Console.WriteLine("4.Salir del menú.");    
                Console.WriteLine("\nSeleccione una opción (1-4): ");
                
                if (int.TryParse(Console.ReadLine(), out opciones))
                {
                   switch (opciones)
                   {
                    case 1: //suma de los números pares hasta el numero 75. 
                        
                        int suma = 0; 

                        for (int i =2; i <= 75; i+=2)
                        {
                            suma += i;
                        }
                        Console.WriteLine("\nSi sumamos todos los números pares hasta llegar a 75, el resultado es: " + suma); 

                        break;
                    case 2: //Lista de 9 números enteros encontrando el numero mas grande.
                        
                        //Lista de números enteros.
                        List<int> numeros = new List<int> {11,13,25,67,93,42,38,23,7,78}; 

                        //Variable para almacenar el numero mas grande.
                        int numeroGrande = int.MinValue; 

                        //Recorriendo la lista.
                        foreach (int numero in numeros)
                        {
                            if (numero > numeroGrande)
                            {
                                numeroGrande = numero; 
                            }
                        } 
                        Console.WriteLine("\nEl número mas grande en la lista es: " + numeroGrande);
        
                        break;
                    case 3://Tabla de multiplicar un número n, del 1 al 12 y que al valor de “n x i” 2 al resultado.
                        Console.WriteLine("\nIngrese un número para elaborar su tabla de multiplicación: ");
                        int numeroMulti=Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= 12 ; i++)
                        {
                            int multiplicacion = numeroMulti * i + 2;

                            Console.WriteLine($"{numeroMulti} x {i} = {multiplicacion}");
                        } 

                        break;
                    case 4: 
                        break;            
                    default:
                        Console.WriteLine("\n Por favor, seleccione una opción (1-4), ya que la mencionada anteriormente no es válida.");
                        break;
                   }                                   
                }         
                else
                {
                    Console.WriteLine("\n Entrada no valida. Elige una opción del 1 al 4, por favor.");
                }
                    Console.ResetColor();
          }     while (opciones !=4);          
        }
    }
}