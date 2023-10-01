using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalwork
{
    class cajero
    {
        public int[] contr, saldo, cuen;
        public int lect, lec_con, opc, opc2, val, trans_cuen, val_trans;
        private string[] usu;

        public void carga()
        {
            cuen = new int[3];
            cuen[0] = 1234;
            cuen[1] = 5678;
            cuen[2] = 9876;

            contr = new int[3];
            contr[0] = 1212;
            contr[1] = 1313;
            contr[2] = 1414;

            saldo = new int[3];
            saldo[0] = 600000;
            saldo[1] = 90000;
            saldo[2] = 700000;

            usu = new string[3];
            usu[0] = "angel gabriel";
            usu[1] = "sebastian sanchez";
            usu[2] = "alan brito delgado";
            do
            {
                Console.Clear();
                Console.WriteLine("digite su numero de cuenta: ");
                lect = int.Parse(Console.ReadLine());

                while (lect != 0)
                {

                    if (lect == cuen[0] || lect == cuen[1] || lect == cuen[2])
                    {


                        Console.WriteLine("digite su contraseña: ");
                        lec_con = int.Parse(Console.ReadLine());

                        while (lect != 0 && lec_con == contr[0])
                        {


                            if (lec_con == contr[0])
                            {

                                while (lect == cuen[0])
                                {

                                    if (lec_con == contr[0])
                                    {

                                        Console.Clear();
                                        Console.WriteLine("Bienvenido " + usu[0]);
                                        Console.WriteLine("\n 1.Retirar Saldo.\n 2.Consultar Saldo.\n 3.Transferencia.\n 4.Salir.");
                                        Console.WriteLine("\n Digite el numero de la opcion que desea realizar: ");
                                        opc = int.Parse(Console.ReadLine());

                                        if (opc == 1)
                                        {
                                            Console.WriteLine("\n1- 10000.\n2- 30000.\n3- 70000.\n4- 90000.\n5- 130000.\n6- otra cantidad.");
                                            Console.WriteLine("Elija monto a retirar: ");
                                            opc2 = int.Parse(Console.ReadLine());

                                            if (opc2 == 1)
                                            {
                                                if (saldo[0] >= 10000)
                                                {
                                                    saldo[0] = saldo[0] - 10000;
                                                    Console.WriteLine("por favor Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[0]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 2)
                                            {
                                                if (saldo[0] >= 30000)
                                                {
                                                    saldo[0] = saldo[0] - 30000;
                                                    Console.WriteLine("por favor Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[0]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 3)
                                            {
                                                if (saldo[0] >= 70000)
                                                {
                                                    saldo[0] = saldo[0] - 70000;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[0]);
                                                    Console.WriteLine("Presione enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("Presione enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 4)
                                            {
                                                if (saldo[0] >= 90000)
                                                {
                                                    saldo[0] = saldo[0] - 90000;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[0]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 5)
                                            {
                                                if (saldo[0] >= 130000)
                                                {
                                                    saldo[0] = saldo[0] - 130000;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[0]);
                                                    Console.WriteLine("Presione enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("Presione enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 6)
                                            {
                                                Console.WriteLine("Digite el monto a retirar sin puntos ni comas: ");
                                                val = int.Parse(Console.ReadLine());

                                                if (saldo[0] >= val)
                                                {
                                                    saldo[0] = saldo[0] - val;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[0]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 != 1 && opc2 != 2 && opc2 != 3 && opc2 != 4 && opc2 != 5 && opc2 != 6)
                                            {
                                                Console.WriteLine("Opcion invalida, intentelo nuevamente. ");
                                                Console.WriteLine("enter para volver a las opciones.");
                                                Console.ReadKey();
                                            }

                                        }
                                        if (opc == 2) // otros opciones.
                                        {
                                            Console.WriteLine("Su saldo actual es: " + saldo[0]);
                                            Console.WriteLine("Presione enter para volver a las opciones.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        if (opc == 3)
                                        {
                                            do
                                            {

                                                Console.WriteLine("Digite el numero de cuenta al cual desea transferir: ");
                                                trans_cuen = int.Parse(Console.ReadLine());

                                                if (trans_cuen == cuen[0])
                                                {
                                                    do
                                                    {
                                                        Console.WriteLine("Digite el valor a transferir sin puntos ni comas: ");
                                                        val_trans = int.Parse(Console.ReadLine());
                                                        if (val_trans <= saldo[0])
                                                        {
                                                            saldo[0] = saldo[0] + val_trans;
                                                            saldo[0] = saldo[0] - val_trans;
                                                            Console.WriteLine("\n Transferencia exitosa\nSu saldo actual es: " + saldo[0]);
                                                            Console.WriteLine("enter para volver a las opciones.");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                        if (val_trans > saldo[0])
                                                        {
                                                            Console.WriteLine("Su saldo es insuficiente, por favor intentelo nuevamente");
                                                        }
                                                    } while (val_trans > saldo[0]);
                                                }
                                                if (trans_cuen == cuen[1])
                                                {
                                                    do
                                                    {
                                                        Console.WriteLine("Digite el valor a transferir sin puntos ni comas: ");
                                                        val_trans = int.Parse(Console.ReadLine());
                                                        if (val_trans <= saldo[0])
                                                        {
                                                            saldo[1] = saldo[1] + val_trans;
                                                            saldo[0] = saldo[0] - val_trans;
                                                            Console.WriteLine("\n Transferencia exitosa\nSu saldo actual es: " + saldo[0]);
                                                            Console.WriteLine("Presione enter para volver a las opciones.");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                        if (val_trans > saldo[0])
                                                        {
                                                            Console.WriteLine("Su saldo es insuficiente, por favor intentelo nuevamente");
                                                        }
                                                    } while (val_trans > saldo[0]);

                                                }
                                                if (trans_cuen == cuen[2])
                                                {
                                                    do
                                                    {
                                                        Console.WriteLine("Digite el valor a transferir sin puntos ni comas: ");
                                                        val_trans = int.Parse(Console.ReadLine());
                                                        if (val_trans <= saldo[0])
                                                        {
                                                            saldo[2] = saldo[2] + val_trans;
                                                            saldo[0] = saldo[0] - val_trans;
                                                            Console.WriteLine("\n Transferencia exitosa\nSu saldo actual es: " + saldo[0]);
                                                            Console.WriteLine("enter para volver a las opciones.");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                        if (val_trans > saldo[0])
                                                        {
                                                            Console.WriteLine("Su saldo es insuficiente, por favor intentelo nuevamente");
                                                        }
                                                    } while (val_trans > saldo[0]);
                                                }
                                                if (trans_cuen != cuen[0] && trans_cuen != cuen[1] && trans_cuen != cuen[2])
                                                {
                                                    Console.WriteLine("Esta cuenta no existe, por favor intentelo nuevamente");
                                                }

                                            } while (trans_cuen != cuen[0] && trans_cuen != cuen[1] && trans_cuen != cuen[2]);
                                        }
                                        if (opc == 4)
                                        {
                                            lect = 0;
                                            Console.WriteLine("Gracias por preferirnos, presione enter nuevamente");
                                            Console.ReadKey();
                                        }
                                        if (opc < 1 || opc > 4)
                                        {
                                            Console.WriteLine("Opcion invalida, intentelo nuevamente. ");
                                            Console.WriteLine("enter para volver a las opciones.");
                                            Console.ReadKey();
                                        }

                                    }

                                }


                            }
                            else
                            {

                                do
                                {
                                    Console.WriteLine("Contrasena invalida, por favor intentelo nuevamente.");
                                    lec_con = int.Parse(Console.ReadLine());
                                    //Console.ReadKey();
                                } while (lec_con != contr[0]);
                            }

                        }


                        while (lect != 0 && lec_con == contr[1])
                        {


                            if (lec_con == contr[1])
                            {

                                while (lect == cuen[1])
                                {

                                    if (lec_con == contr[1])
                                    {

                                        Console.Clear();
                                        Console.WriteLine("Bienvenido " + usu[1]);
                                        Console.WriteLine("\n 1.Retirar Saldo.\n 2.Consultar Saldo.\n 3.Transferir.\n 4.Salir.");
                                        Console.WriteLine("\nDigite el numero de la opcion que desea realizar: ");
                                        opc = int.Parse(Console.ReadLine());

                                        if (opc == 1)
                                        {
                                            Console.WriteLine("\n1- 10000.\n2- 30000.\n3- 70000.\n4- 90000.\n5- 130000.\n6- Otro Valor.");
                                            Console.WriteLine("Elija monto a retirar: ");
                                            opc2 = int.Parse(Console.ReadLine());

                                            if (opc2 == 1)
                                            {
                                                if (saldo[1] >= 10000)
                                                {
                                                    saldo[1] = saldo[1] - 10000;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[1]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 2)
                                            {
                                                if (saldo[1] >= 30000)
                                                {
                                                    saldo[1] = saldo[1] - 30000;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[0]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 3)
                                            {
                                                if (saldo[1] >= 70000)
                                                {
                                                    saldo[1] = saldo[1] - 70000;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[1]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 4)
                                            {
                                                if (saldo[1] >= 90000)
                                                {
                                                    saldo[1] = saldo[1] - 90000;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[1]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 5)
                                            {
                                                if (saldo[1] >= 130000)
                                                {
                                                    saldo[1] = saldo[1] - 130000;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[1]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 6)
                                            {
                                                Console.WriteLine("Digite el monto a retirar sin puntos ni comas: ");
                                                val = int.Parse(Console.ReadLine());

                                                if (saldo[1] >= val)
                                                {
                                                    saldo[1] = saldo[1] - val;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[1]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 != 1 && opc2 != 2 && opc2 != 3 && opc2 != 4 && opc2 != 5 && opc2 != 6)
                                            {
                                                Console.WriteLine("Opcion invalida, intentelo nuevamente. ");
                                                Console.WriteLine("enter para volver a las opciones.");
                                                Console.ReadKey();
                                            }

                                        }
                                        if (opc == 2) // otros opciones.
                                        {
                                            Console.WriteLine("Su saldo actual es: " + saldo[1]);
                                            Console.WriteLine("Presione enter para volver a las opciones.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        if (opc == 3)
                                        {
                                            do
                                            {

                                                Console.WriteLine("Digite el numero de cuenta al cual desea transferir: ");
                                                trans_cuen = int.Parse(Console.ReadLine());

                                                if (trans_cuen == cuen[0])
                                                {
                                                    do
                                                    {
                                                        Console.WriteLine("Digite el valor a transferir sin puntos ni comas: ");
                                                        val_trans = int.Parse(Console.ReadLine());
                                                        if (val_trans <= saldo[1])
                                                        {
                                                            saldo[0] = saldo[0] + val_trans;
                                                            saldo[1] = saldo[1] - val_trans;
                                                            Console.WriteLine("\nTransferencia exitosa\n Su saldo actual es: " + saldo[1]);
                                                            Console.WriteLine("Presione enter para volver a las opciones.");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                        if (val_trans > saldo[1])
                                                        {
                                                            Console.WriteLine("Su saldo es insuficiente, por favor intentelo nuevamente");
                                                        }
                                                    } while (val_trans > saldo[1]);
                                                }
                                                if (trans_cuen == cuen[1])
                                                {
                                                    do
                                                    {
                                                        Console.WriteLine("Digite el valor a transferir sin puntos ni comas: ");
                                                        val_trans = int.Parse(Console.ReadLine());
                                                        if (val_trans <= saldo[1])
                                                        {
                                                            saldo[1] = saldo[1] + val_trans;
                                                            saldo[1] = saldo[1] - val_trans;
                                                            Console.WriteLine("\n Transferencia exitosa\nSu saldo actual es: " + saldo[1]);
                                                            Console.WriteLine("enter para volver a las opciones.");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                        if (val_trans > saldo[1])
                                                        {
                                                            Console.WriteLine("Su saldo es insuficiente, por favor intentelo nuevamente");
                                                        }
                                                    } while (val_trans > saldo[1]);

                                                }
                                                if (trans_cuen == cuen[2])
                                                {
                                                    do
                                                    {
                                                        Console.WriteLine("Digite el valor a transferir sin puntos ni comas: ");
                                                        val_trans = int.Parse(Console.ReadLine());
                                                        if (val_trans <= saldo[1])
                                                        {
                                                            saldo[2] = saldo[2] + val_trans;
                                                            saldo[1] = saldo[1] - val_trans;
                                                            Console.WriteLine("\n Transferencia exitosa\nSu saldo actual es: " + saldo[1]);
                                                            Console.WriteLine("enter para volver a las opciones.");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                        if (val_trans > saldo[1])
                                                        {
                                                            Console.WriteLine("Su saldo es insuficiente, por favor intentelo nuevamente");
                                                        }
                                                    } while (val_trans > saldo[1]);
                                                }
                                                if (trans_cuen != cuen[0] && trans_cuen != cuen[1] && trans_cuen != cuen[2])
                                                {
                                                    Console.WriteLine("Esta cuenta no existe, por favor intentelo nuevamente");
                                                }

                                            } while (trans_cuen != cuen[0] && trans_cuen != cuen[1] && trans_cuen != cuen[2]);
                                        }
                                        if (opc == 4)
                                        {
                                            lect = 0;
                                            Console.WriteLine("Gracias por preferirnos, presione enter nuevamente");
                                            Console.ReadKey();
                                        }
                                        if (opc < 1 || opc > 4)
                                        {
                                            Console.WriteLine("Opcion invalida, intentelo nuevamente. ");
                                            Console.WriteLine("enter para volver a las opciones.");
                                            Console.ReadKey();
                                        }

                                    }

                                }


                            }
                            else
                            {

                                do
                                {
                                    Console.WriteLine("Contrasena invalida, por favor intentelo nuevamente.");
                                    lec_con = int.Parse(Console.ReadLine());
                                    //Console.ReadKey();
                                } while (lec_con != contr[1]);
                            }

                        }


                        while (lect != 0 && lec_con == contr[2])
                        {


                            if (lec_con == contr[2])
                            {

                                while (lect == cuen[2])
                                {

                                    if (lec_con == contr[2])
                                    {

                                        Console.Clear();
                                        Console.WriteLine("Bienvenido " + usu[2]);
                                        Console.WriteLine("\n 1.Retirar Saldo.\n 2.Consultar Saldo.\n 3.Transferir.\n 4.Salir.");
                                        Console.WriteLine("\nDigite el numero de la opcion que desea realizar: ");
                                        opc = int.Parse(Console.ReadLine());

                                        if (opc == 1)
                                        {
                                            Console.WriteLine("\n1- 10000.\n2- 30000.\n3- 70000.\n4- 90000.\n5- 130000.\n6- Otro Valor.");
                                            Console.WriteLine("Elija valor a retirar: ");
                                            opc2 = int.Parse(Console.ReadLine());

                                            if (opc2 == 1)
                                            {
                                                if (saldo[2] >= 10000)
                                                {
                                                    saldo[2] = saldo[2] - 10000;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[2]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 2)
                                            {
                                                if (saldo[2] >= 30000)
                                                {
                                                    saldo[2] = saldo[2] - 30000;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[2]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 3)
                                            {
                                                if (saldo[2] >= 70000)
                                                {
                                                    saldo[2] = saldo[2] - 70000;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[2]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 4)
                                            {
                                                if (saldo[2] >= 90000)
                                                {
                                                    saldo[2] = saldo[2] - 90000;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[2]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 5)
                                            {
                                                if (saldo[2] >= 130000)
                                                {
                                                    saldo[2] = saldo[2] - 130000;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[2]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 == 6)
                                            {
                                                Console.WriteLine("Digite el valor a retirar sin puntos ni comas: ");
                                                val = int.Parse(Console.ReadLine());

                                                if (saldo[2] >= val)
                                                {
                                                    saldo[2] = saldo[2] - val;
                                                    Console.WriteLine("Retire su dinero.");
                                                    Console.WriteLine("Saldo: " + saldo[2]);
                                                    Console.WriteLine("enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Saldo insuficiente, intentelo nuevamente.");
                                                    Console.WriteLine("Presione enter para volver a las opciones.");
                                                    Console.ReadKey();
                                                }
                                            }
                                            if (opc2 != 1 && opc2 != 2 && opc2 != 3 && opc2 != 4 && opc2 != 5 && opc2 != 6)
                                            {
                                                Console.WriteLine("Opcion invalida, intentelo nuevamente. ");
                                                Console.WriteLine("enter para volver a las opciones.");
                                                Console.ReadKey();
                                            }

                                        }
                                        if (opc == 2) // otras opciones.
                                        {
                                            Console.WriteLine("Su saldo actual es: " + saldo[2]);
                                            Console.WriteLine("enter para volver a las opciones.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        if (opc == 3)
                                        {
                                            do
                                            {

                                                Console.WriteLine("Digite el numero de cuenta al cual desea transferir: ");
                                                trans_cuen = int.Parse(Console.ReadLine());

                                                if (trans_cuen == cuen[0])
                                                {
                                                    do
                                                    {
                                                        Console.WriteLine("Digite el valor a transferir sin puntos ni comas: ");
                                                        val_trans = int.Parse(Console.ReadLine());
                                                        if (val_trans <= saldo[2])
                                                        {
                                                            saldo[0] = saldo[0] + val_trans;
                                                            saldo[2] = saldo[2] - val_trans;
                                                            Console.WriteLine("\nTransferencia exitosa\nSu saldo actual es: " + saldo[2]);
                                                            Console.WriteLine("Presione enter para volver a las opciones.");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                        if (val_trans > saldo[2])
                                                        {
                                                            Console.WriteLine("Su saldo es insuficiente, por favor intentelo nuevamente");
                                                        }
                                                    } while (val_trans > saldo[2]);
                                                }
                                                if (trans_cuen == cuen[1])
                                                {
                                                    do
                                                    {
                                                        Console.WriteLine("Digite el valor a transferir sin puntos ni comas: ");
                                                        val_trans = int.Parse(Console.ReadLine());
                                                        if (val_trans <= saldo[2])
                                                        {
                                                            saldo[1] = saldo[1] + val_trans;
                                                            saldo[2] = saldo[2] - val_trans;
                                                            Console.WriteLine("\nTransferencia exitosa\nSu saldo actual es: " + saldo[2]);
                                                            Console.WriteLine("Presione enter para volver a las opciones.");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                        if (val_trans > saldo[2])
                                                        {
                                                            Console.WriteLine("Su saldo es insuficiente, por favor intentelo nuevamente");
                                                        }
                                                    } while (val_trans > saldo[2]);

                                                }
                                                if (trans_cuen == cuen[2])
                                                {
                                                    do
                                                    {
                                                        Console.WriteLine("Digite el valor a transferir sin puntos ni comas: ");
                                                        val_trans = int.Parse(Console.ReadLine());
                                                        if (val_trans <= saldo[2])
                                                        {
                                                            saldo[2] = saldo[2] + val_trans;
                                                            saldo[2] = saldo[2] - val_trans;
                                                            Console.WriteLine("\n Transferencia exitosa\nSu saldo actual es: " + saldo[2]);
                                                            Console.WriteLine("enter para volver a las opciones.");
                                                            Console.ReadKey();
                                                            break;
                                                        }
                                                        if (val_trans > saldo[2])
                                                        {
                                                            Console.WriteLine("Su saldo es insuficiente, por favor intentelo nuevamente");
                                                        }
                                                    } while (val_trans > saldo[2]);
                                                }
                                                if (trans_cuen != cuen[0] && trans_cuen != cuen[1] && trans_cuen != cuen[2])
                                                {
                                                    Console.WriteLine("Esta cuenta no existe, por favor intentelo nuevamente");
                                                }

                                            } while (trans_cuen != cuen[0] && trans_cuen != cuen[1] && trans_cuen != cuen[2]);
                                        }
                                        if (opc == 4)
                                        {
                                            lect = 0;
                                            Console.WriteLine("Gracias por preferirnos, presione enter nuevamente");
                                            Console.ReadKey();
                                        }
                                        if (opc < 1 || opc > 4)
                                        {
                                            Console.WriteLine("Opcion invalida, intentelo nuevamente. ");
                                            Console.WriteLine("enter para volver a las opciones.");
                                            Console.ReadKey();
                                        }

                                    }

                                }


                            }
                            else
                            {

                                do
                                {
                                    Console.WriteLine("Contrasena invalida, por favor intentelo nuevamente.");
                                    lec_con = int.Parse(Console.ReadLine());
                                    //Console.ReadKey();
                                } while (lec_con != contr[2]);
                            }

                        }

                    }

                    if (cuen[0] != lect && cuen[1] != lect && cuen[2] != lect && lect != 0)
                    {
                        Console.WriteLine("Esta cuenta no existe, intentalo nuevamente: ");
                        lect = int.Parse(Console.ReadLine());
                    }

                }

            } while (opc == 4);

        }
    }
}
