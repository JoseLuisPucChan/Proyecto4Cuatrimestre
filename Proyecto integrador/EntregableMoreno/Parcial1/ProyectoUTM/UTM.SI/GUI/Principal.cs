using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;


namespace UTM.SI.GUI
{
    public partial class Principal : Form
    {


        public Principal()
        {
            InitializeComponent();
            CargaMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void CargaMenuArchivo()
        {
            TreeView treeView = new TreeView();
            TreeNode treeNode = new TreeNode("Archivos");
            treeView.Nodes.Add(treeNode);
            treeView.NodeMouseClick += delegate(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text == "Archivos")
                {
                    UTM.SI.GUI.frmArchivo ofrmArchivo = new GUI.frmArchivo();
                    showwindow(ofrmArchivo);
                }

            };
            nbbArchivo.RelatedControl = treeView;
        }
        public void CargaMenuXml()
        {
            TreeView treeView = new TreeView();
            TreeNode treeNode = new TreeNode("XML");
            treeView.Nodes.Add(treeNode);
            treeView.NodeMouseClick += delegate(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text == "XML")
                {
                    UTM.XML.GUI.frmXML ofrmXML = new UTM.XML.GUI.frmXML();
                    showwindow(ofrmXML);
                }

            };
            nbbXML.RelatedControl = treeView;
        }
        public void CargaMenuSqlite()
        {
            TreeView treeView = new TreeView();
            TreeNode treeNode = new TreeNode("SQLite");
            treeView.Nodes.Add(treeNode);
            treeView.NodeMouseClick += delegate(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text == "SQLite")
                {
                    //UTM.SQLite.GUI.frmSQLite ofrmSQLite = new UTM.SQLite.GUI.frmSQLite();
                    //showwindow(ofrmSQLite);
                }

            };
            nbbSQLite.RelatedControl = treeView;
        }
        public void CargaPracticas()
        {
            TreeView treeView = new TreeView();
            TreeNode treenode1 = new TreeNode("Practica 1- Agenda");
            TreeNode treeNode2 = new TreeNode("Practica 2- Traductor");
            TreeNode treeNode3 = new TreeNode("Practica 3- Libreria XML");
            TreeNode treeNode4 = new TreeNode("Practica 4- Libreria SQLite");
            TreeNode treeNode5 = new TreeNode("Practica 5- Libreria Json");
            treeView.Nodes.Add(treenode1);
            treeView.Nodes.Add(treeNode2);
            treeView.Nodes.Add(treeNode3);
            treeView.Nodes.Add(treeNode4);
            treeView.Nodes.Add(treeNode5);
            treeView.NodeMouseClick += delegate(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text == "Practica 1- Agenda")
                {
                    AgendaContactos.Agenda ofrmagenda = new AgendaContactos.Agenda();
                    showwindow(ofrmagenda);
                }
                if (clickedNode.Text == "Practica 2- Traductor")
                {
                    Practica_1.GUI.Inicio ofrmTraductor = new Practica_1.GUI.Inicio();
                    showwindow(ofrmTraductor);
                }
                if (clickedNode.Text == "Practica 3- Libreria XML")
                {
                    Practica2.Principal ofrmPractica3 = new Practica2.Principal();
                    showwindow(ofrmPractica3);
                }
                if (clickedNode.Text == "Practica 4- Libreria SQLite")
                {
                    ManejoSQLite.Principal ofrmlite = new ManejoSQLite.Principal();
                    showwindow(ofrmlite);
                }
                //if (clickedNode.Text == "Practica 5- Libreria Json")
                //{
                //    Practica2.Principal = new UTM.SQLite.GUI.frmSQLite();
                //    showwindow(ofrmSQLite);
                //}

            };
            nbbPracticas.RelatedControl = treeView;
        }
        public void CargaMenu()
        {
            CargaMenuArchivo();
            CargaMenuXml();
            CargaMenuSqlite();
            CargaPracticas();
        }
        private void showwindow(Form ventanaMostrar)
        {
            bool found = false;
            Form[] charr = this.MdiChildren;
            if (charr.Length == 0)
            {
                ventanaMostrar.MdiParent = this;
                ventanaMostrar.Show();
                ventanaMostrar.WindowState = FormWindowState.Maximized;
            }
            else
            {
                foreach (Form chform in charr)
                {
                    if ((chform.Text) == (ventanaMostrar.Text))
                    {
                        chform.Activate();
                        found = true;
                        break;
                    }
                    else
                    {
                        found = false;
                    }
                }
                if (found == false)
                {
                    ventanaMostrar.MdiParent = this;
                    ventanaMostrar.Show();
                    ventanaMostrar.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void nbPrincipal_OnNavigateBarButtonSelected(MT.WindowsUI.NavigationPane.NavigateBarButton tNavigateBarButton)
        {

        }
    }
}
