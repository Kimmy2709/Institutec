using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;// para la clase File





namespace ProyInstitutec_GUI
{
    public partial class FrmInsertarAlumno : Form
    {
        ProxyAlumno.ServicioAlumnoClient objServiceAlumno = new ProxyAlumno.ServicioAlumnoClient();
        ProxyAlumno.AlumnoDC objAlumnoDC = new ProxyAlumno.AlumnoDC();
        ProxyUbigeo.ServicioUbigeoClient objServiceUbigeo = new ProxyUbigeo.ServicioUbigeoClient();


        public FrmInsertarAlumno()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInsertarAlumno_Load(object sender, EventArgs e)
        {


            try
            {
                CargarUbigeo("14", "01", "01");

                cboCarrera.DataSource = objServiceAlumno.ListarCarrera();
                cboCarrera.DisplayMember = "DesCar";
                cboCarrera.ValueMember = "CodCar";

                cboFacultad.DataSource = objServiceAlumno.ListarFacultad(); ;
                cboFacultad.DisplayMember = "DesFac";
                cboFacultad.ValueMember = "IdFacu";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {

            EnlazarDepartamento(IdDepa);
            EnlazarProvincia(IdDepa, IdProv);
            EnlazarDistrito(IdDepa, IdProv, IdDist);

        }

        private void EnlazarDepartamento(String IdDepartamento)
        {
            cboDep.DataSource = objServiceUbigeo.GetDepartamentos();
            cboDep.ValueMember = "IdDepartamento";
            cboDep.DisplayMember = "NomDepartamento";
            cboDep.SelectedValue = IdDepartamento;
        }

        private void EnlazarProvincia(String IdDepartamento, String IdProvincia)
        {
            cboProvincia.DataSource = objServiceUbigeo.GetProvincias(IdDepartamento);
            cboProvincia.ValueMember = "IdProvincia";
            cboProvincia.DisplayMember = "NomProvincia";
            cboProvincia.SelectedValue = IdProvincia;
        }
        private void EnlazarDistrito(String IdDepartamento, String IdProvincia, String IdDistrito)
        {
            cboDistrito.DataSource = objServiceUbigeo.GetDistritos(IdDepartamento, IdProvincia);
            cboDistrito.ValueMember = "IdDistrito";  //este nombre viene de la data contractual
            cboDistrito.DisplayMember = "NomDistrito";
            cboDistrito.SelectedValue = IdDistrito;
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EnlazarDistrito(cboDep.SelectedValue.ToString(),
                             cboProvincia.SelectedValue.ToString(), "01");
        }

        private void cboDep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EnlazarProvincia(cboDep.SelectedValue.ToString(), "01");
            EnlazarDistrito(cboDep.SelectedValue.ToString(),
                cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mskDNIAlu.Text.Trim() == String.Empty || mskDNIAlu.Text.Length != 8)
                {
                    throw new Exception("Dni vacio o no contiene 8 digitos");
                }
                if (txtNombre.Text.Trim() == String.Empty)
                {

                    throw new Exception("El Nombre del alumno es un campo obligatorio");
                }
                if (txtApePat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido paterno del alumno es un campo obligatorio");
                }
                if (txtApeMat.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido Marteno del alumno es un campo obligatorio");
                }

                if (mskTelAlu.Text.Trim() == String.Empty)
                {
                    throw new Exception("Numero de telefono invalido");
                }
                if (txtCorreoAlu.Text.Trim() == String.Empty)
                {
                    throw new Exception("Correo es un campo obligatorio");
                }
                if (txtDireccionAlum.Text.Trim() == String.Empty)
                {
                    throw new Exception("La direccion es un campo obligatorio");
                }
                if (pcbFoto.Image == null)
                {
                    throw new Exception("Debe registrar la foto.");
                }
                objAlumnoDC.Foto = File.ReadAllBytes(openFileDialog1.FileName);
                DateTime fechaNac = dtpFecha_Nac.Value;

                String Genero = "";
                if (optM.Checked == true)
                {
                    Genero = "M";
                }
                else
                {
                    Genero = "F";
                }
                Boolean activo;
                if (chkActivo.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }

                // Convertimos la foto en un arreglo de Bytes y lo almacenamos en su respectiva propiedad
                objAlumnoDC.Foto = File.ReadAllBytes(openFileDialog1.FileName);
                objAlumnoDC.Usu_Registro = "Orlando";

                //Pasamos valores alas propiedades de la instancia...
                objAlumnoDC.Ndocum = mskDNIAlu.Text.Trim();
                objAlumnoDC.NomAlu = txtNombre.Text.Trim();
                objAlumnoDC.ApePat = txtApePat.Text.Trim();
                objAlumnoDC.ApeMat = txtApeMat.Text.Trim();
                objAlumnoDC.Sexoal = Genero;
                objAlumnoDC.Estado = activo;
                objAlumnoDC.CorAlu = txtCorreoAlu.Text.Trim();
                objAlumnoDC.FecNac = fechaNac;
                objAlumnoDC.TelAlu = mskTelAlu.Text.Trim();
                objAlumnoDC.direccion = txtDireccionAlum.Text.Trim();

                objAlumnoDC.IdFacu = cboFacultad.SelectedValue.ToString();
                objAlumnoDC.CodCar = cboCarrera.SelectedValue.ToString();

                objAlumnoDC.Id_Ubi = cboDep.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                    cboDistrito.SelectedValue.ToString();
                //formulario de logeo 
                //objAlumnoDC.Usu_Registro = clsCredenciales.Login_Usuario;

                if (objServiceAlumno.InsertarAlumno(objAlumnoDC) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el alumno ");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error : " + ex.Message);

            }
        }
        private void mskDNIAlu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false) // Ni tampoco es digito
                {

                    e.Handled = true; //Se atrapa el caracter y no se imprime 
                }
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                // Si se escogio una foto se carga en el picture Box
                if (openFileDialog1.FileName != String.Empty)
                {
                    pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }



        private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string codCar = cboCarrera.SelectedValue.ToString();

        }

        private void pcbFoto_Click(object sender, EventArgs e)
        {

        }

        private void mskDNIAlu_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void gpbSexoAlu_Enter(object sender, EventArgs e)
        {

        }
    }
}
