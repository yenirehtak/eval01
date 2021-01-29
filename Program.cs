using System;
using Empleados;
namespace eval01
{
    class Program
    {
        static void Main(string[] args)
        {
            char tipoEmpleado;
            for (int i = 0; i < 5; i++)
            {
                char resp;
                Empleado oEmpleado = new Empleado();
                Console.WriteLine("Bienvenido. Ingrese su nombre");
                oEmpleado.NomApell = Console.ReadLine();
                Console.WriteLine("Ingrese su cedula");
                oEmpleado.Cedula = Console.ReadLine();
                Console.WriteLine("Ingrese su edad");
                oEmpleado.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su salario");
                oEmpleado.Salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Por favor ingrese la inicial de su departamento: A(almacen) / V(ventas) / O(obrero)");
                tipoEmpleado = Convert.ToChar(Console.ReadLine());
                if (tipoEmpleado == 'A' || tipoEmpleado == 'a')
                {
                    EmpdeAlmacen oEmpdeAlmacen = new EmpdeAlmacen();
                    oEmpdeAlmacen.Existenciamercancia = true;
                    Console.WriteLine("Ingrese su codigo de identificacion");
                    oEmpdeAlmacen.Id = Console.ReadLine();
                    Console.WriteLine("¿Desea recibir la mercancia? S / n");
                    resp = Convert.ToChar(Console.ReadLine());
                    if (resp == 'S' || resp == 's')
                    {
                        oEmpdeAlmacen.RecibirMercancia();
                        oEmpdeAlmacen.EnviarMercancia();
                        oEmpdeAlmacen.RealizarControl();
                        oEmpdeAlmacen.RealizarInventario();
                        oEmpdeAlmacen.solicitarJubilarse();
                        Console.WriteLine("Su nombre es {0}, tiene {1} de edad, su cedula es {2} y su salario es {3}", oEmpleado.NomApell, oEmpleado.Edad, oEmpleado.Cedula, oEmpleado.Salario);
                    }
                    else
                    {
                        Console.WriteLine("No hay nada para hacer.");
                    }
                }
                else
                {
                    Console.WriteLine("No hay informacion sobre su departamento.");
                }
            }
        }
    }
}
