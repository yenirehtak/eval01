using System;
namespace Empleados {
	public class Empleado 
	{
        private string nomapell;
        private string cedula;
        private int edad;
        private double salario;
        //declaracion de los métdoso set y get
        public string NomApell
        {
            get
            {
                return nomapell;
            }
            set
            {
                nomapell = value;
            }
        }
        public string Cedula
        {
            get
            {
                return cedula;
            }
            set
            {
                cedula = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                if (value <= 0)
                {
                    salario = 80;
                }
                else
                {
                    salario = value;
                }
            }
        }
        public virtual string solicitarJubilarse()
        {
            return "El empleado procedera a jubilarse";
        }

    }
    public class EmpdeAlmacen : Empleado
    {
        private string id;
        private bool ExistenciaMercancia;
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public bool Existenciamercancia
        {
            get
            {
                return ExistenciaMercancia;
            }
            set
            {
                ExistenciaMercancia = value;
            }
        }
        //metodos unicos del empleado del almacen 
        public override string solicitarJubilarse()
        {
            return "El almacenista procedera a jubilarse";
        }
        public void RecibirMercancia()
        {
            Console.WriteLine("La mercancia ha sido recibida");
        }
        public void EnviarMercancia()
        {
            Console.WriteLine("La mercancia ha sido enviada");
        }
        public void RealizarControl()
        {
            Console.WriteLine("Gestionando el control de calidad");
        }
        public void RealizarInventario()
        {
            Console.WriteLine("Gestionando el inventario del almacen");
        }

    }
}

