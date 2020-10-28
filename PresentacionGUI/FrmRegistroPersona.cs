using BLL;
using Entity;
using System;
using System.Windows.Forms;
namespace PresentacionGUI
{
    public partial class FrmRegistroPersona : Form
    {
        PersonaService personaService;
        public FrmRegistroPersona()
        {
            InitializeComponent();
            personaService = new PersonaService();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = Guardar();
            MessageBox.Show(mensaje);
        }

        private string Guardar()
        {
            Persona persona = MapearTextoAPersona();
            return personaService.Guardar(persona);
        }

        private Persona MapearTextoAPersona()
        {
            Persona persona = new Persona();
            persona.Identificacion = TxtIdentificacion.Text;
            persona.Nombre = TxtNombre.Text;
            persona.Edad = int.Parse(TxtEdad.Text);
            persona.Sexo=MapearSexo(CmbSexo.Text);
            persona.CalcularPulsacion();
            TxtPulsacion.Text = persona.Pulsacion.ToString();
            return persona;
        }

        private string MapearSexo(string sexo)
        {
            if (sexo.Equals("Femenino"))
            {
                return "F";
            }
            else
            {
                return "M";
            }
        }
    }
}
