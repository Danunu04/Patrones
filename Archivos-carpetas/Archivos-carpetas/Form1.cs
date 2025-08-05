using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using BE;
using BLL;

namespace Archivos_carpetas
{
    public partial class Form1 : Form
    {
        List<Carpeta> carpeta = new List<Carpeta>();
        BLLCarpeta BLLC = new BLLCarpeta();

        public Form1()
        {
            InitializeComponent();
            carpeta = BLLC.TraerCarpetasConSCYArchivos();
        }

        private void TreeView_NodeMoseClick(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarTreeView();

           
        }

        private void cargarTreeView()
        {
            treeView1.Nodes.Clear();

            // Iterar sobre cada Carpeta
            foreach (Carpeta car in carpeta)
            {
                // Crear un nodo para la carpeta
                TreeNode nodoCarpeta = new TreeNode(car.Name);  // Nombre de la carpeta
                nodoCarpeta.Tag = car;  // Asociar el objeto 'car' con el Tag del nodo
                listBox1.Items.Add(car.Name);
                foreach (Carpeta carpet in car.componenes)
                {
                    TreeNode Carpeta2 = new TreeNode(carpet.Name);
                    Carpeta2.Tag = carpet;
                    nodoCarpeta.Nodes.Add(Carpeta2);
                    listBox1.Items.Add(carpet.Name);
                    // Iterar sobre los archivos dentro de la carpeta
                    foreach (Archivo arch in carpet.componenes)
                    {
                        // Crear un nodo para el archivo
                        TreeNode nodoArchivo = new TreeNode(arch.Name);  // Nombre del archivo
                        nodoArchivo.Tag = arch;  // Asociar el objeto 'arch' con el Tag del nodo

                        // Agregar el nodo del archivo como hijo del nodo de la carpeta
                        Carpeta2.Nodes.Add(nodoArchivo);
                        listBox1.Items.Add(arch.Name);
                    }
                }
                // Agregar el nodo de la carpeta al TreeView
                treeView1.Nodes.Add(nodoCarpeta);
                
            }
           


        }
    }
}
