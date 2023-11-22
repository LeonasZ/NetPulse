using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NetPulse
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;database=UserLoginTest;integrated security=true");
        public void logear(string usuario, string contrasena)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Nombre, TipoUsuario From Usuarios Where Usuario = @usuario and Contraseña = @pass", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pass", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    string nombreUsuario = dt.Rows[0]["Nombre"].ToString();
                    string tipoUsuario = dt.Rows[0]["TipoUsuario"].ToString();

                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        //Response.Write("<script>alert('Ingresaste como Administrador');</script>");
                        Session["NombreUsuario"] = nombreUsuario;
                        Session["TipoUsuario"] = tipoUsuario;
                        Response.Redirect("Default.aspx");
                    }
                    else if (dt.Rows[0][1].ToString() == "Tecnico")
                    {
                        //Response.Write("<script>alert('Ingresaste como Usuario');</script>");
                        Session["NombreUsuario"] = nombreUsuario;
                        Session["TipoUsuario"] = tipoUsuario;
                        Response.Redirect("MainTecnico.aspx");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Error, ingrese credenciales correctas');</script>");
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                //Agregar para ver el error de forma correcta ya que MessageBox no existe acá
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            logear(this.tbUser.Text, this.tbPass.Text);
        }
    }
}