﻿using System;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace TissueViewer
{
    public partial class Form1 : Form
    {
        public string path = Properties.Settings.Default.rootPath ?? @"C:\Users\Kosta\Desktop";

        public bool isDirectory(TreeNode treeNode)
        {
            return (treeNode.Tag as TreeNodeMetadata).FSItem == FSItem.Directory;
        }

        public Form1()
        {
            InitializeComponent();

            //load Folder structure
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //webBrowser1.Size = webBrowser1.Document.Body.ScrollRectangle.Size;
            ListDirectory(treeView1, path);
            MessageBox.Show(Properties.Settings.Default.myColor);
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();

            var rootDrectoryInfo = new DirectoryInfo(path);

            treeView.Nodes.Add(CreateDirectoryNode(rootDrectoryInfo));
        }

        

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            directoryNode.Tag = new TreeNodeMetadata(FSItem.Directory, directoryInfo.FullName, null);
            //directoryNode.Tag 
            foreach (var directory in directoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            }

            foreach (var file in directoryInfo.GetFiles())
            {
                var fileNode = new TreeNode(file.Name);
                fileNode.Tag = new TreeNodeMetadata(FSItem.File, file.FullName, file.Extension);
                directoryNode.Nodes.Add(fileNode);
            }

            return directoryNode;

            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!isDirectory(treeView1.SelectedNode))
            {
                TreeNode selectedNode = treeView1.SelectedNode;
                var metadata = (selectedNode.Tag as TreeNodeMetadata);
                string filePath = metadata.FullName;
                Uri uri = new Uri(filePath);
                webBrowser1.Url = uri;
                pictureBox1.ImageLocation = filePath;
                richTextBox1.Text = File.ReadAllText(filePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isDirectory(treeView1.SelectedNode))
            {
                String TreeNodeName = treeView1.SelectedNode.ToString().Replace("TreeNode: ", String.Empty);
                //MessageBox.Show(path + "\\" + TreeNodeName);
                System.Diagnostics.Process.Start(path + "\\" + TreeNodeName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
            textBox1.Text = path;
            ListDirectory(treeView1, path);
            SaveRootPath();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                path = textBox1.Text;
                ListDirectory(treeView1, path);
            }
            catch (Exception)
            {
                MessageBox.Show("Can't Find Folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                path = textBox1.Text;
                //ListDirectory(treeView1, path);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    ListDirectory(treeView1, path);
                    SaveRootPath();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't Find Folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void SaveRootPath()
        {
            ConfigurationManager.AppSettings.Set("rootPath", path);
            Properties.Settings.Default.myColor = path;
            Properties.Settings.Default.Save();
            //System.Configuration.ConfigurationManager.AppSettings["rootPath"] = path;
            //Properties.Settings.Default.Save();
        }
    }
}
