using SegundoParcialRombo.Datos;
using SegundoParcialRombo.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SegundoParcialRombo.Windows
{
    public partial class frmRomboAE : Form
    {
        private Rombo? rombo;
        private readonly RepositorioRombos? repo;

        public frmRomboAE(RepositorioRombos? repositorio)
        {
            InitializeComponent();
            repo = repositorio;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (rombo != null)
            {
                txtDiagonalMayor.Text = rombo.DiagonalMayor.ToString();
                txtDiagonalMenor.Text = rombo.DiagonalMenor.ToString();
                switch (rombo.Contorno)
                {
                    case Contorno.Solido:
                        rbtSolido.Checked = true;
                        break;
                    case Contorno.Punteado:
                        rbtPunteado.Checked = true;
                        break;
                    case Contorno.Rayado:
                        rbtRayado.Checked = true;
                        break;
                    case Contorno.Doble:
                        rbtDoble.Checked = true;
                        break;
                }

            }
        }

        public Rombo? GetRombo()
        {
            return rombo;
        }

        public void SetRombo(Rombo rombo)
        {
            this.rombo = rombo;
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtDiagonalMayor.Text, out int diagonalMayor) ||
                diagonalMayor <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtDiagonalMayor, "Diagonal Mayor mal ingresado");
            }


            if (!int.TryParse(txtDiagonalMenor.Text, out int diagonalMenor) ||
                  diagonalMenor <= 0 || diagonalMenor >= diagonalMayor)
            {
                valido = false;
                errorProvider1.SetError(txtDiagonalMenor, "Diagonal Menor mal ingresado");
            }



            if (repo!.Existe(diagonalMayor, diagonalMenor))
            {
                valido = false;
                errorProvider1.SetError(btnOK, "Rombo existente!!!");
            }
            return valido;
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (rombo is null)
                {
                    rombo = new Rombo();
                }
                rombo.DiagonalMayor = int.Parse(txtDiagonalMayor.Text);
                rombo.DiagonalMenor = int.Parse(txtDiagonalMenor.Text);
                if (rbtSolido.Checked)
                    rombo.Contorno = Contorno.Solido;
                else if (rbtPunteado.Checked)
                    rombo.Contorno = Contorno.Punteado;
                else if (rbtRayado.Checked)
                    rombo.Contorno = Contorno.Rayado;
                else
                    rombo.Contorno = Contorno.Doble;
                DialogResult = DialogResult.OK;
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmRomboAE_Load(object sender, EventArgs e)
        {

        }
    }
}

