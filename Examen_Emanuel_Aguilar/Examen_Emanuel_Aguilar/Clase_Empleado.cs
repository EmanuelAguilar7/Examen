using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Emanuel_Aguilar
{
    class Clase_Empleado
    {
        string nombre_empleado;
        string identidad;
        int horas_trabajadas;
        float pago_por_hora_normal_del_trabajo;
        int horas_extras_trabajadas;
        float pago_por_hora_de_trabajo_extra;

        public  Clase_Empleado()
        {
            nombre_empleado = "Emanuel Aguilar";
            identidad = "1208-2000-00239";
            horas_trabajadas = 5;
            pago_por_hora_normal_del_trabajo = 1200;
            horas_extras_trabajadas = 5;
            pago_por_hora_de_trabajo_extra = 1200;
        }

        public string Nombre_Empleado
        {
            get
            {
                return nombre_empleado;
            }
            set
            {
                nombre_empleado = value;
            }
        }

        public string Identidad
        {
            get
            {
                return identidad;
            }
            set
            {
                identidad = value;
            }
        }

        public int Horas_Trabajadas
        {
            get
            {
                return horas_trabajadas;
            }
            set
            {
                horas_trabajadas = value;
            }
        }

        public float Pago_Por_Hora_Normal_Del_Trabajo
        {
            get
            {
                return pago_por_hora_normal_del_trabajo;
            }
            set
            {
                pago_por_hora_normal_del_trabajo = value;
            }
        }

        public int Horas_Extras_Trabajadas
        {
            get
            {
                return horas_extras_trabajadas;
            }
            set
            {
                horas_extras_trabajadas = value;
            }
        }

        public float Pago_Por_Hora_De_Trabajo_Extra
        {
            get
            {
                return pago_por_hora_de_trabajo_extra;
            }
            set
            {
                pago_por_hora_de_trabajo_extra = value;
            }
        }


        public void Nom()
        {
            string.Format(Nombre_Empleado);
        }

        public void Iden()
        {
            string.Format(Identidad);
        }

    }
}
