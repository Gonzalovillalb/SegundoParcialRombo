using SegundoParcialRombo.Datos;
using SegundoParcialRombo.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SegundoParcialRombo.Windows
{
    public partial class frmRombos : Form
    {
        private RepositorioRombos? repositorio;
        private int cantidadRegistros;
        private List<Rombo> rombos;
        public frmRombos()
        {
            InitializeComponent();
            repositorio = new RepositorioRombos();
        }



        private void CargarComboContornos(ref ToolStripComboBox tsCboBordes)
        {
            var listaBordes = Enum.GetValues(typeof(Contorno));
            foreach (var item in listaBordes)
            {
                tsCboBordes.Items.Add(item);
            }
            tsCboBordes.DropDownStyle = ComboBoxStyle.DropDownList;
            tsCboBordes.SelectedIndex = 0;

        }




        private void frmElipses_Load(object sender, EventArgs e)
        {
            CargarComboContornos(ref tsCboContornos);

            cantidadRegistros = repositorio!.GetCantidad();
            if (cantidadRegistros > 0)
            {
                rombos = repositorio.ObtenerRombos();
                MostrarDatosGrilla();
                MostrarCantidadRegistros();
            }

        }
        private void MostrarCantidadRegistros()
        {
            txtCantidad.Text = repositorio.GetCantidad().ToString();
        }

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            frmRomboAE frm = new frmRomboAE(repositorio) { Text = "Agregar Rombo" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Rombo? elipse = frm.GetRombo();
            try
            {
                if (!repositorio!.Existe(elipse!))
                {
                    repositorio.AgregarRombo(elipse!);
                    DataGridViewRow r = ConstruirFila(dgvDatos);
                    SetearFila(r, elipse!);
                    AgregarFila(r, dgvDatos);
                    MessageBox.Show("Registro agregado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("Registro existente!!!", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Alg�n error!!!", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            MostrarCantidadRegistros();
        }
        private void tsbBorrar_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            Rombo rombos = (Rombo)r.Tag!;
            DialogResult dr = MessageBox.Show("�Desea borrar la rombos?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) { return; }
            try
            {
                repositorio!.EliminarRombo(rombos);
                EliminarFila(r, dgvDatos);
                MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception)
            {

                MessageBox.Show("Alg�n error!!!", "Error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            MostrarCantidadRegistros();
        }

        private void SetearFila(DataGridViewRow r, Rombo rombo)
        {
            r.Cells[0].Value = rombo.DiagonalMayor;
            r.Cells[1].Value = rombo.DiagonalMenor;
            r.Cells[2].Value = rombo.Contorno.ToString();
            r.Cells[3].Value = rombo.CalcularArea().ToString("N2");
            r.Cells[4].Value = rombo.CalcularPerimetro().ToString("N2");

            r.Tag = rombo;
        }
        private void MostrarDatosGrilla()
        {
            LimpiarGrilla(dgvDatos);
            foreach (var item in rombos!)
            {
                var r = ConstruirFila(dgvDatos);
                SetearFila(r, item);
                AgregarFila(r, dgvDatos);
            }
        }
        private void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        public void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }

        private DataGridViewRow ConstruirFila(DataGridView dgvDatos)
        {

            var r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void tsbSalir_Click_1(object sender, EventArgs e)
        {
            repositorio!.GuardarDatos();
            MessageBox.Show("Fin del Programa", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void tsbActualizar_Click_1(object sender, EventArgs e)
        {

            rombos = repositorio!.ObtenerRombos();
            MostrarDatosGrilla();
        }

        private void lado09ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rombos = repositorio!.OrdenarAsc();
            MostrarDatosGrilla();
        }

        private void lado90ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rombos = repositorio!.OrdenarDesc();
            MostrarDatosGrilla();
        }
        private void EliminarFila(DataGridViewRow r, DataGridView grid)
        {
            grid.Rows.Remove(r);
        }

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0) return;
            var rSeleccionada = dgvDatos.SelectedRows[0];
            Rombo? rombo = (Rombo)rSeleccionada.Tag!;
            frmRomboAE frm = new frmRomboAE(repositorio!) { Text = "Editar Rombo" };
            frm.SetRombo(rombo);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            rombo = frm.GetRombo();
            SetearFila(rSeleccionada, rombo);
            MessageBox.Show("Registro editado!!", "Mensaje",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            MostrarCantidadRegistros();
        }
        private void CargarComboBordes(ref ToolStripComboBox tsCboContorno)
        {
            var listaBordes = Enum.GetValues(typeof(Contorno));
            foreach (var item in listaBordes)
            {
                tsCboContorno.Items.Add(item);
            }
            tsCboContorno.DropDownStyle = ComboBoxStyle.DropDownList;
            tsCboContorno.SelectedIndex = 0;

        }
        private void frmRombos_Load(object sender, EventArgs e)
        {
            CargarComboBordes(ref tsCboContornos);
            cantidadRegistros = repositorio!.GetCantidad();
            if (cantidadRegistros > 0)
            {
                rombos = repositorio.ObtenerRombos();
                MostrarDatosGrilla();
                MostrarCantidadRegistros();
            }
        }

        private void bordeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
