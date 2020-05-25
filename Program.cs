using System;

namespace primerProyecto
{
    class Program1
    {
        static void Main(string[] args)
        {
            // PUNTO 1
            //Console.WriteLine("Escriba un numero: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Numero Invertido: " + InvertirNumero(n));

            //PUNTO 2
            //Calculadora();


            //PUNTO 3
            Console.WriteLine("Ingrese un numero: ");
            double i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            float j = (float)Convert.ToDecimal(Console.ReadLine());

            CalculadoraModificada(i, j);


        }

        static int InvertirNumero(int n)
        {
            int n2 = n;
            int c = 0;
            int invertido = 0;
            if (n > 0)
            {
                while (n != 0)
                {
                    n /= 10;
                    c += 1;
                }

                while (n2 != 0)
                {
                    int d = (n2 % 10); //tomo la cifra
                    c -= 1;
                    invertido = (int)(invertido + (d * Math.Pow(10, c)));
                    n2 /= 10;
                }
            }
            else
            {
                Console.WriteLine("No se puede realizar la conversion");
            }

            return invertido;
        }

        static void Calculadora()
        {
            int opcion;
            int a, b;

            do
            {
                Console.WriteLine("Elija una opcion: ");
                Console.WriteLine("1.Sumar");
                Console.WriteLine("2.Restar");
                Console.WriteLine("3.Multiplicar");
                Console.WriteLine("4.Dividir");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Ingrese el primer digito: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo digito: ");
                            b = Convert.ToInt32(Console.ReadLine());

                            int suma = a + b;

                            Console.WriteLine("La suma es: " + suma);
                            Console.WriteLine("   ");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Ingrese el primer digito: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo digito: ");
                            b = Convert.ToInt32(Console.ReadLine());

                            int resta = a - b;

                            Console.WriteLine("La resta es: " + resta);
                            Console.WriteLine("   ");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Ingrese el primer digito: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo digito: ");
                            b = Convert.ToInt32(Console.ReadLine());

                            int multi = a * b;

                            Console.WriteLine("La multiplicacion es: " + multi);
                            Console.WriteLine("   ");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Ingrese el primer digito: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo digito: ");
                            b = Convert.ToInt32(Console.ReadLine());

                            int division = a / b;

                            Console.WriteLine("La division es: " + division);
                            Console.WriteLine("   ");

                        }
                        break;
                }


            } while (opcion != 5);
        }

        static void CalculadoraModificada(double i, float j)
        {
            double absoluto = Math.Abs(i);
            Console.WriteLine(absoluto);

            double cuadrado = Math.Sqrt(i);
            Console.WriteLine(cuadrado);

            double pot = Math.Pow(i, 2);
            Console.WriteLine(pot);

            double seno = Math.Sin(i);
            Console.WriteLine(seno);

            double coseno = Math.Cos(i);
            Console.WriteLine(coseno);

            int entera = (int)(j);
            Console.WriteLine(entera);

            double maximo = Math.Max(i, j);
            Console.WriteLine(maximo);

            double minimo = Math.Min(i, j);
            Console.WriteLine(minimo);


        }
    }
    
}
