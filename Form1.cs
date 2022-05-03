using System.Text.RegularExpressions;

namespace WordFreqCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CargarArchivo_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";//Texto
            textBox1.Text = "";//Contador
            //Variables para contabilizar las palabras
            Dictionary<int, string> DicCyP = new Dictionary<int, string>();
            Dictionary<string, int> DicPalabras = new Dictionary<string, int>();
            //Cargar el archivo a una variable tipo string
            string rutaArchivo = string.Empty;
            OpenFileDialog openFileDialogRuta = new OpenFileDialog(){Filter = "Text files (*.txt)|*.txt", Title = "Cargar Archivo TXT"};
            //Valido que el usuario seleccione un archivo
            if (openFileDialogRuta.ShowDialog() == DialogResult.OK)
            {
                //Obtiene la ruta absoluta del archivo
                rutaArchivo = openFileDialogRuta.FileName;
            }
            if (rutaArchivo != "")
            {
                //Cargar Txt en una variable string
                FileInfo file = new FileInfo(rutaArchivo);
                string contenido = file.OpenText().ReadToEnd();
                //Adecuar el string contenido
                contenido = contenido.Replace(".", "");
                string textoPlanoS = Regex.Replace(contenido, @"[^&\w\s]|\n|\r", "*");
                textoPlanoS = Regex.Replace(textoPlanoS, @"\*{2,}", "*");
                //.Replace("$&\*", "*");
                string textoPlano = Regex.Replace(contenido, @"[^&\w\s]|\n|\r", " ").ToLower();
                textoPlano = Regex.Replace(textoPlano, @"\s{2,}", " ");
                string[] listaTextoPlano = textoPlano.Split(" ");
                //contar caracteres y palabras
                int caracteres = 0;
                int palabras = 0;
                foreach (char c in textoPlanoS)
                {
                    if (c != '*') { caracteres++; }
                }
                palabras = listaTextoPlano.Length;
                //Asignar el valor a los diccionarios
                DicCyP.Add(palabras, "words");
                DicCyP.Add(caracteres, "characters");
                foreach (string i in listaTextoPlano)
                {
                    if (!DicPalabras.ContainsKey(i)) { DicPalabras.Add(i, 1); }
                    else { DicPalabras[i] = DicPalabras[i] + 1; }
                }

                //Visualizar Diccionarios
                string a = "";
                foreach (KeyValuePair<int, string> user in DicCyP)
                { a += string.Format("{0}\t\t{1}\r\n", user.Key, user.Value); }

                a += "\r\n";

                foreach (KeyValuePair<string, int> user in DicPalabras.OrderByDescending(user => user.Value))
                { a += string.Format("{0}:\t\t{1,-5}\r\n", user.Key, user.Value); }

                textBox2.Text = contenido;//Texto
                textBox1.Text = a;//Contador
            }
            else { MessageBox.Show("Ruta vacía, por favor seleccione un archivo"); }

        }

        private void Visualizar_Click(object sender, EventArgs e)
        {

        }
    }
}