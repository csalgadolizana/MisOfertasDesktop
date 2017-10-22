using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Controlador
{
    public class DAOpromo
    {
       /* public static DataSet dbSelectAll()
        {

            bd.BDSoapClient BDWS = new bd.BDSoapClient();

            DataSet ds = BDWS.AeronaveSelectAll();

            return ds;
        }




        public static bool dbInsert(string matricula, DateTime inspeccion_anual, DateTime ano_fabricacion, DateTime fecha_aeronavegabilidad, int estado, int estado_avion_id, int marca_id, int horas_vuelo, int tipo_aeronave, int estado_vuelo_aeronave)
        {
            try
            {
                Cl_Aeronave aero = new Cl_Aeronave();
                aero.matricula = matricula;
                aero.inspeccion_anual = inspeccion_anual;
                aero.ano_fabricacion = ano_fabricacion;
                aero.fecha_aeronavegabilidad = fecha_aeronavegabilidad;
                aero.estado = estado;
                aero.estado_avion_id = estado_avion_id;
                aero.marca_id = marca_id;
                aero.horas_vuelo = horas_vuelo;
                aero.tipo_aeronave = tipo_aeronave;
                aero.estado_vuelo_aeronave = estado_vuelo_aeronave;

                bd.BDSoapClient BDWS = new bd.BDSoapClient();

                BDWS.AeronaveInsert(matricula, inspeccion_anual, ano_fabricacion, fecha_aeronavegabilidad, estado, estado_avion_id, marca_id, horas_vuelo, tipo_aeronave, estado_vuelo_aeronave);

                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }



        public static bool dbUpdate(int id_aeronave, string matricula, DateTime inspeccion_anual, DateTime ano_fabricacion, DateTime fecha_aeronavegabilidad, int estado, int estado_avion_id, int marca_id, int horas_vuelo, int tipo_aeronave, int estado_vuelo_aeronave)
        {
            try
            {
                Cl_Aeronave aero = new Cl_Aeronave();
                aero.id_aeronave = id_aeronave;
                aero.matricula = matricula;
                aero.inspeccion_anual = inspeccion_anual;
                aero.ano_fabricacion = ano_fabricacion;
                aero.fecha_aeronavegabilidad = fecha_aeronavegabilidad;
                aero.estado = estado;
                aero.estado_avion_id = estado_avion_id;
                aero.marca_id = marca_id;
                aero.horas_vuelo = horas_vuelo;
                aero.tipo_aeronave = tipo_aeronave;
                aero.estado_vuelo_aeronave = estado_vuelo_aeronave;

                bd.BDSoapClient BDWS = new bd.BDSoapClient();

                BDWS.AeronaveUpdate(id_aeronave, matricula, inspeccion_anual, ano_fabricacion, fecha_aeronavegabilidad, estado, estado_avion_id, marca_id, horas_vuelo, tipo_aeronave, estado_vuelo_aeronave);
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }

        }*/
    }
}
