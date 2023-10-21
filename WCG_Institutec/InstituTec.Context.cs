﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCG_Institutec
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class InstituTecEntities : DbContext
    {
        public InstituTecEntities()
            : base("name=InstituTecEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_Alumno> TB_Alumno { get; set; }
        public virtual DbSet<TB_Aula> TB_Aula { get; set; }
        public virtual DbSet<Tb_Carrera> Tb_Carrera { get; set; }
        public virtual DbSet<Tb_Curso> Tb_Curso { get; set; }
        public virtual DbSet<TB_Espc_Prof> TB_Espc_Prof { get; set; }
        public virtual DbSet<TB_Facultad> TB_Facultad { get; set; }
        public virtual DbSet<TB_local> TB_local { get; set; }
        public virtual DbSet<TB_Matricula> TB_Matricula { get; set; }
        public virtual DbSet<TB_Profesor> TB_Profesor { get; set; }
        public virtual DbSet<Tb_Seccion> Tb_Seccion { get; set; }
        public virtual DbSet<TB_Semestre> TB_Semestre { get; set; }
        public virtual DbSet<Tb_Ubigeo> Tb_Ubigeo { get; set; }
        public virtual DbSet<Tb_Usuario> Tb_Usuario { get; set; }
        public virtual DbSet<VerDetAlum> VerDetAlum { get; set; }
        public virtual DbSet<vw_alumno> vw_alumno { get; set; }
        public virtual DbSet<vw_AlumnoCursos> vw_AlumnoCursos { get; set; }
        public virtual DbSet<vw_Carrera> vw_Carrera { get; set; }
        public virtual DbSet<vw_CarreraXGenero> vw_CarreraXGenero { get; set; }
        public virtual DbSet<vw_ConsultaListaAlumnoCurso> vw_ConsultaListaAlumnoCurso { get; set; }
        public virtual DbSet<vw_ConsultaListaProfesorCurso> vw_ConsultaListaProfesorCurso { get; set; }
        public virtual DbSet<vw_ConsultaProfesorCurso> vw_ConsultaProfesorCurso { get; set; }
        public virtual DbSet<vw_curso> vw_curso { get; set; }
        public virtual DbSet<vw_DetalleMatricula> vw_DetalleMatricula { get; set; }
        public virtual DbSet<VW_Facultad> VW_Facultad { get; set; }
        public virtual DbSet<VW_Facultad_Carrera> VW_Facultad_Carrera { get; set; }
        public virtual DbSet<vw_Matricula> vw_Matricula { get; set; }
        public virtual DbSet<vw_preMatricula> vw_preMatricula { get; set; }
        public virtual DbSet<vw_Profesor> vw_Profesor { get; set; }
        public virtual DbSet<vw_seccion> vw_seccion { get; set; }
        public virtual DbSet<vw_vercurso> vw_vercurso { get; set; }
        public virtual DbSet<VW_verDistrito> VW_verDistrito { get; set; }
    
        public virtual int usp_ActualizarAlumno(string idAlum, string nomAlu, string apePat, string apeMat, string telAlu, Nullable<System.DateTime> fecNac, Nullable<bool> estado, string ndocum, string id_Ubi, string sexoal, string corAlu, string usu_Regi, string codCar, byte[] fotoAlum, string direcc)
        {
            var idAlumParameter = idAlum != null ?
                new ObjectParameter("IdAlum", idAlum) :
                new ObjectParameter("IdAlum", typeof(string));
    
            var nomAluParameter = nomAlu != null ?
                new ObjectParameter("NomAlu", nomAlu) :
                new ObjectParameter("NomAlu", typeof(string));
    
            var apePatParameter = apePat != null ?
                new ObjectParameter("ApePat", apePat) :
                new ObjectParameter("ApePat", typeof(string));
    
            var apeMatParameter = apeMat != null ?
                new ObjectParameter("ApeMat", apeMat) :
                new ObjectParameter("ApeMat", typeof(string));
    
            var telAluParameter = telAlu != null ?
                new ObjectParameter("TelAlu", telAlu) :
                new ObjectParameter("TelAlu", typeof(string));
    
            var fecNacParameter = fecNac.HasValue ?
                new ObjectParameter("FecNac", fecNac) :
                new ObjectParameter("FecNac", typeof(System.DateTime));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            var ndocumParameter = ndocum != null ?
                new ObjectParameter("Ndocum", ndocum) :
                new ObjectParameter("Ndocum", typeof(string));
    
            var id_UbiParameter = id_Ubi != null ?
                new ObjectParameter("Id_Ubi", id_Ubi) :
                new ObjectParameter("Id_Ubi", typeof(string));
    
            var sexoalParameter = sexoal != null ?
                new ObjectParameter("Sexoal", sexoal) :
                new ObjectParameter("Sexoal", typeof(string));
    
            var corAluParameter = corAlu != null ?
                new ObjectParameter("CorAlu", corAlu) :
                new ObjectParameter("CorAlu", typeof(string));
    
            var usu_RegiParameter = usu_Regi != null ?
                new ObjectParameter("Usu_Regi", usu_Regi) :
                new ObjectParameter("Usu_Regi", typeof(string));
    
            var codCarParameter = codCar != null ?
                new ObjectParameter("CodCar", codCar) :
                new ObjectParameter("CodCar", typeof(string));
    
            var fotoAlumParameter = fotoAlum != null ?
                new ObjectParameter("FotoAlum", fotoAlum) :
                new ObjectParameter("FotoAlum", typeof(byte[]));
    
            var direccParameter = direcc != null ?
                new ObjectParameter("direcc", direcc) :
                new ObjectParameter("direcc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarAlumno", idAlumParameter, nomAluParameter, apePatParameter, apeMatParameter, telAluParameter, fecNacParameter, estadoParameter, ndocumParameter, id_UbiParameter, sexoalParameter, corAluParameter, usu_RegiParameter, codCarParameter, fotoAlumParameter, direccParameter);
        }
    
        public virtual int usp_ActualizarCarrera(string vcod, string vidfacu, string vdescar, string vusu_ult_regis, string vdesFac, Nullable<int> vest_carr)
        {
            var vcodParameter = vcod != null ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(string));
    
            var vidfacuParameter = vidfacu != null ?
                new ObjectParameter("vidfacu", vidfacu) :
                new ObjectParameter("vidfacu", typeof(string));
    
            var vdescarParameter = vdescar != null ?
                new ObjectParameter("vdescar", vdescar) :
                new ObjectParameter("vdescar", typeof(string));
    
            var vusu_ult_regisParameter = vusu_ult_regis != null ?
                new ObjectParameter("vusu_ult_regis", vusu_ult_regis) :
                new ObjectParameter("vusu_ult_regis", typeof(string));
    
            var vdesFacParameter = vdesFac != null ?
                new ObjectParameter("vdesFac", vdesFac) :
                new ObjectParameter("vdesFac", typeof(string));
    
            var vest_carrParameter = vest_carr.HasValue ?
                new ObjectParameter("vest_carr", vest_carr) :
                new ObjectParameter("vest_carr", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarCarrera", vcodParameter, vidfacuParameter, vdescarParameter, vusu_ult_regisParameter, vdesFacParameter, vest_carrParameter);
        }
    
        public virtual int usp_ActualizarCurso(string idCurs, string nomCur, Nullable<bool> activo, string codCar, string usu_Ult_Mod)
        {
            var idCursParameter = idCurs != null ?
                new ObjectParameter("IdCurs", idCurs) :
                new ObjectParameter("IdCurs", typeof(string));
    
            var nomCurParameter = nomCur != null ?
                new ObjectParameter("NomCur", nomCur) :
                new ObjectParameter("NomCur", typeof(string));
    
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(bool));
    
            var codCarParameter = codCar != null ?
                new ObjectParameter("CodCar", codCar) :
                new ObjectParameter("CodCar", typeof(string));
    
            var usu_Ult_ModParameter = usu_Ult_Mod != null ?
                new ObjectParameter("Usu_Ult_Mod", usu_Ult_Mod) :
                new ObjectParameter("Usu_Ult_Mod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarCurso", idCursParameter, nomCurParameter, activoParameter, codCarParameter, usu_Ult_ModParameter);
        }
    
        public virtual int usp_ActualizarCursoActivo(string idCurs)
        {
            var idCursParameter = idCurs != null ?
                new ObjectParameter("IdCurs", idCurs) :
                new ObjectParameter("IdCurs", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarCursoActivo", idCursParameter);
        }
    
        public virtual int usp_ActulizarProfesor(string idProf, string nomPro, string apePat, string apeMat, string telPro, Nullable<bool> estado, Nullable<System.DateTime> fecIng, string ndocum, string sexopr, string id_Ubi, string usu_Ult_Mod, byte[] foto)
        {
            var idProfParameter = idProf != null ?
                new ObjectParameter("IdProf", idProf) :
                new ObjectParameter("IdProf", typeof(string));
    
            var nomProParameter = nomPro != null ?
                new ObjectParameter("NomPro", nomPro) :
                new ObjectParameter("NomPro", typeof(string));
    
            var apePatParameter = apePat != null ?
                new ObjectParameter("ApePat", apePat) :
                new ObjectParameter("ApePat", typeof(string));
    
            var apeMatParameter = apeMat != null ?
                new ObjectParameter("ApeMat", apeMat) :
                new ObjectParameter("ApeMat", typeof(string));
    
            var telProParameter = telPro != null ?
                new ObjectParameter("TelPro", telPro) :
                new ObjectParameter("TelPro", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            var fecIngParameter = fecIng.HasValue ?
                new ObjectParameter("FecIng", fecIng) :
                new ObjectParameter("FecIng", typeof(System.DateTime));
    
            var ndocumParameter = ndocum != null ?
                new ObjectParameter("Ndocum", ndocum) :
                new ObjectParameter("Ndocum", typeof(string));
    
            var sexoprParameter = sexopr != null ?
                new ObjectParameter("Sexopr", sexopr) :
                new ObjectParameter("Sexopr", typeof(string));
    
            var id_UbiParameter = id_Ubi != null ?
                new ObjectParameter("Id_Ubi", id_Ubi) :
                new ObjectParameter("Id_Ubi", typeof(string));
    
            var usu_Ult_ModParameter = usu_Ult_Mod != null ?
                new ObjectParameter("Usu_Ult_Mod", usu_Ult_Mod) :
                new ObjectParameter("Usu_Ult_Mod", typeof(string));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActulizarProfesor", idProfParameter, nomProParameter, apePatParameter, apeMatParameter, telProParameter, estadoParameter, fecIngParameter, ndocumParameter, sexoprParameter, id_UbiParameter, usu_Ult_ModParameter, fotoParameter);
        }
    
        public virtual int usp_BorrarAlumno(string idAlum)
        {
            var idAlumParameter = idAlum != null ?
                new ObjectParameter("IdAlum", idAlum) :
                new ObjectParameter("IdAlum", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_BorrarAlumno", idAlumParameter);
        }
    
        public virtual int usp_BorrarCarrera(string vcod)
        {
            var vcodParameter = vcod != null ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_BorrarCarrera", vcodParameter);
        }
    
        public virtual int usp_BorrarCurso(string idCurso)
        {
            var idCursoParameter = idCurso != null ?
                new ObjectParameter("IdCurso", idCurso) :
                new ObjectParameter("IdCurso", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_BorrarCurso", idCursoParameter);
        }
    
        public virtual int usp_BorrarProfesor(Nullable<int> idProfesor)
        {
            var idProfesorParameter = idProfesor.HasValue ?
                new ObjectParameter("IdProfesor", idProfesor) :
                new ObjectParameter("IdProfesor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_BorrarProfesor", idProfesorParameter);
        }
    
        public virtual int usp_BorrarSeccion(string idCods)
        {
            var idCodsParameter = idCods != null ?
                new ObjectParameter("IdCods", idCods) :
                new ObjectParameter("IdCods", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_BorrarSeccion", idCodsParameter);
        }
    
        public virtual ObjectResult<usp_CarreraXGenero_Result> usp_CarreraXGenero()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_CarreraXGenero_Result>("usp_CarreraXGenero");
        }
    
        public virtual ObjectResult<usp_ConsultaProfesor_Result> usp_ConsultaProfesor(string cod)
        {
            var codParameter = cod != null ?
                new ObjectParameter("cod", cod) :
                new ObjectParameter("cod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultaProfesor_Result>("usp_ConsultaProfesor", codParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarAlumno_Result> usp_ConsultarAlumno(string idAlum)
        {
            var idAlumParameter = idAlum != null ?
                new ObjectParameter("IdAlum", idAlum) :
                new ObjectParameter("IdAlum", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarAlumno_Result>("usp_ConsultarAlumno", idAlumParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarCarrera_Result> usp_ConsultarCarrera(string vcod)
        {
            var vcodParameter = vcod != null ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarCarrera_Result>("usp_ConsultarCarrera", vcodParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarCurso_Result> usp_ConsultarCurso(string idCurs)
        {
            var idCursParameter = idCurs != null ?
                new ObjectParameter("IdCurs", idCurs) :
                new ObjectParameter("IdCurs", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarCurso_Result>("usp_ConsultarCurso", idCursParameter);
        }
    
        public virtual ObjectResult<usp_ConsultarUsuario_Result> usp_ConsultarUsuario(string login_Usuario)
        {
            var login_UsuarioParameter = login_Usuario != null ?
                new ObjectParameter("Login_Usuario", login_Usuario) :
                new ObjectParameter("Login_Usuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultarUsuario_Result>("usp_ConsultarUsuario", login_UsuarioParameter);
        }
    
        public virtual ObjectResult<usp_ConsultaWebAlumno_Result> usp_ConsultaWebAlumno(string idAlu)
        {
            var idAluParameter = idAlu != null ?
                new ObjectParameter("idAlu", idAlu) :
                new ObjectParameter("idAlu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ConsultaWebAlumno_Result>("usp_ConsultaWebAlumno", idAluParameter);
        }
    
        public virtual ObjectResult<string> usp_CursosDisponiblesAlumno(string dni)
        {
            var dniParameter = dni != null ?
                new ObjectParameter("dni", dni) :
                new ObjectParameter("dni", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_CursosDisponiblesAlumno", dniParameter);
        }
    
        public virtual ObjectResult<usp_detalleMatricula_Result> usp_detalleMatricula(string dni)
        {
            var dniParameter = dni != null ?
                new ObjectParameter("dni", dni) :
                new ObjectParameter("dni", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_detalleMatricula_Result>("usp_detalleMatricula", dniParameter);
        }
    
        public virtual ObjectResult<usp_facultadCarrera_Result> usp_facultadCarrera(string codCar)
        {
            var codCarParameter = codCar != null ?
                new ObjectParameter("CodCar", codCar) :
                new ObjectParameter("CodCar", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_facultadCarrera_Result>("usp_facultadCarrera", codCarParameter);
        }
    
        public virtual int usp_InserCurso(string nomCur, Nullable<bool> activo, string codCar, string usu_Registro)
        {
            var nomCurParameter = nomCur != null ?
                new ObjectParameter("NomCur", nomCur) :
                new ObjectParameter("NomCur", typeof(string));
    
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(bool));
    
            var codCarParameter = codCar != null ?
                new ObjectParameter("CodCar", codCar) :
                new ObjectParameter("CodCar", typeof(string));
    
            var usu_RegistroParameter = usu_Registro != null ?
                new ObjectParameter("Usu_Registro", usu_Registro) :
                new ObjectParameter("Usu_Registro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InserCurso", nomCurParameter, activoParameter, codCarParameter, usu_RegistroParameter);
        }
    
        public virtual int usp_InsertarAlumnos(string nomAlu, string apePat, string apeMat, string ndocum, string id_Ubi, string sexoal, Nullable<System.DateTime> fecNac, string corAlu, string telAlu, string usu_Regi, Nullable<bool> estado, string codCar, byte[] fotoAlum, string direcc)
        {
            var nomAluParameter = nomAlu != null ?
                new ObjectParameter("NomAlu", nomAlu) :
                new ObjectParameter("NomAlu", typeof(string));
    
            var apePatParameter = apePat != null ?
                new ObjectParameter("ApePat", apePat) :
                new ObjectParameter("ApePat", typeof(string));
    
            var apeMatParameter = apeMat != null ?
                new ObjectParameter("ApeMat", apeMat) :
                new ObjectParameter("ApeMat", typeof(string));
    
            var ndocumParameter = ndocum != null ?
                new ObjectParameter("Ndocum", ndocum) :
                new ObjectParameter("Ndocum", typeof(string));
    
            var id_UbiParameter = id_Ubi != null ?
                new ObjectParameter("Id_Ubi", id_Ubi) :
                new ObjectParameter("Id_Ubi", typeof(string));
    
            var sexoalParameter = sexoal != null ?
                new ObjectParameter("Sexoal", sexoal) :
                new ObjectParameter("Sexoal", typeof(string));
    
            var fecNacParameter = fecNac.HasValue ?
                new ObjectParameter("FecNac", fecNac) :
                new ObjectParameter("FecNac", typeof(System.DateTime));
    
            var corAluParameter = corAlu != null ?
                new ObjectParameter("CorAlu", corAlu) :
                new ObjectParameter("CorAlu", typeof(string));
    
            var telAluParameter = telAlu != null ?
                new ObjectParameter("TelAlu", telAlu) :
                new ObjectParameter("TelAlu", typeof(string));
    
            var usu_RegiParameter = usu_Regi != null ?
                new ObjectParameter("Usu_Regi", usu_Regi) :
                new ObjectParameter("Usu_Regi", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            var codCarParameter = codCar != null ?
                new ObjectParameter("CodCar", codCar) :
                new ObjectParameter("CodCar", typeof(string));
    
            var fotoAlumParameter = fotoAlum != null ?
                new ObjectParameter("FotoAlum", fotoAlum) :
                new ObjectParameter("FotoAlum", typeof(byte[]));
    
            var direccParameter = direcc != null ?
                new ObjectParameter("direcc", direcc) :
                new ObjectParameter("direcc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarAlumnos", nomAluParameter, apePatParameter, apeMatParameter, ndocumParameter, id_UbiParameter, sexoalParameter, fecNacParameter, corAluParameter, telAluParameter, usu_RegiParameter, estadoParameter, codCarParameter, fotoAlumParameter, direccParameter);
        }
    
        public virtual int usp_InsertarCarrera(string vIdFacu, string vDesCar, string vUsu_regi, Nullable<int> vest_carr)
        {
            var vIdFacuParameter = vIdFacu != null ?
                new ObjectParameter("vIdFacu", vIdFacu) :
                new ObjectParameter("vIdFacu", typeof(string));
    
            var vDesCarParameter = vDesCar != null ?
                new ObjectParameter("vDesCar", vDesCar) :
                new ObjectParameter("vDesCar", typeof(string));
    
            var vUsu_regiParameter = vUsu_regi != null ?
                new ObjectParameter("vUsu_regi", vUsu_regi) :
                new ObjectParameter("vUsu_regi", typeof(string));
    
            var vest_carrParameter = vest_carr.HasValue ?
                new ObjectParameter("vest_carr", vest_carr) :
                new ObjectParameter("vest_carr", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarCarrera", vIdFacuParameter, vDesCarParameter, vUsu_regiParameter, vest_carrParameter);
        }
    
        public virtual int usp_InsertarProfesor(string ndocum, string nomPro, string apePat, string apeMat, string sexopr, string id_Ubi, byte[] foto, string usu_Registro, Nullable<bool> estado, string corIns, string telPro, Nullable<System.DateTime> fecNac, Nullable<System.DateTime> fecIng)
        {
            var ndocumParameter = ndocum != null ?
                new ObjectParameter("Ndocum", ndocum) :
                new ObjectParameter("Ndocum", typeof(string));
    
            var nomProParameter = nomPro != null ?
                new ObjectParameter("NomPro", nomPro) :
                new ObjectParameter("NomPro", typeof(string));
    
            var apePatParameter = apePat != null ?
                new ObjectParameter("ApePat", apePat) :
                new ObjectParameter("ApePat", typeof(string));
    
            var apeMatParameter = apeMat != null ?
                new ObjectParameter("ApeMat", apeMat) :
                new ObjectParameter("ApeMat", typeof(string));
    
            var sexoprParameter = sexopr != null ?
                new ObjectParameter("Sexopr", sexopr) :
                new ObjectParameter("Sexopr", typeof(string));
    
            var id_UbiParameter = id_Ubi != null ?
                new ObjectParameter("Id_Ubi", id_Ubi) :
                new ObjectParameter("Id_Ubi", typeof(string));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("Foto", foto) :
                new ObjectParameter("Foto", typeof(byte[]));
    
            var usu_RegistroParameter = usu_Registro != null ?
                new ObjectParameter("Usu_Registro", usu_Registro) :
                new ObjectParameter("Usu_Registro", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            var corInsParameter = corIns != null ?
                new ObjectParameter("CorIns", corIns) :
                new ObjectParameter("CorIns", typeof(string));
    
            var telProParameter = telPro != null ?
                new ObjectParameter("TelPro", telPro) :
                new ObjectParameter("TelPro", typeof(string));
    
            var fecNacParameter = fecNac.HasValue ?
                new ObjectParameter("FecNac", fecNac) :
                new ObjectParameter("FecNac", typeof(System.DateTime));
    
            var fecIngParameter = fecIng.HasValue ?
                new ObjectParameter("FecIng", fecIng) :
                new ObjectParameter("FecIng", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarProfesor", ndocumParameter, nomProParameter, apePatParameter, apeMatParameter, sexoprParameter, id_UbiParameter, fotoParameter, usu_RegistroParameter, estadoParameter, corInsParameter, telProParameter, fecNacParameter, fecIngParameter);
        }
    
        public virtual int usp_InsertarSeccion(string idCurs, string idProf, Nullable<bool> activo, Nullable<byte> vacant, string dIA, Nullable<System.TimeSpan> horIni, Nullable<System.TimeSpan> horFin, string idCent)
        {
            var idCursParameter = idCurs != null ?
                new ObjectParameter("IdCurs", idCurs) :
                new ObjectParameter("IdCurs", typeof(string));
    
            var idProfParameter = idProf != null ?
                new ObjectParameter("IdProf", idProf) :
                new ObjectParameter("IdProf", typeof(string));
    
            var activoParameter = activo.HasValue ?
                new ObjectParameter("Activo", activo) :
                new ObjectParameter("Activo", typeof(bool));
    
            var vacantParameter = vacant.HasValue ?
                new ObjectParameter("Vacant", vacant) :
                new ObjectParameter("Vacant", typeof(byte));
    
            var dIAParameter = dIA != null ?
                new ObjectParameter("DIA", dIA) :
                new ObjectParameter("DIA", typeof(string));
    
            var horIniParameter = horIni.HasValue ?
                new ObjectParameter("HorIni", horIni) :
                new ObjectParameter("HorIni", typeof(System.TimeSpan));
    
            var horFinParameter = horFin.HasValue ?
                new ObjectParameter("HorFin", horFin) :
                new ObjectParameter("HorFin", typeof(System.TimeSpan));
    
            var idCentParameter = idCent != null ?
                new ObjectParameter("IdCent", idCent) :
                new ObjectParameter("IdCent", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertarSeccion", idCursParameter, idProfParameter, activoParameter, vacantParameter, dIAParameter, horIniParameter, horFinParameter, idCentParameter);
        }
    
        public virtual int usp_InsertMatricula(string idSeme, Nullable<byte> estMat, string idAlum, Nullable<System.DateTime> fecMat)
        {
            var idSemeParameter = idSeme != null ?
                new ObjectParameter("IdSeme", idSeme) :
                new ObjectParameter("IdSeme", typeof(string));
    
            var estMatParameter = estMat.HasValue ?
                new ObjectParameter("EstMat", estMat) :
                new ObjectParameter("EstMat", typeof(byte));
    
            var idAlumParameter = idAlum != null ?
                new ObjectParameter("IdAlum", idAlum) :
                new ObjectParameter("IdAlum", typeof(string));
    
            var fecMatParameter = fecMat.HasValue ?
                new ObjectParameter("FecMat", fecMat) :
                new ObjectParameter("FecMat", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_InsertMatricula", idSemeParameter, estMatParameter, idAlumParameter, fecMatParameter);
        }
    
        public virtual ObjectResult<usp_ListaConsultarProfesorCurso_Result> usp_ListaConsultarProfesorCurso(string vcod)
        {
            var vcodParameter = vcod != null ?
                new ObjectParameter("vcod", vcod) :
                new ObjectParameter("vcod", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListaConsultarProfesorCurso_Result>("usp_ListaConsultarProfesorCurso", vcodParameter);
        }
    
        public virtual ObjectResult<usp_ListarAlumno_Result> usp_ListarAlumno(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarAlumno_Result>("usp_ListarAlumno", idParameter);
        }
    
        public virtual ObjectResult<usp_ListarCarrera_Result> usp_ListarCarrera()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarCarrera_Result>("usp_ListarCarrera");
        }
    
        public virtual ObjectResult<usp_ListarCurso_Result> usp_ListarCurso()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarCurso_Result>("usp_ListarCurso");
        }
    
        public virtual ObjectResult<usp_ListarCursosAlumnoFechas_Result> usp_ListarCursosAlumnoFechas(string idAlum, Nullable<System.DateTime> fecInc, Nullable<System.DateTime> fecFin)
        {
            var idAlumParameter = idAlum != null ?
                new ObjectParameter("IdAlum", idAlum) :
                new ObjectParameter("IdAlum", typeof(string));
    
            var fecIncParameter = fecInc.HasValue ?
                new ObjectParameter("FecInc", fecInc) :
                new ObjectParameter("FecInc", typeof(System.DateTime));
    
            var fecFinParameter = fecFin.HasValue ?
                new ObjectParameter("FecFin", fecFin) :
                new ObjectParameter("FecFin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarCursosAlumnoFechas_Result>("usp_ListarCursosAlumnoFechas", idAlumParameter, fecIncParameter, fecFinParameter);
        }
    
        public virtual ObjectResult<usp_ListarFacultad_Result> usp_ListarFacultad()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarFacultad_Result>("usp_ListarFacultad");
        }
    
        public virtual ObjectResult<usp_ListarProfesor_Result> usp_ListarProfesor(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarProfesor_Result>("usp_ListarProfesor", idParameter);
        }
    
        public virtual ObjectResult<usp_ListarVerDetMatricula_Result> usp_ListarVerDetMatricula(string dni)
        {
            var dniParameter = dni != null ?
                new ObjectParameter("Dni", dni) :
                new ObjectParameter("Dni", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarVerDetMatricula_Result>("usp_ListarVerDetMatricula", dniParameter);
        }
    
        public virtual ObjectResult<usp_MatriculadosSeccion_Result> usp_MatriculadosSeccion()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_MatriculadosSeccion_Result>("usp_MatriculadosSeccion");
        }
    
        public virtual int usp_Matricular(string nroMat, string idCods)
        {
            var nroMatParameter = nroMat != null ?
                new ObjectParameter("NroMat", nroMat) :
                new ObjectParameter("NroMat", typeof(string));
    
            var idCodsParameter = idCods != null ?
                new ObjectParameter("IdCods", idCods) :
                new ObjectParameter("IdCods", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_Matricular", nroMatParameter, idCodsParameter);
        }
    
        public virtual ObjectResult<string> usp_ObtenerCarreraAlumno(string idAlum)
        {
            var idAlumParameter = idAlum != null ?
                new ObjectParameter("IdAlum", idAlum) :
                new ObjectParameter("IdAlum", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_ObtenerCarreraAlumno", idAlumParameter);
        }
    
        public virtual ObjectResult<string> usp_ObtenerFacultadAlumno(string idAlum)
        {
            var idAlumParameter = idAlum != null ?
                new ObjectParameter("IdAlum", idAlum) :
                new ObjectParameter("IdAlum", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_ObtenerFacultadAlumno", idAlumParameter);
        }
    
        public virtual ObjectResult<usp_PreMatricula_Result> usp_PreMatricula(string dni)
        {
            var dniParameter = dni != null ?
                new ObjectParameter("dni", dni) :
                new ObjectParameter("dni", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_PreMatricula_Result>("usp_PreMatricula", dniParameter);
        }
    
        public virtual ObjectResult<usp_prematriculaCursos_Result> usp_prematriculaCursos(string codcar)
        {
            var codcarParameter = codcar != null ?
                new ObjectParameter("codcar", codcar) :
                new ObjectParameter("codcar", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_prematriculaCursos_Result>("usp_prematriculaCursos", codcarParameter);
        }
    
        public virtual ObjectResult<usp_Ubigeo_Departamentos_Result> usp_Ubigeo_Departamentos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Ubigeo_Departamentos_Result>("usp_Ubigeo_Departamentos");
        }
    
        public virtual ObjectResult<usp_Ubigeo_DistritosProvinciaDepartamento_Result> usp_Ubigeo_DistritosProvinciaDepartamento(string idDepartamento, string idProvincia)
        {
            var idDepartamentoParameter = idDepartamento != null ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(string));
    
            var idProvinciaParameter = idProvincia != null ?
                new ObjectParameter("IdProvincia", idProvincia) :
                new ObjectParameter("IdProvincia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Ubigeo_DistritosProvinciaDepartamento_Result>("usp_Ubigeo_DistritosProvinciaDepartamento", idDepartamentoParameter, idProvinciaParameter);
        }
    
        public virtual ObjectResult<usp_Ubigeo_ProvinciasDepartamento_Result> usp_Ubigeo_ProvinciasDepartamento(string idDepartamento)
        {
            var idDepartamentoParameter = idDepartamento != null ?
                new ObjectParameter("IdDepartamento", idDepartamento) :
                new ObjectParameter("IdDepartamento", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Ubigeo_ProvinciasDepartamento_Result>("usp_Ubigeo_ProvinciasDepartamento", idDepartamentoParameter);
        }
    
        public virtual ObjectResult<usp_VerAlumno_Result> usp_VerAlumno()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_VerAlumno_Result>("usp_VerAlumno");
        }
    
        public virtual int usp_VerAlumnoDetallado()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_VerAlumnoDetallado");
        }
    
        public virtual ObjectResult<usp_VerCursoActivo_Result> usp_VerCursoActivo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_VerCursoActivo_Result>("usp_VerCursoActivo");
        }
    
        public virtual ObjectResult<usp_VerCursoInactivo_Result> usp_VerCursoInactivo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_VerCursoInactivo_Result>("usp_VerCursoInactivo");
        }
    
        public virtual ObjectResult<usp_VerDetMatricula_Result> usp_VerDetMatricula(string dni)
        {
            var dniParameter = dni != null ?
                new ObjectParameter("dni", dni) :
                new ObjectParameter("dni", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_VerDetMatricula_Result>("usp_VerDetMatricula", dniParameter);
        }
    
        public virtual ObjectResult<usp_verEspcProfesor_Result> usp_verEspcProfesor(string idprofe)
        {
            var idprofeParameter = idprofe != null ?
                new ObjectParameter("idprofe", idprofe) :
                new ObjectParameter("idprofe", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_verEspcProfesor_Result>("usp_verEspcProfesor", idprofeParameter);
        }
    
        public virtual ObjectResult<usp_VerMatricula_Result> usp_VerMatricula()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_VerMatricula_Result>("usp_VerMatricula");
        }
    
        public virtual ObjectResult<usp_VerProfesor_Result> usp_VerProfesor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_VerProfesor_Result>("usp_VerProfesor");
        }
    
        public virtual int usp_VerProfesorDetallado()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_VerProfesorDetallado");
        }
    
        public virtual ObjectResult<usp_VerSeccion_Result> usp_VerSeccion()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_VerSeccion_Result>("usp_VerSeccion");
        }
    }
}
