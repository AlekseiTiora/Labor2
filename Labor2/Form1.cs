using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labor2
{
    public partial class Form1 : Form
    {
        ToolStrip ts;

        public Form1()
        {
            this.Height = 700;//высота
            this.Width = 900;//ширина
            this.Text = "Paint Line";//загловок формы

            MainMenu menu = new MainMenu();
            MenuItem menuFile = new MenuItem("File");
            menuFile.MenuItems.Add("New", new EventHandler(menuFile_new_Select));

            menuFile.MenuItems.Add("Open", new EventHandler(menuFile_Open_Select));
            menuFile.MenuItems.Add("Save", new EventHandler(menuFile_Save_Select));
            menuFile.MenuItems.Add(new MenuItem("-"));
            menuFile.MenuItems.Add("Exit", new EventHandler(menuFile_Exit_Select));
            
            MenuItem menuEdit = new MenuItem("Edit");
            menuEdit.MenuItems.Add("Undo", new EventHandler(menuEdit_Undo_Select));
            menuEdit.MenuItems.Add("Reno", new EventHandler(menuEdit_Reno_Select));
            menuEdit.MenuItems.Add("Pen", new EventHandler(menuEdit_Pen_Select));
            MenuItem menuHelp = new MenuItem("Help");
            menuHelp.MenuItems.Add("About", new EventHandler(menuHelp_About_Select));


            menu.MenuItems.Add(menuFile);
            menu.MenuItems.Add(menuEdit);
            menu.MenuItems.Add(menuHelp);
            this.Menu = menu;


            PictureBox pb = new PictureBox();
            pb.Size = new Size(720, 560);
            pb.Location = new Point(130, 20);
            pb.ImageLocation = ("../../img/test.png");

            this.Controls.Add(pb);


        }

        private void menuEdit_Pen_Select(object sender, EventArgs e)
        {
            
        }

        private void menuEdit_Reno_Select(object sender, EventArgs e)
        {
            
        }

        private void menuEdit_Undo_Select(object sender, EventArgs e)
        {
            
        }

        private void menuHelp_About_Select(object sender, EventArgs e)
        {
            
        }

        private void menuFile_Exit_Select(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void menuFile_Save_Select(object sender, EventArgs e)
        {
            
        }

        private void menuFile_Open_Select(object sender, EventArgs e)
        {
            
        }

        private void menuFile_new_Select(object sender, EventArgs e)
        {
            

        }
    }
}
