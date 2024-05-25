using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
     //NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioAlumno" en el código y en el archivo de configuración a la vez.
    public class ServicioAlumno : IServicioAlumno
    {
        public Boolean InsertarAlumno(AlumnoDC objAlumnoDC)
        {
            try
            {
                using (InstituTecEntities Alumnos = new InstituTecEntities())
                {
                    //Llama al procedimiento almacenado usp_InsertarAlumnos
                    Alumnos.usp_InsertarAlumnos(
                        objAlumnoDC.NomAlu,
                        objAlumnoDC.ApePat,
                        objAlumnoDC.ApeMat,
                        objAlumnoDC.Ndocum,
                        objAlumnoDC.Id_Ubi,  // Agregar el parámetro faltante
                        objAlumnoDC.Sexoal,
                        Convert.ToDateTime(objAlumnoDC.FecNac),
                        objAlumnoDC.CorAlu,
                        objAlumnoDC.TelAlu,
                        objAlumnoDC.Usu_Registro,
                        objAlumnoDC.Estado,
                        objAlumnoDC.CodCar,
                        objAlumnoDC.Foto,
                        objAlumnoDC.direccion
                    );

                    //Guarda los cambios en el contexto de Entity Framework
                    Alumnos.SaveChanges();

                    return true;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public AlumnoDC ConsultarAlumno(string strCodigo)
        {
            try
            {
                using (var context = new InstituTecEntities())
                {
                    //Obtenemos la instancia del alumno consultado
                    TB_Alumno objAlumno = context.TB_Alumno
                        .Where(alumnoConsultado => alumnoConsultado.IdAlum == strCodigo)
                        .FirstOrDefault(); // Asegura que se devuelva solo una instancia (FirstOrDefault).

                    //Creamos una instancia de la entidad de datos contractual AlumnoDC(aquí devolvemos la información del alumno).
                    AlumnoDC objAlumnoDC = new AlumnoDC();

                    //Verificamos si el alumno existe
                    if (objAlumno != null)
                    {
                        objAlumnoDC.IdAlum = objAlumno.IdAlum;
                        objAlumnoDC.NomAlu = objAlumno.NomAlu;
                        objAlumnoDC.ApePat = objAlumno.ApePat;
                        objAlumnoDC.ApeMat = objAlumno.ApeMat;
                        objAlumnoDC.TelAlu = objAlumno.TelAlu;
                        objAlumnoDC.CorAlu = objAlumno.CorAlu;
                        objAlumnoDC.Sexoal = objAlumno.Sexoal;
                        objAlumnoDC.Estado = objAlumno.Estado ?? false;
                        objAlumnoDC.Ndocum = objAlumno.Ndocum;
                        objAlumnoDC.Id_Ubi = objAlumno.Id_Ubi;
                        objAlumnoDC.FecNac = Convert.ToDateTime(objAlumno.FecNac);
                        objAlumnoDC.CodCar = objAlumno.CodCar;
                        objAlumnoDC.Fec_Registro = Convert.ToDateTime(objAlumno.Fec_Registro);
                        objAlumnoDC.Usu_Registro = objAlumno.Usu_Registro;
                        objAlumnoDC.Fec_Ult_Mod = Convert.ToDateTime(objAlumno.Fec_Ult_Mod);
                        objAlumnoDC.direccion = objAlumno.direccion;

                        //Obtén los datos binarios de la columna "Foto"
                        byte[] fotoData = objAlumno.foto;

                        //Asigna los datos binarios a la propiedad "Foto" de AlumnoDC
                        objAlumnoDC.Foto = fotoData;

                    }
                    else
                    {
                        //Si el alumno no existe, puedes devolver una instancia con valores predeterminados o nulos
                        objAlumnoDC.IdAlum = string.Empty;
                        //Aquí puedes establecer otras propiedades a valores predeterminados.
                    }

                    return objAlumnoDC;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AlumnoDC> ListarAlumno()
        {
            try
            {
                // Definiendo la instancia del contexto
                InstituTecEntities instituTecEntities = new InstituTecEntities();

                // Crear lista de AlumnoDC
                List<AlumnoDC> objListAlumnoDC = new List<AlumnoDC>();

                var query = (from alumno in instituTecEntities.TB_Alumno
                             join carrera in instituTecEntities.Tb_Carrera on alumno.CodCar equals carrera.CodCar
                             join facultad in instituTecEntities.TB_Facultad on carrera.IdFacu equals facultad.IdFacu
                             select new
                             {
                                 Alumno = alumno,
                                 Carrera = carrera,
                                 Facultad = facultad
                             });

                foreach (var resultado in query)
                {
                    AlumnoDC objAlumnoDC = new AlumnoDC();

                    // Asignar propiedades del alumno
                    objAlumnoDC.IdAlum = resultado.Alumno.IdAlum;
                    objAlumnoDC.NomAlu = resultado.Alumno.NomAlu;
                    objAlumnoDC.ApePat = resultado.Alumno.ApePat;
                    objAlumnoDC.ApeMat = resultado.Alumno.ApeMat;
                    objAlumnoDC.fullName = objAlumnoDC.NomAlu + " " + objAlumnoDC.ApePat + " " + objAlumnoDC.ApeMat;
                    objAlumnoDC.TelAlu = resultado.Alumno.TelAlu;
                    objAlumnoDC.CorAlu = resultado.Alumno.CorAlu;
                    objAlumnoDC.Sexoal = resultado.Alumno.Sexoal;
                    objAlumnoDC.Estado = resultado.Alumno.Estado ?? false;
                    objAlumnoDC.Ndocum = resultado.Alumno.Ndocum;
                    objAlumnoDC.Id_Ubi = resultado.Alumno.Id_Ubi;
                    objAlumnoDC.FecNac = Convert.ToDateTime(resultado.Alumno.FecNac);
                    objAlumnoDC.CodCar = resultado.Alumno.CodCar;
                    objAlumnoDC.Fec_Registro = Convert.ToDateTime(resultado.Alumno.Fec_Registro);
                    objAlumnoDC.Usu_Registro = resultado.Alumno.Usu_Registro;
                    objAlumnoDC.Fec_Ult_Mod = Convert.ToDateTime(resultado.Alumno.Fec_Ult_Mod);
                    objAlumnoDC.direccion = resultado.Alumno.direccion;

                    // Obtener los datos binarios de la columna "Foto"
                    byte[] fotoData = resultado.Alumno.foto;

                    // Asignar los datos binarios a la propiedad "Foto" de AlumnoDC
                    objAlumnoDC.Foto = fotoData;

                    // Asignar propiedades de la Carrera
                    objAlumnoDC.CodCar = resultado.Carrera.CodCar;

                    // Asignar propiedades de la Facultad
                    objAlumnoDC.IdFacu = resultado.Facultad.IdFacu;
                    objAlumnoDC.DesFac = resultado.Facultad.DesFac;

                    // Agregar el objeto AlumnoDC a la lista
                    objListAlumnoDC.Add(objAlumnoDC);
                }

                return objListAlumnoDC;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        SqlConnection cnx = new SqlConnection(@"server=localhost;DataBase=Institutec;Integrated Security=true");
        SqlCommand cmd = new SqlCommand();
        DataSet dts = new DataSet();
        SqlDataAdapter ada;
        public List<AlumnoDC> ListarAlumnoNRC(String Nrc)
        {
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarAlumnoNRC";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nrc", Nrc);

                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "AlumnoNrc");

                //convertir el dataTable en una coleccion
                List<AlumnoDC> objLista = new List<AlumnoDC>();
                foreach (DataRow drFila in dts.Tables[0].Rows)
                {
                    AlumnoDC alumno = new AlumnoDC();
                    alumno.NomCur = drFila["Curso"].ToString();
                    alumno.fullName = drFila["Alumno"].ToString();
                    alumno.IdAlum = drFila["ID"].ToString();
                    alumno.CorAlu = drFila["Correo"].ToString();
                    alumno.DesCar = drFila["Carrera"].ToString();
                    alumno.DesFac = drFila["Facultad"].ToString();




                    objLista.Add(alumno);
                }
                return objLista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public Boolean EliminarAlumno(String strCodigo)
        {
            try
            {
                //definiendo instancia
                InstituTecEntities instituTecEntities = new InstituTecEntities();

                //llamando SP
                instituTecEntities.usp_BorrarAlumno(strCodigo);

               // actualizando el modelo
                instituTecEntities.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                //Accede a la excepción interna si existe
                if (ex.InnerException != null)
                {
                    var innerException = ex.InnerException;
                    throw new Exception("Error al eliminar alumno: " + innerException.Message);
                }
                else
                {
                    throw new Exception("Error al eliminar el alumno: " + ex.Message);
                }
            }
        }
        public Boolean ActualizarAlumno(AlumnoDC objAlumnoDC)
        {
            try
            {
                //definiendo instancia
                InstituTecEntities instituTecEntities = new InstituTecEntities();

               //store
                instituTecEntities.usp_ActualizarAlumno(
                        objAlumnoDC.IdAlum,
                        objAlumnoDC.NomAlu,
                        objAlumnoDC.ApePat,
                        objAlumnoDC.ApeMat,
                        objAlumnoDC.TelAlu,
                        Convert.ToDateTime(objAlumnoDC.FecNac),
                        objAlumnoDC.Estado,
                        objAlumnoDC.Ndocum,
                        objAlumnoDC.Id_Ubi,
                        objAlumnoDC.Sexoal,
                        objAlumnoDC.CorAlu,
                        objAlumnoDC.Usu_Registro,
                        objAlumnoDC.CodCar,
                        objAlumnoDC.Foto,
                        objAlumnoDC.direccion
                    );

                instituTecEntities.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public String ObtenerFacultadAlumno(String strIdAlum)
        {
            try
            {
                using (InstituTecEntities MiInstituto = new InstituTecEntities())
                {
                    // Implementa la lógica para obtener la facultad de un alumno.
                    // Puedes utilizar el Entity Framework o tus consultas SQL según sea necesario.

                    var idFacultad = (from alumno in MiInstituto.TB_Alumno
                                      join carrera in MiInstituto.Tb_Carrera on alumno.CodCar equals carrera.CodCar
                                      join facultad in MiInstituto.TB_Facultad on carrera.IdFacu equals facultad.IdFacu
                                      where alumno.IdAlum == strIdAlum
                                      select facultad.IdFacu).FirstOrDefault();

                    return idFacultad;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public String ObtenerCarreraAlumno(String strIdAlum)
        {
            try
            {
                using (InstituTecEntities MiInstituto = new InstituTecEntities())
                {
                    var idCarrera = (from alumno in MiInstituto.TB_Alumno
                                     where alumno.IdAlum == strIdAlum
                                     select alumno.CodCar).FirstOrDefault();

                    return idCarrera;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AlumnoDC> ListarCarrera()
        {
            try
            {
                DataTable dts = new DataTable(); // Inicializa un nuevo DataTable

                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarCarrera";
                cmd.Parameters.Clear();

                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    ada.Fill(dts); // Llena el DataTable con los resultados de la consulta
                }

                // Convertir el DataTable en una colección de objetos
                List<AlumnoDC> listaCarreras = new List<AlumnoDC>();
                foreach (DataRow drFila in dts.Rows)
                {
                    AlumnoDC carrera = new AlumnoDC();
                    carrera.CodCar = drFila["CodCar"].ToString();
                    carrera.DesCar = drFila["DesCar"].ToString();
                    carrera.DesFac = drFila["DesFac"].ToString();
                    listaCarreras.Add(carrera);
                }
                return listaCarreras;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<AlumnoDC> ListarFacultad()
        {
            try
            {
                DataTable dts = new DataTable(); // Inicializa un nuevo DataTable

                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarFacultad";
                cmd.Parameters.Clear();

                using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                {
                    ada.Fill(dts); // Llena el DataTable con los resultados de la consulta
                }

                // Convierte el DataTable en una colección de objetos
                List<AlumnoDC> listaFacultades = new List<AlumnoDC>();
                foreach (DataRow drFila in dts.Rows)
                {
                    AlumnoDC facultad = new AlumnoDC();
                    facultad.IdFacu = drFila["IdFacu"].ToString();
                    facultad.DesFac = drFila["DesFac"].ToString();
                    listaFacultades.Add(facultad);
                }
                return listaFacultades;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
