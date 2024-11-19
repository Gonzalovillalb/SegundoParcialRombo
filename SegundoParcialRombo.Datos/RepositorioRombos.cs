using SegundoParcialRombo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialRombo.Datos
{
    public class RepositorioRombos
    {
        private List<Rombo> rombos;
        private string nombreArchivo = "Rombos.txt";
        private string rutaProyecto = Environment.CurrentDirectory;
        private string rutaCompletaArchivo;

        public RepositorioRombos()
        {
            rombos = LeerDatos();
        }

        public void AgregarRombo(Rombo rombo)
        {
            if (!Existe(rombo))
            {
                rombos.Add(rombo);
            }
        }

        public void EliminarRombo(Rombo rombo)
        {
            rombos.Remove(rombo);
        }

     
        public bool Existe(Rombo rombo)
        {
            return rombos.Any(r => r.DiagonalMayor == rombo.DiagonalMayor &&
                                    r.DiagonalMenor == rombo.DiagonalMenor &&
                                    r.Contorno == rombo.Contorno);
        }
        public bool Existe(int diagonalMayor, int diagonalMenor)//este es el frmAE para validar
        {

            return rombos.Any(rombo => rombo.DiagonalMayor == diagonalMayor &&
            rombo.DiagonalMenor == diagonalMenor);
        }
    
        public List<Rombo> Filtrar(Contorno contornoSeleccionado)
        {
            return rombos.Where(r => r.Contorno == contornoSeleccionado).ToList();
        }

        public int GetCantidad(Contorno? contornoSeleccionado = null)
        {
            if (contornoSeleccionado == null)
                return rombos.Count;
            return rombos.Count(r => r.Contorno == contornoSeleccionado);
        }

        public List<Rombo> ObtenerRombos()
        {
            return new List<Rombo>(rombos);
        }


        public List<Rombo> OrdenarAsc()
        {
            return rombos.OrderBy(rombo => rombo.CalcularArea()).ToList();
        }

        public List<Rombo> OrdenarDesc()
        {
            return rombos.OrderByDescending(e => e.CalcularArea()).ToList();
        }

   
        public void GuardarDatos()
        {
            rutaCompletaArchivo = Path.Combine(rutaProyecto, nombreArchivo);
            using (var escritor = new StreamWriter(rutaCompletaArchivo))
            {
                foreach (var rombo in rombos)
                {
                    string linea = ConstruirLinea(rombo);
                    escritor.WriteLine(linea);
                }
            }
        }


        private string ConstruirLinea(Rombo rombo)
        {
            return $"{rombo.DiagonalMayor}|{rombo.DiagonalMenor}|{(int)rombo.Contorno}";
        }


        private List<Rombo> LeerDatos()
        {
            var listaRombos = new List<Rombo>();
            rutaCompletaArchivo = Path.Combine(rutaProyecto, nombreArchivo);

            if (!File.Exists(rutaCompletaArchivo))
            {
                return listaRombos;
            }
            using (var lector = new StreamReader(rutaCompletaArchivo))
            {
                while (!lector.EndOfStream)
                {
                    string? linea = lector.ReadLine();
                    Rombo? rombo = ConstruirRombo(linea);
                    listaRombos.Add(rombo);
                      
                    
                }
            }
            return listaRombos;
        }
          
        

       
        private Rombo? ConstruirRombo(string linea)
        {
            var campos = linea.Split('|');
                var diagonalMayor = int.Parse(campos[0]);
                var diagonalMenor = int.Parse(campos[1]);
                var contorno = (Contorno)Enum.Parse(typeof(Contorno), campos[2]);
                return new Rombo(diagonalMayor, diagonalMenor, contorno);
           
        }
    }
}